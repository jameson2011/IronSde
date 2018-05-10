namespace IronSde.Generator

open System

type TypesWriter(targetPath: string) =

    let toItemTypeGroupSource(value: ItemGroup) =
        sprintf "{ ItemTypeGroupData.id = %i; categoryId = %i }" value.id value.categoryId
    
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
                    |> Source.indentMany

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
                    |> Source.indentMany

        let headers = seq {
                            yield Source.declareIronSdeNamespace
                            yield Source.declareItemTypeGroupsEnum
                        }

        use writer = new System.IO.StreamWriter(targetFilePath)
        Seq.concat [headers; enums; ] |> Seq.iter writer.WriteLine 
        writer.Flush()
        writer.Close()

    member __.WriteItemTypeGroups(itemTypeGroups: seq<ItemGroup>) (itemTypes: seq<ItemType>)=
        let targetFilePath = IO.combine targetPath "ItemTypeGroups.fs"
        let headers = seq {
                            yield Source.declareItemtypesNamespace            
                            yield Source.importIronSdeTypesNamespace
                            yield Source.declareItemTypeGroupsModule
                        }

        let groupCases = itemTypeGroups   
                            |> Seq.map (fun g -> g.id, (toItemTypeGroupSource g))
                            |> Seq.map (fun (id,s) -> sprintf "| %i -> Some %s" id s)
        let groupFunc = seq {
                                yield "let group = function" 
                                yield! groupCases |> Source.indentMany
                                yield Source.defaultNoneCase |> Source.indent
                            } |> Source.indentMany

        let groupsByCategory = itemTypeGroups   
                                        |> Seq.map (fun ig -> ig.categoryId, ig.id)
                                        |> Seq.groupBy (fun (c,i) -> c)
                                        |> Seq.map (fun (catId,groupIds) -> catId, groupIds |> Seq.map snd |> Seq.sort |> Array.ofSeq )
                                        |> Seq.map (fun (catId,groupIds) -> sprintf "| %i -> %s" catId (Source.toArrayOfInts groupIds)  )
        
        let groupsByCategoryFunc = 
            seq{
                    yield "let groupsByCategory = function" 
                    yield! groupsByCategory |> Source.indentMany
                    yield Source.defaultEmptyArrayCase |> Source.indent
                } |> Source.indentMany
        
        let itemTypesByGroup = itemTypes 
                                |> Seq.groupBy (fun a -> a.groupId)
                                |> Seq.map (fun (groupId, types) -> groupId, (types |> Seq.map (fun t -> t.id) |> Seq.sort |> Array.ofSeq) )
        let itemTypesByGroupFunc =            
            seq {
                    yield "let itemTypesByGroup = function" 
                    yield! itemTypesByGroup 
                                |> Seq.map (fun (groupId, typeIds) -> sprintf "| %i -> %s" 
                                                                            groupId (Source.toArrayOfInts typeIds) 
                                                                            |> Source.indent)
                    yield Source.defaultEmptyArrayCase |> Source.indent
                } |> Source.indentMany

        use writer = new System.IO.StreamWriter(targetFilePath)
        
        Seq.concat [headers; groupFunc; groupsByCategoryFunc; itemTypesByGroupFunc; ] |> Seq.iter writer.WriteLine 
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
            let attrs = itemAttrGroups  |> Map.tryFind value.id
                                        |> Option.defaultValue [||]
            {IronSde.Types.ItemTypeData.id = value.id; 
                                        groupId = value.groupId; 
                                        capacity = value.capacity;
                                        marketGroupId = value.marketGroupId;
                                        mass = value.mass;
                                        volume = value.volume;
                                        radius = value.radius;
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
            sprintf "let private %s() = {ItemTypeData.id = %i; groupId = %i; marketGroupId = %s; attributes=%s; capacity=%s; mass=%s; radius=%s; volume=%s}"
                    (itemTypeFuncName itemType) itemType.id itemType.groupId (Source.ofInt32Option itemType.marketGroupId) (itemType.attributes |> Seq.map itemTypeAttrSource |> Source.toArrayOfStrings)
                   (Source.ofFloatOption itemType.capacity) (Source.ofFloatOption itemType.mass) (Source.ofFloatOption itemType.radius) (Source.ofFloatOption itemType.volume) 
        
        let itemTypeFuncs = itemTypes |> Seq.map (itemTypeFunc >> Source.indent)                            
        

        let itemTypesMatchFunc (name: string, _, items: seq<IronSde.Types.ItemTypeData>)=
            seq{
                yield sprintf "let private %s id =" name 
                yield "match id with " |> Source.indent
                yield! (items |> Seq.map (fun it -> sprintf "| %i -> %s() |> Some" it.id (itemTypeFuncName it) |> Source.indent))
                yield Source.defaultNoneCase |> Source.indent
            } |> Source.indentMany
            

        let itemTypeChunks = itemTypes 
                                |> Seq.splitInto 20
                                |> Seq.map (fun items -> items |> Seq.map (fun x -> x.id) |> Seq.last, items )
                                |> Seq.map (fun (lastId, items) -> itemTypesFuncName lastId, lastId, items)
                                |> List.ofSeq

        let itemTypeMatchFuncs = itemTypeChunks |> Seq.collect itemTypesMatchFunc

        let itemTypeMatch = seq {
                                    yield "let itemType id = "
                                    yield "match id with " |> Source.indent
                                    yield! itemTypeChunks 
                                                |> Seq.map (fun (funcName, lastId, _) -> sprintf "| x when x <= %i -> %s x" lastId funcName )
                                                |> Source.indentMany
                                    yield Source.defaultNoneCase |> Source.indent
                                } |> Source.indentMany                

        let headers = seq {
                            yield Source.declareItemtypesNamespace
                            yield Source.importIronSdeTypesNamespace
                            yield Source.declareItemTypesModule
                        }
        
        
        use writer = new System.IO.StreamWriter(targetFilePath)
        Seq.concat [headers; itemTypeFuncs; itemTypeMatchFuncs; itemTypeMatch; ] |> Seq.iter writer.WriteLine 
        writer.Flush()
        writer.Close()
