namespace IronSde

type Position = {
        x: float<m>; y: float<m>; z: float<m>;
    } with
    [<CompiledName("Empty")>]
    static member empty =   
        { x = 0.<m>; y = 0.<m>; z = 0.<m> }
    [<CompiledName("FromCoordinates")>]
    static member ofCoordinates (coords: float * float * float) = 
        let x,y,z = coords
        { x = Units.toMetres x; y = Units.toMetres y; z = Units.toMetres z }

type SecurityLevel =
    | Highsec
    | Lowsec
    | Nullsec
    | Wormhole
    | Abyssal

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

type MarketGroup = { id: int; key: MarketGroups; parentId: int option; name: string }

type ItemTypeGroup = { id: int; key: ItemTypeGroups; category: ItemTypeCategories; name: string; }
type ItemMetagroup = { key: MetaGroups; name: string; }
type ItemTypeAttribute = { key: AttributeTypes; value: float }
type ItemType = {   id: int; 
                    name: string; 
                    group: ItemTypeGroup;
                    marketGroup: MarketGroup option;
                    meta: ItemMetagroup option;
                    capacity: float option;
                    mass: float option;
                    radius: float option;
                    volume: float option;
                    attributes: ItemTypeAttribute [];}
