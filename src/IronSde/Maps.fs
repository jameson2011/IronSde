namespace IronSde

module internal Maps=
    open IronSde.Universe

    let entityName = 
        let source = IronSde.Names.ResourceUtils.name
        (fun i -> source i |> Option.defaultValue (sprintf "Unknown%i" i) )

    let private ofSecurityRating (rating: SystemSecurity) =
        match rating with
        | Wormhole -> SecurityLevel.Wormhole
        | Lowsec -> SecurityLevel.Lowsec
        | Nullsec -> SecurityLevel.Nullsec
        | _ -> SecurityLevel.Highsec

    let ofPlanet (planet: PlanetData)= 
        Planet (planet.id, entityName planet.id, Position.ofCoordinates (planet.x, planet.y, planet.z) )
    
    let ofStar (planet: StarData)= 
        Star (planet.id, entityName planet.id, Position.ofCoordinates (planet.x, planet.y, planet.z))
    
    let ofBelt (belt: BeltData)= 
        Belt (belt.id, belt.planetId, entityName belt.id, Position.ofCoordinates (belt.x, belt.y, belt.z))
    
    let ofMoon (moon: MoonData)= 
        Moon (moon.id, moon.planetId, entityName moon.id, (Position.ofCoordinates (moon.x, moon.y, moon.z) ))
    
    let ofStation (station: StationData)= 
        Station (station.id, station.planetId, entityName station.id, (Position.ofCoordinates (station.x, station.y, station.z)))

    let isOfPlanet planetId (value: Celestial)=
        match value with
        | Moon (_,p,_,_) -> p = planetId
        | Belt (_,p,_,_) -> p = planetId
        | Station (_,p,_,_) -> p = planetId
        | _ -> false

    let ofRegion (value: RegionData)=
        { Region.id = value.id; name = entityName value.id; 
                    position = Position.ofCoordinates (value.x, value.y, value.z) }

    let ofConstellation (value: ConstellationData) =           
        { Constellation.id = value.id; name = entityName value.id; 
                        regionId = value.regionId;
                        position = Position.ofCoordinates (value.x, value.y, value.z) }

    let ofSolarSystem (value: SolarSystemData)=
         { SolarSystem.id = value.id; 
                        name = entityName value.id; 
                        regionId = value.regionId;
                        constellationId = value.constellationId;
                        security = value.security;
                        level = (ofSecurityRating value.securityRating);
                        position = Position.ofCoordinates (value.x, value.y, value.z);}

    let ofStargate (value: StargateData) (destination: StargateData)=
        ( Stargate (value.id, destination.solarSystemId, (entityName value.id), 
                        Position.ofCoordinates (value.x, value.y, value.z)))        
