namespace IronSde.Generator

open IronSde.Universe

module internal ConstellationSourceWriter=
    open IronSde.Generator.IO
    
    let constellationFactoryName id = sprintf "constellation%i" id
    
    let private constellationFactory (value: ConstellationData) = 
        let name = value.id |> constellationFactoryName
        sprintf "let private %s() = { ConstellationData.id = %i; regionId = %i;  x = %.20E; y = %.20E; z = %.20E; }" 
                    name value.id value.regionId 
                    value.x value.y value.z
                    

    let private constellationCase (value: ConstellationData) = 
        sprintf "| %i -> %s() |> Some" value.id (constellationFactoryName value.id)

    let private regionConstellationCase (regionId, (constellationIds: seq<int>)) =
        sprintf "| %i -> %s" regionId (constellationIds |> Seq.map (fun i -> i.ToString())|> Source.toArrayOfStrings)

    let private writeConstellations dir (values: seq<ConstellationData>) = 
        let path = combine dir "Constellations.fs"
        use writer = new System.IO.StreamWriter(path)

        let constellationsByRegion = values 
                                        |> Seq.groupBy (fun c -> c.regionId)
                                        |> Seq.map (fun (rid, cs) -> rid, cs |> Seq.map (fun c-> c.id) |> Array.ofSeq)

        let headers = seq {
                            yield Source.declareUniverseNamespace
                            yield "open IronSde"
                            yield Source.declareConstellationsModule
                        }
        let lines = seq {
                            yield! values |> Seq.map constellationFactory
                            
                            yield "let constellation id = "
                            yield "match id with" |> Source.indent
                            yield! values |> Seq.map (constellationCase >> Source.indent)
                            yield "| _ -> None" |> Source.indent

                            yield "let regionConstellations id = "
                            yield "match id with" |> Source.indent
                            yield! constellationsByRegion |> Seq.map (regionConstellationCase >> Source.indent)
                            yield "| _ -> [||]" |> Source.indent
                        } |> Seq.map Source.indent

        Seq.concat [headers; lines] 
            |> Seq.iter writer.WriteLine

        writer.Flush()    
        writer.Close()
        
    let write dir (values: seq<ConstellationData>) = 

        values |> writeConstellations dir

        
