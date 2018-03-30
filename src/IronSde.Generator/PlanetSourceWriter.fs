namespace IronSde.Generator

open IronSde.Universe
open IronSde.Generator.IO

module internal PlanetSourceWriter=
    
    let planetFactoryName id = sprintf "planet%i" id

    let formatPlanet (value: PlanetData) = 
        sprintf "{ PlanetData.id = %i; solarSystemId = %i; x = %.20E; y = %.20E; z = %.20E; }"
                    value.id
                    value.solarSystemId
                    value.x value.y value.z
                    
    
    let private planetFactory (value: PlanetData) = 
        let name = value.id |> planetFactoryName        
        sprintf "let private %s() = %s" name (formatPlanet value)

    let private planetCase (value: PlanetData) = 
        sprintf "| %i -> %s() |> Some" value.id (planetFactoryName value.id)

    let private systemPlanetsCase (systemId, (planetIds: seq<int>)) =
        sprintf "| %i -> %s" systemId (planetIds |> Seq.map (fun i -> i.ToString())|> Source.toArrayOfStrings)

    let private writePlanets dir (values: seq<PlanetData>) = 
        let path = combine dir "Planets.fs"
        use writer = new System.IO.StreamWriter(path)

        let planetsBySystem = values 
                                |> Seq.groupBy (fun s -> s.solarSystemId)
                                |> Seq.map (fun (cid, ss) -> cid, ss |> Seq.map (fun c-> c.id) |> Array.ofSeq)

        let headers = seq {
                            yield Source.declareUniverseNamespace
                            yield "open IronSde"
                            yield Source.declarePlanetsModule
                        }
        let lines = seq {
                            yield! values |> Seq.map planetFactory
                            
                            yield "let planet id = "
                            yield "match id with" |> Source.indent
                            yield! values |> Seq.map (planetCase >> Source.indent)
                            yield "| _ -> None" |> Source.indent

                            yield "let systemPlanets id = "
                            yield "match id with" |> Source.indent
                            yield! planetsBySystem |> Seq.map (systemPlanetsCase >> Source.indent)
                            yield "| _ -> [||]" |> Source.indent
                        } |> Seq.map Source.indent

        Seq.concat [headers; lines] 
            |> Seq.iter writer.WriteLine

        writer.Flush()    
        writer.Close()
        
    let write dir (values: seq<Planet>) = 
        let planets = values |> Seq.map (fun s -> s.data)
        planets |> writePlanets dir

        
        
