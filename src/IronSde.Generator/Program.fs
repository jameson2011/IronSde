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
                        // TODO: clean up
                        //|> Seq.skip 16
                        //|> Seq.take 6
                        |> Seq.cache
                        
        
        console "Writing universe..."
        UniverseSourceWriter.write target regions

        console "Finished writing universe."

    [<EntryPoint>]
    let main argv = 
        try            
            match argv with
            | [| "/sde"; sde; "/names"; namesDir;  |] ->
                        console(sprintf "Static data source:   %s" sde)
                        console(sprintf "Names directory:      %s" namesDir)
                        
                        writeNames sde namesDir
                        
            | [| "/sde"; sde; "/universe"; universeDir |] ->
                        console(sprintf "Static data source:   %s" sde)
                        console(sprintf "Universe directory:   %s" universeDir)

                        writeUniverse sde universeDir
            
            | [| "/sde"; sde; "/names"; namesDir; "/universe"; universeDir |] ->
                        console(sprintf "Static data source:   %s" sde)
                        console(sprintf "Names directory:      %s" namesDir)
                        console(sprintf "Universe directory:   %s" universeDir)
                        
                        writeNames sde namesDir
                        writeUniverse sde universeDir
            | _ -> failwith "Invalid arguments. Valid options are:\r\n
/sde <sde root> /names <target names folder>\r\n
/sde <sde root> /universe <target universe folder>"
            0 
        with
        | ex -> consoleError(ex.Message)
                2
