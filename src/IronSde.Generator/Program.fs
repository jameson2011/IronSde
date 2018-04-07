namespace IronSde.Generator


module Program=
    
    let private prefix msg = sprintf "%s %s" (System.DateTime.UtcNow.ToLongTimeString()) msg
    let private console = prefix >> System.Console.Out.WriteLine
    let private consoleError = prefix >> System.Console.Error.WriteLine

    let private writeNames source target =
        
        console "Reading names..."
        let names = NamesReader.names source

        console "Writing names..."
        NamesSourceWriter.write target 8 names

        console "Finished writing names."

    let private writeUniverse source target = 
        console "Reading universe..."
        let regions = UniverseReader.regions source
                        |> Seq.cache
                        
        
        console "Writing universe..."
        UniverseSourceWriter.write console target regions

        console "Finished writing universe."

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
            
            | [| "/sde"; sdeDir; "/names"; namesDir; "/universe"; universeDir |] ->
                        console(sprintf "Static data source:   %s" sdeDir)
                        console(sprintf "Names directory:      %s" namesDir)
                        console(sprintf "Universe directory:   %s" universeDir)
                        
                        writeNames sdeDir namesDir
                        writeUniverse sdeDir universeDir
            | _ -> failwith "Invalid arguments. Valid options are:\r\n
/sde <sde root> /names <target names folder>\r\n
/sde <sde root> /universe <target universe folder>"
            0 
        with
        | ex -> consoleError(ex.Message + System.Environment.NewLine + ex.StackTrace)
                2
