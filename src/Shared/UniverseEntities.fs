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


type internal StargateData = {
        id: int;
        x: float; y: float; z: float;
        solarSystemId: int;
        destinationGateId: int
    } 


type internal StarData =    { id: int; x: float; y: float; z: float; }
type internal MoonData =    { id: int; 
                                x: float; y: float; z: float;
                                solarSystemId: int; planetId: int;  }
type internal StationData = { id: int; x: float; y: float; z: float; solarSystemId: int; planetId: int; moonId: int option; }
type internal BeltData =    { id: int; x: float; y: float; z: float; solarSystemId: int; planetId: int; }
type internal PlanetData =  { id: int; x: float; y: float; z: float; solarSystemId: int; }

type internal SolarSystemData = { id: int; regionId: int; constellationId: int; 
                                security: float; securityRating: SystemSecurity; 
                                x: float; y: float; z: float;
                                star: StarData;
                                planets: PlanetData [];
                                }

type internal ConstellationData = { id: int; regionId: int; x: float; y: float; z: float;}
type internal RegionData = { id: int; x: float; y: float; z: float; }

