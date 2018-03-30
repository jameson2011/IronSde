namespace IronSde.Generator

open IronSde.Universe

module internal RegionSourceWriter=
    open IronSde.Generator.IO

    let regionFactoryName id = sprintf "region%i" id


    let private regionFactory  (value: RegionData) = 
        let name = value.id |> regionFactoryName         
        sprintf "let private %s()= { RegionData.id = %i; x = %.20E; y = %.20E; z = %.20E; }" 
            name value.id 
            value.x value.y value.z
            

    let private regionCase (value: RegionData) = 
        sprintf "| %i -> %s() |> Some" value.id (regionFactoryName value.id)

    let private writeRegions dir (values: seq<RegionData>) = 
        let path = combine dir "Regions.fs"

        let headers = seq {
                            yield Source.declareUniverseNamespace
                            yield "open IronSde"
                            yield Source.declareRegionsModule
                        }

        let lines = seq {
                            
                            yield! values |> Seq.map regionFactory
                            
                            yield "let region id = "
                            yield "match id with" |> Source.indent
                            yield! values |> Seq.map (regionCase >> Source.indent)
                            yield "| _ -> None" |> Source.indent

                            yield "let regions() = "
                            yield "seq {" |> Source.indent        
                            yield! values |> Seq.map (fun r -> r.id) |> Seq.map (sprintf "yield %i" >> Source.indent2)
                            yield "}" |> Source.indent
                        } |> Seq.map Source.indent
        
        
        use writer = new System.IO.StreamWriter(path)

        Seq.concat [headers; lines] 
            |> Seq.iter writer.WriteLine
            

        writer.Flush()    
        writer.Close()

    let write dir (regions: seq<RegionData>) = 
        regions |> writeRegions dir
        

