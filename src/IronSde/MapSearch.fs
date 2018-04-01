namespace IronSde


module MapSearch=
    
    let private sq (x: float) = x * x

    [<CompiledName("GetDistance")>]    
    let distance (p1: Position) (p2: Position) =
        [ p1.x - p2.x; p1.y - p2.y; p1.z - p2.z ]
            |> Seq.map (float >> abs >> sq)
            |> Seq.sum 
            |> sqrt
            |> Units.toMetres
    
    [<CompiledName("GetDistances")>]    
    let getDistances pos (celestials: seq<Celestial>)=
        celestials 
        |> Seq.map (fun c ->    let d = c |> Celestials.position |> distance pos
                                c,d)
        |> Seq.sortBy (fun (_,d) -> d)
        
        
    [<CompiledName("FindClosestCelestials")>]    
    let findClosestCelestials solarSystemId (position: Position) =        

        let celestials = solarSystemId 
                            |> SolarSystems.fromId 
                            |> Option.map (fun s -> SolarSystems.celestials s.id)
                            |> Option.defaultValue Seq.empty

        let best = celestials
                    |> getDistances position 
                    |> Seq.tryHead

        match best with
        | Some (c,_) -> match c with
                        | Planet (id,_,_) ->    SolarSystems.planetCelestials solarSystemId id
                                                |> Seq.append [c]
                                                |> getDistances position 
                                                |> Seq.tryHead
                        | _ -> best
        | _ -> None
        