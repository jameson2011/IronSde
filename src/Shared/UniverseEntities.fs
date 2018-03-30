namespace IronSde.Universe

type SystemSecurity = 
    |Highsec
    |Lowsec
    |Nullsec
    |Wormhole

// all positions are metres, in and out of solar systems.
type Position = 
    { x: float; y: float; z: float }
    with
    static member Empty = { x= 0.0; y= 0.0; z= 0.0 }


type StargateData = {
        id: int;
        x: float; y: float; z: float;
        solarSystemId: int;
        destinationGateId: int
    } 


type StarData =    { id: int; x: float; y: float; z: float; }
type MoonData =    { id: int; 
                                x: float; y: float; z: float;
                                solarSystemId: int; planetId: int;  }
type StationData = { id: int; x: float; y: float; z: float; solarSystemId: int; planetId: int; moonId: int option; }
type BeltData =    { id: int; x: float; y: float; z: float; solarSystemId: int; planetId: int; }
type PlanetData =  { id: int; x: float; y: float; z: float; solarSystemId: int; }

type SolarSystemData = { id: int; regionId: int; constellationId: int; 
                                security: float; securityRating: SystemSecurity; 
                                x: float; y: float; z: float;
                                star: StarData;
                                planets: PlanetData [];
                                }

type ConstellationData = { id: int; regionId: int; x: float; y: float; z: float;}
type RegionData = { id: int; x: float; y: float; z: float; }

