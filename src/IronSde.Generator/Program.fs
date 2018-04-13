﻿namespace IronSde.Generator


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

    let private writeTypes source target =         
        console "Writing types..."

        let rdr = new MetaTypesReader(source)
        let writer = new MetaTypesWriter(target)
        rdr.Groups()
                        |> writer.Write
        
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
            
            | [| "/sde"; sdeDir; "/types"; typesDir |] ->
                        console(sprintf "Static data source:   %s" sdeDir)
                        console(sprintf "Types directory:   %s" typesDir)

                        writeTypes sdeDir typesDir

            | [| "/sde"; sdeDir; "/names"; namesDir; "/universe"; universeDir; "/types"; typesDir |] ->
                        console(sprintf "Static data source:   %s" sdeDir)
                        console(sprintf "Names directory:      %s" namesDir)
                        console(sprintf "Universe directory:   %s" universeDir)
                        console(sprintf "Types directory:   %s" typesDir)

                        writeNames sdeDir namesDir
                        writeUniverse sdeDir universeDir
                        writeTypes sdeDir typesDir

            | _ -> failwith "Invalid arguments. Valid options are:\r\n
/sde <sde root> /names <target names folder>\r\n
/sde <sde root> /universe <target universe folder>"
            0 
        with
        | ex -> consoleError(ex.Message + System.Environment.NewLine + ex.StackTrace)
                2
