namespace IronSde

type Position = {
        x: float<m>; y: float<m>; z: float<m>;
    } with
    static member Empty =   
        { x = 0.<m>; y = 0.<m>; z = 0.<m> }
    static member OfDoubles x y z = 
        { x = Units.toMetres x; y = Units.toMetres y; z = Units.toMetres z }

type SecurityLevel =
    | Highsec
    | Lowsec
    | Nullsec
    | Wormhole

type Region = {
        id: int;
        name: string;
        position: Position;
    }

type Constellation = {
        id: int;
        regionId: int;
        name: string;
        position: Position;
    }
    
type SolarSystem = {
        id: int;
        constellationId: int;
        regionId: int;
        name: string;
        security: float;
        level: SecurityLevel;
        position: Position;
    }

type Celestial = 
    | Star of int * string * Position
    | Planet  of int * string * Position
    | Stargate  of int * int * string * Position
    | Belt  of int * int * string * Position
    | Moon of int * int * string * Position
    | Station  of int * int * string * Position
