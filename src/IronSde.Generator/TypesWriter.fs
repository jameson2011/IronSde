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

    member __.WriteItemTypes(values: seq<ItemType>)=
        let values = values |> Array.ofSeq
        // TODO:
        ignore 0