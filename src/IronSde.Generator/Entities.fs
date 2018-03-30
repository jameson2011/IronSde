namespace IronSde.Generator

open IronSde.Universe

type internal Planet = { data: PlanetData;
                            moons: seq<MoonData>; 
                            stations: seq<StationData>; 
                            belts: seq<BeltData> }

type internal SolarSystem = { data: SolarSystemData;
                              planets: seq<Planet>; 
                              stargates: seq<StargateData>}

type internal Constellation = { data: ConstellationData; solarSystems: seq<SolarSystem>}
type internal Region = { data: RegionData; constellations: seq<Constellation> }
