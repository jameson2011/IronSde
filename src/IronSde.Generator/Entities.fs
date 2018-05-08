namespace IronSde.Generator

open IronSde.Universe

type Name = { id: int; name: string }

type internal Planet = { data: PlanetData;
                            moons: seq<MoonData>; 
                            stations: seq<StationData>; 
                            belts: seq<BeltData> }

type internal SolarSystem = { data: SolarSystemData;
                              planets: seq<Planet>; 
                              stargates: seq<StargateData>}

type internal Constellation = { data: ConstellationData; solarSystems: seq<SolarSystem>}
type internal Region = { data: RegionData; constellations: seq<Constellation> }

type AttributeCategory = { id: int; name: string; }
type AttributeType = { id: int; categoryId: int option; name: string; defaultValue: float option; }
type ItemTypeAttribute = { itemTypeId: int; attributeId: int; value: float option; }

type ItemGroup = { id: int; categoryId: int; name: string }

type ItemType = { id: int; groupId: int; 
                    capacity: float option;
                    radius: float option;
                    mass: float option;
                    volume: float option; }
