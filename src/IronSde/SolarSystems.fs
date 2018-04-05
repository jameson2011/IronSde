namespace IronSde

module SolarSystems=
    
    [<CompiledName("GetById")>]
    let ofId solarSystemId =
        solarSystemId    
                    |> Universe.Systems.solarSystem
                    |> Option.map Maps.ofSolarSystem
    
    [<CompiledName("GetRegion")>]
    let region solarSystemId =
        solarSystemId    
                    |> Universe.Systems.solarSystem
                    |> Option.bind (fun c -> c.regionId |> Regions.ofId)
                    |> Option.get

    [<CompiledName("GetConstellation")>]
    let constellation solarSystemId =
        solarSystemId    
                    |> Universe.Systems.solarSystem
                    |> Option.bind (fun c -> c.constellationId |> Constellations.ofId)
                    |> Option.get

    [<CompiledName("GetStargates")>]
    let stargates solarSystemId = 
        Universe.Stargates.systemStargates solarSystemId
            |> Seq.map (fun i -> match Universe.Stargates.stargate i with
                                    | Some sg -> match Universe.Stargates.stargate sg.destinationGateId with
                                                 | Some dsg -> Maps.ofStargate sg dsg |> Some
                                                 | _ -> None
                                    | _ -> None)
            |> Seq.mapToSomes

    [<CompiledName("GetNeighbours")>]
    let neighbours solarSystemId = 
        solarSystemId 
            |> stargates 
            |> Seq.map (function
                        | Stargate (_,nid,_,_) -> ofId nid
                        | _ -> None) 
            |> Seq.mapToSomes

    [<CompiledName("GetCelestials")>]
    let celestials id =
        match Universe.Systems.solarSystem id with
        | Some x ->     let stars = [ Maps.ofStar x.star ]
                        let planets = x.planets |> Seq.map Maps.ofPlanet
                        let stargates = stargates id                  
                        
                        Seq.append planets stargates
                            |> Seq.append stars
        | _ -> Seq.empty
        
            
    [<CompiledName("GetBelts")>]
    let belts solarSystemId = 
        solarSystemId   |> Universe.Belts.systemBelts 
                        |> Seq.map Maps.ofBelt

    [<CompiledName("GetStations")>]
    let stations solarSystemId =        
        solarSystemId   |> Universe.Stations.systemStations 
                        |> Seq.map Maps.ofStation

    [<CompiledName("GetMoons")>]
    let moons solarSystemId = 
        (Universe.Moons.moons solarSystemId)() 
                        |> Seq.map Maps.ofMoon

    [<CompiledName("GetPlanetCelestials")>]
    let planetCelestials solarSystemId planetId =
        let belts = belts solarSystemId |> Seq.filter (Maps.isOfPlanet planetId)
        let moons = moons solarSystemId |> Seq.filter (Maps.isOfPlanet planetId)
        let stations = stations solarSystemId |> Seq.filter (Maps.isOfPlanet planetId)
        Seq.append belts moons
            |> Seq.append stations