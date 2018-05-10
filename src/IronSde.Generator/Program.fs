namespace IronSde.Generator


module Program=
    
    let private prefix msg = sprintf "%s %s" (System.DateTime.UtcNow.ToLongTimeString()) msg
    let private console = prefix >> System.Console.Out.WriteLine
    let private consoleError = prefix >> System.Console.Error.WriteLine
    
    let private writeNames source target =        
        let writer = new NamesSourceWriter(target, 8)
                
        let typesReader = new TypesReader(source)

        console "Writing category names..."
        typesReader.CategoryNames() 
            |> writer.WriteCategories 

        console "Writing group names..."
        typesReader.GroupNames()
            |> writer.WriteGroups

        console "Writing type names..."
        typesReader.TypeNames()
            |> writer.WriteTypes

        console "Writing names..."
        NamesReader.names source
            |> writer.WriteNames
        
        console "Finishing names..."
        writer.Close()

        console "Finished writing names."

    let private writeUniverse source target =         
        console "Writing universe..."
        UniverseReader.regions source
                        |> Seq.cache
                        |> UniverseSourceWriter.write console target

        console "Finished writing universe."

    let private writeTypes source target sharedTarget =         
        let marketGroupsReader = new MarketGroupsReader(source)
        let typesReader = new TypesReader(source)

        let marketGroupsWriter = new MarketGroupsWriter(target)
        let sharedMarketGroupsWriter = new MarketGroupsWriter(sharedTarget)
        let typesWriter = new TypesWriter(target)
        let sharedTypesWriter = (new TypesWriter(sharedTarget))
        let attributesWriter = new AttributeWriter(target)
        let sharedAttributeWriter = new AttributeWriter(sharedTarget)
        
        console "Writing market groups..."
        let marketGroups = marketGroupsReader.MarketGroups() |> Seq.cache
        marketGroupsWriter.WriteData marketGroups
        sharedMarketGroupsWriter.WriteEnums marketGroups

        console "Writing item type categories..."
        let itemTypeCategories = typesReader.CategoryNames() 
        sharedTypesWriter.WriteItemTypeCategoryEnums itemTypeCategories
        
        console "Writing attribute categories..."        
        let attrCategories = typesReader.AttributeCategories()
                                |> Seq.sortBy (fun a -> a.id)
        sharedAttributeWriter.WriteAttributeCategoryEnums attrCategories
        

        console "Writing attribute types..."
        let attrTypes = typesReader.AttributeTypes() 
                            |> Seq.sortBy (fun a -> a.id)
                            |> Array.ofSeq
        attributesWriter.WriteAttributeTypes attrTypes
        sharedAttributeWriter.WriteAttributeTypeEnums attrTypes

        
        console "Writing item types..."
        let itemTypes = typesReader.Types() |> Seq.cache
        let itemTypeAttrs = typesReader.ItemTypeAttributes()
        typesWriter.WriteItemTypes itemTypes itemTypeAttrs

        console "Writing item type groups..."
        let itemTypeGroups = typesReader.Groups() |> Seq.sortBy (fun a -> (a.categoryId, a.id) ) |> Array.ofSeq
        sharedTypesWriter.WriteItemTypeGroupEnums itemTypeGroups
        typesWriter.WriteItemTypeGroups itemTypeGroups itemTypes
        
        console "Writing meta types..."
        let metaTypesReader = new MetaTypesReader(source)
        let metaTypesWriter = new MetaTypesWriter(target)
        let sharedMetaTypesWriter = new MetaTypesWriter(sharedTarget)
        let groups = metaTypesReader.Groups() 
        groups |> metaTypesWriter.Write
        groups |> sharedMetaTypesWriter.WriteEnums
        
        console "Finished writing types."

    [<EntryPoint>]
    let main argv = 
        try            
            match argv with
            | [| "/sde"; sdeDir; "/names"; namesDir;  |] ->
                        console(sprintf "Static data source:   %s" sdeDir)
                        console(sprintf "Names directory:      %s" namesDir)

                        writeNames sdeDir namesDir
                        
            | [| "/sde"; sdeDir; "/universe"; universeDir |] ->
                        console(sprintf "Static data source:   %s" sdeDir)
                        console(sprintf "Universe directory:   %s" universeDir)

                        writeUniverse sdeDir universeDir
            
            | [| "/sde"; sdeDir; "/types"; typesDir; "/shared"; sharedDir |] ->
                        console(sprintf "Static data source:   %s" sdeDir)
                        console(sprintf "Types directory:      %s" typesDir)
                        console(sprintf "Shared directory:     %s" sharedDir)

                        writeTypes sdeDir typesDir sharedDir

            | [| "/sde"; sdeDir; "/names"; namesDir; "/universe"; universeDir; "/types"; typesDir; "/shared"; sharedDir |] ->
                        console(sprintf "Static data source:   %s" sdeDir)
                        console(sprintf "Names directory:      %s" namesDir)
                        console(sprintf "Universe directory:   %s" universeDir)
                        console(sprintf "Types directory:      %s" typesDir)
                        console(sprintf "Shared directory:     %s" sharedDir)

                        writeNames sdeDir namesDir
                        writeUniverse sdeDir universeDir
                        writeTypes sdeDir typesDir sharedDir

            | _ -> failwith "Invalid arguments. Valid options are:\r\n
/sde <sde root> /names <target names folder>\r\n
/sde <sde root> /universe <target universe folder>"
            0 
        with
        | ex -> consoleError(ex.Message + System.Environment.NewLine + ex.StackTrace)
                2
