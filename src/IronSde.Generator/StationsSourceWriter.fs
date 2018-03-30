namespace IronSde.Generator

open IronSde.Universe
open IronSde.Generator.IO

module internal StationsSourceWriter=
    
    let stationFactoryName id = sprintf "station%i" id

    let formatStation (value: StationData) = 
        // TODO: moonId
        sprintf "{ StationData.id = %i; solarSystemId = %i; planetId = %i; moonId = None; x = %.20E; y = %.20E; z = %.20E; }"
                    value.id value.solarSystemId value.planetId value.x value.y value.z
    
    let private systemStationsCase (systemId, stations) =
        sprintf "| %i -> %s" systemId (stations |> Seq.map formatStation |> Source.toArrayOfStrings)


    let private writeStations dir (values: seq<StationData>) = 
        let path = combine dir "Stations.fs"
        use writer = new System.IO.StreamWriter(path)

        let stationsBySystem = values 
                                |> Seq.groupBy (fun b -> b.solarSystemId)
                                |> Seq.map (fun (cid, ss) -> cid, ss |> Array.ofSeq)

        let headers = seq {
                            yield Source.declareUniverseNamespace
                            yield "open IronSde"
                            yield Source.declareStationsModule
                        }
        let lines = seq {
                            yield "let systemStations systemId = "
                            yield "match systemId with" |> Source.indent
                            yield! stationsBySystem |> Seq.map (systemStationsCase >> Source.indent)
                            yield "| _ -> [||]" |> Source.indent
                        } |> Seq.map Source.indent

        Seq.concat [headers; lines] 
            |> Seq.iter writer.WriteLine

        writer.Flush()    
        writer.Close()
        
    let write dir (values: seq<StationData>) = 
        values |> writeStations dir

        
        
