namespace IronSde.Generator

open IronSde.Universe
open IronSde.Generator.IO

module internal BeltsSourceWriter=
    
    let beltFactoryName id = sprintf "belt%i" id

    let private formatBelt (value: BeltData) = 
        sprintf "{ BeltData.id = %i;  solarSystemId = %i; planetId = %i; x = %.20E; y = %.20E; z = %.20E; }"
                    value.id value.solarSystemId value.planetId value.x value.y value.z

    let private planetBeltsCase (planetId, belts) =
        sprintf "| %i -> %s" planetId (belts |> Seq.map formatBelt |> Source.toArrayOfStrings)

    let private writeBelts dir (values: seq<BeltData>) = 
        let path = combine dir "Belts.fs"
        use writer = new System.IO.StreamWriter(path)

        let beltsBySystem = values 
                                |> Seq.groupBy (fun b -> b.solarSystemId)
                                |> Seq.map (fun (cid, ss) -> cid, ss |> Array.ofSeq)

        let headers = seq {
                            yield Source.declareUniverseNamespace
                            yield "open IronSde"
                            yield Source.declareBeltsModule
                        }
        let lines = seq {                            
                            yield "let systemBelts systemId = "
                            yield "match systemId with" |> Source.indent
                            yield! beltsBySystem |> Seq.map (planetBeltsCase >> Source.indent)
                            yield "| _ -> [||]" |> Source.indent
                        } |> Seq.map Source.indent

        Seq.concat [headers; lines] 
            |> Seq.iter writer.WriteLine

        writer.Flush()    
        writer.Close()
        
    let write dir (values: seq<BeltData>) = 
        values |> writeBelts dir

        
        
