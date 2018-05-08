namespace IronSde

module SolarSystems=
    
    /// Get a SolarSystem by its ID
    [<CompiledName("GetById")>]
    let ofId solarSystemId =
        solarSystemId    
                    |> Universe.Systems.solarSystem
                    |> Option.map Maps.ofSolarSystem
    
    /// Get a SolarSystem's Region
    [<CompiledName("GetRegion")>]
    let region solarSystemId =
        solarSystemId    
                    |> Universe.Systems.solarSystem
                    |> Option.bind (fun c -> c.regionId |> Regions.ofId)
                    |> Option.get

    /// Get a SolarSystem's Constellation
    [<CompiledName("GetConstellation")>]
    let constellation solarSystemId =
        solarSystemId    
                    |> Universe.Systems.solarSystem
                    |> Option.bind (fun c -> c.constellationId |> Constellations.ofId)
                    |> Option.get

    /// Get a SolarSystem's outward-bound Stargates 
    [<CompiledName("GetStargates")>]
    let stargates solarSystemId = 
        Universe.Stargates.systemStargates solarSystemId
            |> Seq.map (fun i -> match Universe.Stargates.stargate i with
                                    | Some sg -> match Universe.Stargates.stargate sg.destinationGateId with
                                                 | Some dsg -> Maps.ofStargate sg dsg |> Some
                                                 | _ -> None
                                    | _ -> None)
            |> Seq.mapToSomes

    /// Get a SolarSystem's neighbouring SolarSystems
    [<CompiledName("GetNeighbours")>]
    let neighbours solarSystemId = 
        solarSystemId 
            |> stargates 
            |> Seq.map (function
                        | Stargate (_,nid,_,_) -> ofId nid
                        | _ -> None) 
            |> Seq.mapToSomes

    /// Get a SolarSystem's first-tier Celestials (sun, planets, stargates)
    [<CompiledName("GetCelestials")>]
    let celestials id =
        match Universe.Systems.solarSystem id with
        | Some x ->     let stars = [ Maps.ofStar x.star ]
                        let planets = x.planets |> Seq.map Maps.ofPlanet
                        let stargates = stargates id                  
                        
                        Seq.append planets stargates
                            |> Seq.append stars
        | _ -> Seq.empty
        
    /// Get a SolarSystem's asteroid belts
    [<CompiledName("GetBelts")>]
    let belts solarSystemId = 
        solarSystemId   |> Universe.Belts.systemBelts 
                        |> Seq.map Maps.ofBelt

    /// Get a SolarSystem's stations. Citadels are not supported
    [<CompiledName("GetStations")>]
    let stations solarSystemId =        
        solarSystemId   |> Universe.Stations.systemStations 
                        |> Seq.map Maps.ofStation

    /// Get a SolarSystem's Moons
    [<CompiledName("GetMoons")>]
    let moons solarSystemId = 
        Universe.Moons.moons solarSystemId 
                        |> Seq.map Maps.ofMoon

    /// Get the celestials (stations, belts, moons) of a given SolarSystem's Planet
    [<CompiledName("GetPlanetCelestials")>]
    let planetCelestials solarSystemId planetId =
        let belts = belts solarSystemId |> Seq.filter (Maps.isOfPlanet planetId)
        let moons = moons solarSystemId |> Seq.filter (Maps.isOfPlanet planetId)
        let stations = stations solarSystemId |> Seq.filter (Maps.isOfPlanet planetId)
        Seq.append belts moons
            |> Seq.append stations