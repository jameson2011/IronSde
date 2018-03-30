namespace IronSde.Generator

open IronSde.Universe
open IronSde.Generator.IO

module internal StargateSourceWriter=
        
    let stargateFactoryName id = sprintf "stargate%i" id
    
    let formatStargate (value: StargateData) =        
        sprintf "{ StargateData.id=%i; solarSystemId=%i; x = %.20E; y = %.20E; z = %.20E; destinationGateId=%i;}"
                    value.id value.solarSystemId 
                    value.x value.y value.z
                    value.destinationGateId
    

    let private stargateFactory (value: StargateData) =
        let name = value.id |> stargateFactoryName
        sprintf "let private %s()= %s" name  (formatStargate value)
    

    let private stargateCase (value: StargateData) = 
        sprintf "| %i -> %s() |> Some" value.id (stargateFactoryName value.id)

    let private systemStargatesCase (systemId, (gateIds: seq<int>)) =
        sprintf "| %i -> %s" systemId (gateIds |> Seq.map (fun i -> i.ToString())|> Source.toArrayOfStrings)

    let private writeStargates dir (values: seq<StargateData>) = 
        let path = combine dir "Stargates.fs"
        use writer = new System.IO.StreamWriter(path)

        let gatesBySystem = values 
                                        |> Seq.groupBy (fun s -> s.solarSystemId)
                                        |> Seq.map (fun (cid, ss) -> cid, ss |> Seq.map (fun c-> c.id) |> Array.ofSeq)

        let headers = seq {
                            yield Source.declareUniverseNamespace
                            yield "open IronSde"
                            yield Source.declareStargatesModule
                        }
        let lines = seq {
                            yield! values |> Seq.map stargateFactory
                            
                            yield "let stargate id = "
                            yield "match id with" |> Source.indent
                            yield! values |> Seq.map (stargateCase >> Source.indent)
                            yield "| _ -> None" |> Source.indent

                            yield "let systemStargates id = "
                            yield "match id with" |> Source.indent
                            yield! gatesBySystem |> Seq.map (systemStargatesCase >> Source.indent)
                            yield "| _ -> [||]" |> Source.indent
                        } |> Seq.map Source.indent

        Seq.concat [headers; lines] 
            |> Seq.iter writer.WriteLine

        writer.Flush()    
        writer.Close()
        
    let write dir (values: seq<StargateData>) = 
        values |> writeStargates dir

        
        
