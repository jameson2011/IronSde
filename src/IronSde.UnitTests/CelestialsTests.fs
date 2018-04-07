namespace IronSde.UnitTests

open System
open Xunit
open IronSde

module CelestialsTests=
    
    [<SolarSystemCelestialsPropertyAttribute>]
    let celestialsHavePositiveIds(system: SolarSystem) =
        system.id   |> SolarSystems.celestials
                    |> Seq.map Celestials.id 
                    |> Seq.filter (fun id -> id <= 0) 
                    |> Seq.isEmpty
                    

    [<SolarSystemCelestialsPropertyAttribute>]
    let celestialsHaveNonWhitespaceName(system: SolarSystem) =
        system.id   |> SolarSystems.celestials
                    |> Seq.map Celestials.name
                    |> Seq.filter String.IsNullOrWhiteSpace
                    |> Seq.isEmpty

    [<SolarSystemCelestialsPropertyAttribute>]
    let celestialsHavePosition(system: SolarSystem) =
        let test c = 
            match c with
            | Star (_,_,_) as s -> Celestials.position s = Position.empty
            | _ as c -> Celestials.position c <> Position.empty

        system.id   |> SolarSystems.celestials
                    |> Seq.filter (test >> not)
                    |> Seq.isEmpty
        

    [<SolarSystemsPropertyAttribute>]
    let celestialIdsAreUnique(system: SolarSystem)=
        let celestials = SolarSystems.celestials system.id 
                             |> Array.ofSeq
        
        let ids = celestials    |> Seq.map Celestials.id
                                |> Set.ofSeq

        ids.Count = celestials.Length

    [<SolarSystemsPropertyAttribute>]
    let celestialNamesAreUnique(system: SolarSystem)=
        let celestials = SolarSystems.celestials system.id 
                             |> Array.ofSeq
        
        let names = celestials  |> Seq.map Celestials.name
                                |> Set.ofSeq

        names.Count = celestials.Length
