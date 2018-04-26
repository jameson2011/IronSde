namespace IronSde.Generator

open System

type AttributeWriter(targetPath: string)=
    
    member __.WriteAttributeCategoryEnums(values: seq<AttributeCategory>)=
        let targetFilePath = IO.combine targetPath "AttributeCategoriesEnum.fs"
        let headers = seq {
                            yield Source.declareIronSdeNamespace
                            yield Source.declareAttributeCategoriesEnumName
                        }
        let name (value: AttributeCategory) = 
            match value.name with
            | "" -> "Null"
            | x -> x

        let names = values  |> Seq.map (fun at -> at |> name |> Source.toEnumName) 
        if not (Strings.areUnique names) then
            invalidOp "Duplicate names found"
        let enums = values  
                    |> Seq.map ((fun at -> sprintf "| %s = %i" (at |> name |> Source.toEnumName) at.id) >> Source.indent)


        use writer = new System.IO.StreamWriter(targetFilePath)
        Seq.concat [headers; enums; ] |> Seq.iter writer.WriteLine 
        writer.Flush()
        writer.Close()

    member __.WriteAttributeTypes(values: seq<AttributeType>)=
        let targetFilePath = IO.combine targetPath "AttributeTypes.fs"
        let headers = seq {
                            yield Source.declareItemtypesNamespace            
                            yield Source.importIronSdeTypesNamespace
                            yield Source.declareAttributeTypesModule
                        }
        
        let typeCase (value: AttributeType)=
            sprintf "| %i -> Some { IronSde.Types.AttributeTypeData.id = %i; categoryId = %s; name = \"%s\"; defaultValue = %s}"
                value.id value.id (Source.ofInt32Option value.categoryId) value.name (Source.ofFloatOption value.defaultValue)
        let typeFunc = seq{
                            yield Source.indent "let attributeType = function"
                            yield! values |> Seq.map (typeCase >> Source.indent2)
                            yield Source.defaultNoneCase |> Source.indent2
                            }

        use writer = new System.IO.StreamWriter(targetFilePath)
        Seq.concat [headers; typeFunc; ] |> Seq.iter writer.WriteLine 
        writer.Flush()
        writer.Close()

    member __.WriteAttributeTypeEnums(values: seq<AttributeType>)=
        let targetFilePath = IO.combine targetPath "AttributeTypesEnum.fs"
        
        // check that we do not have dupe names
        let values = values |> List.ofSeq

        let names = values  |> Seq.map (fun at -> Source.toEnumName at.name) 
        if not (Strings.areUnique names) then
            invalidOp "Duplicate names found"
                         
        let enums = values  
                    |> Seq.map ((fun at -> sprintf "| %s = %i" (at.name |> Source.toEnumName) at.id) >> Source.indent)

        let headers = seq {
                            yield Source.declareIronSdeNamespace
                            yield Source.declareAttributeTypesEnumName
                        }
        use writer = new System.IO.StreamWriter(targetFilePath)
        Seq.concat [headers; enums; ] 
                |> Seq.iter writer.WriteLine 
        writer.Flush()
        writer.Close()
        
    member __.WriteItemTypeAttributes(values: seq<ItemTypeAttribute>)=
        // TODO: float over int!
        let itemAttrGroups = values |> Seq.groupBy (fun a -> a.itemTypeId)
                                    |> Array.ofSeq
        
        ignore 0


