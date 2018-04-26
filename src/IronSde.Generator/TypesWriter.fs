namespace IronSde.Generator

open System

type TypesWriter(targetPath: string) =
    
    member __.WriteItemTypeCategoryEnums(values: seq<Name>) =
        let targetFilePath = IO.combine targetPath "ItemTypeCategoryEnum.fs"
        
        let values = values |> List.ofSeq
        let toEnum = Source.cleanEnumName >> Source.toEnumName
        let toName (name: Name) = name.name |> toEnum

        let names = values  |> Seq.map toName
        if not (Strings.areUnique names) then
            invalidOp "Duplicate names found"

        let enums = values                      
                    |> Seq.map (fun at -> sprintf "| %s = %i" (at.name |> toEnum) at.id)
                    |> Seq.map Source.indent

        let headers = seq {
                            yield Source.declareIronSdeNamespace
                            yield Source.declareItemTypeCategoryEnumsTypeName
                        }
        use writer = new System.IO.StreamWriter(targetFilePath)
        Seq.concat [headers; enums;] |> Seq.iter writer.WriteLine 
        writer.Flush()
        writer.Close()

    member __.WriteItemTypeGroupEnums(values: seq<ItemGroup>)=
        let targetFilePath = IO.combine targetPath "ItemTypeGroupEnum.fs"
        
        let name (value: ItemGroup) =
            match value.name with
            | "" -> "Null"
            | "Miscellaneous" 
            | "Stargate"
            | "Services"
            | "Laboratory" -> sprintf "%s%i" value.name value.id             
            | x when (Source.isValidStart x) -> x
            | x when (Source.isNpcStart x) -> sprintf "Npc%s" (x.Substring 1)
            | x when (x.Chars 0 = '#') -> x.Substring 1
            | x -> sprintf "ItemGroup%s" x 
        
        let values = values |> List.ofSeq
        let toEnum = Source.cleanEnumName >> Source.toEnumName
        let toName (item: ItemGroup) = item |> name |> toEnum

        let names = values  |> Seq.map toName |> Array.ofSeq
        if not (Strings.areUnique names) then
            invalidOp "Duplicate names found"

        let enums = values                      
                    |> Seq.map (fun at -> sprintf "| %s = %i" (at |> toName) at.id)
                    |> Seq.map Source.indent

        let headers = seq {
                            yield Source.declareIronSdeNamespace
                            yield Source.declareItemTypeGroupsEnum
                        }

        use writer = new System.IO.StreamWriter(targetFilePath)
        Seq.concat [headers; enums; ] |> Seq.iter writer.WriteLine 
        writer.Flush()
        writer.Close()

    member __.WriteItemTypeGroups(values: seq<ItemGroup>)=
        let targetFilePath = IO.combine targetPath "ItemTypeGroups.fs"
        let headers = seq {
                            yield Source.declareItemtypesNamespace            
                            yield Source.importIronSdeTypesNamespace
                            yield Source.declareItemTypeGroupsModule
                        }
        
        let groupsByCategory = values   |> Seq.map (fun ig -> ig.categoryId, ig.id)
                                        |> Seq.groupBy (fun (c,i) -> c)
                                        |> Seq.map (fun (catId,groupIds) -> catId, groupIds |> Seq.map snd |> Array.ofSeq )
                                        |> Seq.map (fun (catId,groupIds) -> sprintf "| %i -> Some %s" catId (Source.toArrayOfInts groupIds) |> Source.indent2 )
        
        let groupsByCategoryFunc = 
            seq{
                    yield "let groupsByCategory = function" |> Source.indent
                    yield! groupsByCategory                    
                    yield "| _  -> None" |> Source.indent2
                }
        
        use writer = new System.IO.StreamWriter(targetFilePath)
        Seq.concat [headers; groupsByCategoryFunc; ] |> Seq.iter writer.WriteLine 
        writer.Flush()
        writer.Close()

    member __.WriteItemTypes(itemTypes: seq<ItemType>) (itemTypeAttrs: seq<ItemTypeAttribute>)=
        let targetFilePath = IO.combine targetPath "ItemTypes.fs"
        
        let toAttrData (attr: ItemTypeAttribute) : IronSde.Types.ItemTypeAttributeData = 
                {IronSde.Types.ItemTypeAttributeData.attributeId = attr.attributeId; value = attr.value }

        let itemAttrGroups = itemTypeAttrs  |> Seq.groupBy (fun a -> a.itemTypeId)
                                            |> Seq.map (fun (id,xs) -> id, (xs |> Seq.map toAttrData |> Array.ofSeq ))
                                            |> Map.ofSeq
        
        let toItemType (value: ItemType) : IronSde.Types.ItemTypeData= 
            let attrs = itemAttrGroups |> Map.tryFind value.id
                                        |> Option.defaultValue [||]
            {IronSde.Types.ItemTypeData.id = value.id; 
                                        groupId = value.groupId; 
                                        attributes = attrs }
        
        
        let itemTypes = itemTypes 
                        |> Seq.sortBy (fun a -> a.id)
                        |> Seq.map toItemType
                        |> Array.ofSeq
        
        let itemTypeAttrSource (value: IronSde.Types.ItemTypeAttributeData) =
            sprintf "{ ItemTypeAttributeData.attributeId=%i; value=%s }" value.attributeId (Source.ofFloatOption value.value)

        let itemTypeFuncName (itemType: IronSde.Types.ItemTypeData) = sprintf "itemtype%i" itemType.id
        let itemTypesFuncName (id) = sprintf "itemtypes%i" id
        let itemTypeFunc (itemType: IronSde.Types.ItemTypeData) =            
            sprintf "let private %s() = {ItemTypeData.id = %i; groupId = %i; attributes=%s}"
                    (itemTypeFuncName itemType) itemType.id itemType.groupId (itemType.attributes |> Seq.map itemTypeAttrSource |> Source.toArrayOfStrings)
        
        let itemTypeFuncs = itemTypes |> Seq.map (itemTypeFunc >> Source.indent)                            
        

        let itemTypesMatchFunc (name: string, _, items: seq<IronSde.Types.ItemTypeData>)=
            seq{
                yield sprintf "let private %s id =" name |> Source.indent
                yield "match id with " |> Source.indent2
                yield! (items |> Seq.map (fun it -> sprintf "| %i -> %s() |> Some" it.id (itemTypeFuncName it) |> Source.indent2))
                yield Source.defaultNoneCase |> Source.indent2
            }
            

        let itemTypeChunks = itemTypes 
                                |> Seq.splitInto 20
                                |> Seq.map (fun items -> items |> Seq.map (fun x -> x.id) |> Seq.last, items )
                                |> Seq.map (fun (lastId, items) -> itemTypesFuncName lastId, lastId, items)
                                |> List.ofSeq

        let itemTypeMatchFuncs = itemTypeChunks |> Seq.collect itemTypesMatchFunc

        let itemTypeMatch = seq {
                                    yield "let itemtype id = " |> Source.indent
                                    yield "match id with " |> Source.indent2
                                    yield! itemTypeChunks 
                                                |> Seq.map (fun (funcName, lastId, _) -> sprintf "| x when x <= %i -> %s x" lastId funcName |> Source.indent2)
                                    yield Source.defaultNoneCase |> Source.indent2
                                }                                                                

        let headers = seq {
                            yield Source.declareItemtypesNamespace
                            yield Source.importIronSdeTypesNamespace
                            yield Source.declareItemTypesModule
                        }
        
        
        use writer = new System.IO.StreamWriter(targetFilePath)
        Seq.concat [headers; itemTypeFuncs; itemTypeMatchFuncs; itemTypeMatch; ] |> Seq.iter writer.WriteLine 
        writer.Flush()
        writer.Close()
