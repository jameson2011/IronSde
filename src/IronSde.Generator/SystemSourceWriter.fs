namespace IronSde.Generator

open IronSde.Universe
open IronSde.Generator.IO

module internal SystemSourceWriter=
    
    let systemFactoryName id = sprintf "system%i" id
    
    let private systemFactory (value: SolarSystemData) = 
        let name = value.id |> systemFactoryName
        let planets = value.planets |> Seq.map PlanetSourceWriter.formatPlanet
                                    |> Source.toArrayOfStrings
        
        sprintf "let private %s() = { SolarSystemData.id = %i; 
                                            regionId = %i; constellationId = %i;
                                            security= %f; securityRating = %A; 
                                            x = %.20E; y = %.20E; z = %.20E;
                                            star = { StarData.id = %i; x = %.20E; y = %.20E; z = %.20E };
                                            planets = %s;
                                            }" 
                                                name value.id value.regionId value.constellationId 
                                                value.security value.securityRating
                                                value.x value.y value.z
                                                value.star.id
                                                value.star.x value.star.y value.star.z
                                                planets

    let private solarSystemCase (value: SolarSystemData) = 
        sprintf "| %i -> %s() |> Some" value.id (systemFactoryName value.id)

    let private constellationSystemsCase (constellationId, (systemIds: seq<int>)) =
        sprintf "| %i -> %s" constellationId (systemIds |> Seq.map (fun i -> i.ToString())|> Source.toArrayOfStrings)

    let private writeSystems dir (values: seq<SolarSystemData>) = 
        let path = combine dir "SolarSystems.fs"
        use writer = new System.IO.StreamWriter(path)

        let systemsByConstellation = values 
                                        |> Seq.groupBy (fun s -> s.constellationId)
                                        |> Seq.map (fun (cid, ss) -> cid, ss |> Seq.map (fun c-> c.id) |> Array.ofSeq)

        let headers = seq {
                            yield Source.declareUniverseNamespace
                            yield Source.importIronSdeNamespace
                            yield Source.declareSystemsModule
                        }
        let lines = seq {
                            yield! values |> Seq.map systemFactory
                            
                            yield "let solarSystem id = "
                            yield "match id with" |> Source.indent
                            yield! values |> Seq.map (solarSystemCase >> Source.indent)
                            yield "| _ -> None" |> Source.indent

                            yield "let constellationSystems id = "
                            yield "match id with" |> Source.indent
                            yield! systemsByConstellation |> Seq.map (constellationSystemsCase >> Source.indent)
                            yield "| _ -> [||]" |> Source.indent
                        } |> Seq.map Source.indent

        Seq.concat [headers; lines] 
            |> Seq.iter writer.WriteLine

        writer.Flush()    
        writer.Close()
        
    let write dir (values: seq<SolarSystem>) = 
        let systems = values |> Seq.map (fun s -> s.data)
        systems |> writeSystems dir

        
        
