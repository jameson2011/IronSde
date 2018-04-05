namespace IronSde

module Celestials=
    
    [<CompiledName("GetName")>]
    let name (value: Celestial)=
        match value with
        | Star (_,n,_) -> n
        | Planet (_,n,_) -> n
        | Stargate (_,_,n,_) -> n
        | Moon (_,_,n,_) -> n
        | Belt (_,_,n,_) -> n
        | Station (_,_,n,_) -> n
    
    [<CompiledName("GetId")>]
    let id celestial =
        match celestial with
        | Star (id,_,_) -> id
        | Planet (id,_,_) -> id
        | Stargate (id,_,_,_) -> id
        | Moon (id,_,_,_) -> id
        | Belt (id,_,_,_) -> id
        | Station (id,_,_,_) -> id

    [<CompiledName("GetPosition")>]
    let position celestial =
        match celestial with
        | Star (_,_,p) -> p
        | Planet (_,_,p) -> p
        | Stargate (_,_,_,p) -> p
        | Moon (_,_,_,p) -> p
        | Belt (_,_,_,p) -> p
        | Station (_,_,_,p) -> p



