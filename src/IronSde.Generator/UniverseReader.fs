namespace IronSde.Generator

open System
open System.IO
open IronSde.Universe
open IronSde.Generator.ObjectMaps

module UniverseReader=

    let private toSecurityRating security=
        match security with
        | x when x >= 0.45 -> SystemSecurity.Highsec
        | x when x >= 0.0 -> SystemSecurity.Lowsec
        | _ -> SystemSecurity.Nullsec

    let private toWormholeSecurityRating _ = SystemSecurity.Wormhole
    let private toAbyssalSecurityRating _ = SystemSecurity.Abyssal

    let private toPosition (value: Object) =
        let values = value :?> seq<Object>
        match values |> Array.ofSeq with
        | [| x; y; z; |] -> { Position.x = x :?> double; y = y :?> double; z = z :?> double}
        | _ -> failwith "Unrecognised Position"

    let private id (name: string) (values: ObjectMap)=           
        values |> get name |> toInt
    let private regionId values = id "regionID" values
    let private constellationId values = id "constellationID"  values
    let private solarSystemId values = id "solarSystemID" values

    let private toStargate solarSystemId (values: ObjectMap)=
        values |> Seq.map (fun k -> let key = (k.Key :?> int)
                                    let map = castObjectMap k.Value 
                                    let pos = map |> get "position" |> toPosition
                                    { StargateData.id = key; 
                                                solarSystemId = solarSystemId; 
                                                destinationGateId = map |> get "destination" |> toInt; 
                                                x = pos.x; y = pos.y; z = pos.z; 
                                                 })
                |> List.ofSeq

    let private toStar (values: ObjectMap)=        
        { StarData.id = values |> id "id"; x = 0.0; y = 0.0; z = 0.0; }

    let private toBelt solarSystemId planetId id (values: ObjectMap)=        
        let pos = (values |> get "position" |> toPosition)
        { BeltData.id = id; solarSystemId = solarSystemId; planetId = planetId; x = pos.x; y = pos.y; z = pos.z}

    let private toMoon solarSystemId id planetId (values: ObjectMap)=
        let pos = (values |> get "position" |> toPosition)
        { MoonData.id = id; solarSystemId = solarSystemId; planetId = planetId;
                    x = pos.x; y = pos.y; z = pos.z;
                    }

    let private toStation solarSystemId planetId moonId id (values: ObjectMap)=                
        let pos = (values |> get "position" |> toPosition)
        { StationData.id = id; 
                        solarSystemId = solarSystemId;
                        planetId = planetId; 
                        moonId = moonId;
                        x = pos.x; y = pos.y; z = pos.z;
                        }
    
    let private staticFiles path fileName = DirectoryInfo(path).EnumerateFiles(fileName, SearchOption.AllDirectories)
    let private root rootPath child = IO.combine rootPath child
    let private regionFiles path = staticFiles path "region.staticdata"
    let private constellationFiles path = staticFiles path "constellation.staticdata"
    let private systemFiles path = staticFiles path "solarsystem.staticdata"

    let private toBelts solarSystemId planetId (values: ObjectMap)=
        values  |> tryGet "asteroidBelts"
                |> Option.map castObjectMap
                |> Option.defaultValue (new ObjectMap())
                |> Seq.map (fun kvp -> toBelt solarSystemId planetId (kvp.Key :?> int) (castObjectMap kvp.Value))
                |> List.ofSeq        

    
    let private toStations solarSystemId planetId moonId (values: ObjectMap)=
        values  |> tryGet "npcStations"
                |> Option.map castObjectMap
                |> Option.defaultValue (new ObjectMap())
                |> Seq.map (fun kvp -> toStation solarSystemId planetId moonId (kvp.Key :?> int) (castObjectMap kvp.Value))
                |> List.ofSeq        


    let private toMoons solarSystemId planetId (values: ObjectMap)=
        values  |> tryGet "moons"
                |> Option.map castObjectMap
                |> Option.defaultValue (new ObjectMap())
                |> Seq.map (fun kvp ->  let moonValues = (castObjectMap kvp.Value)
                                        let moon = toMoon solarSystemId (kvp.Key :?> int) planetId moonValues
                                        let stations = moonValues |> toStations solarSystemId planetId (Some moon.id)
                                        moon, stations)
                |> List.ofSeq
        
    let private toPlanet solarSystemId  id (values: ObjectMap) =
        let pairs = toMoons solarSystemId id values
        let moons = pairs |> Seq.map fst
        let moonStations = pairs |> Seq.collect snd |> List.ofSeq
        let planetStations = toStations solarSystemId id None values
        
        let stations = List.append planetStations moonStations |> Array.ofSeq
        let belts = toBelts solarSystemId id values |> Array.ofSeq

        let pos = values |> get "position" |> toPosition
        let data = { PlanetData.id = id; solarSystemId = solarSystemId;
                        x = pos.x; y = pos.y; z = pos.z; }
        { Planet.data = data;
                        moons = moons; 
                        belts = belts; 
                        stations = stations }

    let private toPlanets solarSystemId (values: ObjectMap) =
        values  |> Seq.map (fun kvp ->  toPlanet solarSystemId (kvp.Key :?> int) (castObjectMap kvp.Value))
                |> List.ofSeq
    
    let private toSolarSystem (securityRating: float -> SystemSecurity) regionId constellationId (values: ObjectMap) =        
        let solarSystemId = solarSystemId values
        let security = values |> get "security" |> toFloat
        let stargates = values |> get "stargates"  |> castObjectMap |> (toStargate solarSystemId) |> Array.ofSeq
        let planets = values |> get "planets" |> castObjectMap |> toPlanets solarSystemId |> Seq.cache
        let planetData = planets |> Seq.map (fun p -> p.data) |> Array.ofSeq
        let pos = values |> get "center" |> toPosition
        let star = values |> tryGet "star" 
                            |> Option.map (castObjectMap >> toStar)
        (*
        let star = match star with     
                    | Some s -> s
                    // TODO: no stars in abyssal space?
                    | None -> { StarData.id = 0; x = 0.0; y = 0.0; z = 0.0; }
                *)
        let data = { SolarSystemData.id = solarSystemId; 
                        regionId = regionId; 
                        constellationId = constellationId;
                        security = security; 
                        securityRating = securityRating security;
                        x = pos.x; y = pos.y; z = pos.z; 
                        star = star; 
                        planets = planetData;
                        }

        { SolarSystem.data = data;
                        planets = planets;  
                        
                        stargates = stargates;}

    let private toConstellation regionId (values: ObjectMap) (solarSystems: seq<SolarSystem>)=
        let pos = values |> get "center" |> toPosition; 
        let data = { ConstellationData.id = constellationId values; regionId = regionId; 
                            x = pos.x; y = pos.y; z = pos.z;}
        { Constellation.data = data; solarSystems = solarSystems |> Seq.cache  }

    let private toRegion (values: ObjectMap) (constellations: seq<Constellation>)=
        let pos = values |> get "center" |> toPosition; 
        let data = { RegionData.id = regionId values;                 
                x = pos.x; y = pos.y; z = pos.z;
                }
        { Region.data = data; constellations = constellations |> Seq.cache }

    let private getSystems securityRating regionId constellationId path = 
        systemFiles(path)
            |> Seq.map (fun fi -> fi.FullName |> toObjectMap )
            |> Seq.map (fun (m) -> toSolarSystem securityRating regionId constellationId m)

    let private getConstellations securityRating regionId path = 
        constellationFiles(path)
            |> Seq.map (fun fi -> fi, toObjectMap fi.FullName)
            |> Seq.map (fun (fi,m) ->   let constellationId = constellationId m
                                        fi.Directory.FullName |> getSystems securityRating regionId constellationId 
                                        |> toConstellation regionId m)    

    let private getRegions securityRating path =
        regionFiles(path)
            |> Seq.map (fun fi -> fi, toObjectMap fi.FullName)
            |> Seq.map (fun (fi,m) ->   let regionId = regionId m
                                        (fi.Directory.ToString() |> getConstellations securityRating regionId) 
                                        |> toRegion m)    

    let internal regions(path) =         
        Seq.concat 
            [ 
                "sde\\fsd\\universe\\eve" |> root path |> getRegions toSecurityRating; 
                "sde\\fsd\\universe\\wormhole" |> root path |> getRegions toWormholeSecurityRating;
                "sde\\fsd\\universe\\abyssal" |> root path |> getRegions toAbyssalSecurityRating;
            ]