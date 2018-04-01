namespace IronSde.UnitTests

open System
open Xunit
open FsCheck
open FsCheck.Xunit
open IronSde

module MapSearchTest=

    [<Fact>]
    let ZeroDifferenceBetweenZeroPositions() =
        let p1 = Position.Empty
        let p2 = Position.Empty
        
        let r = MapSearch.distance p1 p2
        
        let expected = 0.0<m>

        Assert.Equal(expected, r)


    [<SolarSystemsProperty>]
    let StarAlwaysFoundOnZeroCoordSearch(solarSystem: SolarSystem)=        
        let pos = Position.Empty

        let best = MapSearch.findClosestCelestials solarSystem.id pos

        match best with
        | Some (x,_) -> match x with     
                        | Star (_,_,_) -> true
                        | _ -> failwith "Star not returned"
        | _ -> failwith "Nothing returned"
        
    [<Fact>]
    let SpotcheckAdirainCelestialsFromCentre()=
        let id = 30005003
        
        let pos = Position.Empty

        let celestials = IronSde.SolarSystems.celestials id |> Array.ofSeq
        
        let distances = IronSde.MapSearch.getDistances pos celestials |> Array.ofSeq

        let result = distances
                        |> Seq.map (fun (c,d) -> IronSde.Celestials.name c, Units.metresToAU d)
                        |> Seq.sortBy (fun (_,d) -> d)
                        |> Seq.map (fun (n,_) -> n)
                        |> Array.ofSeq
        let expected = [|
                        "Adirain - Star";
                        "Adirain I";
                        "Adirain II";
                        "Adirain III";
                        "Adirain IV";
                        "Adirain V";
                        "Adirain VI";
                        "Adirain VII";
                        "Adirain VIII";
                        "Adirain IX";
                        "Stargate (Arnon)";
                        "Stargate (Laurvier)";
                        "Adirain X";
                        "Stargate (Aeschee)"
                        |]

        result = expected

    // spot check for https://zkillboard.com/kill/69074016/
    [<Fact>]
    let SpotcheckKillPosition69074016()=        
        let id = 30004210
        let sys = IronSde.SolarSystems.fromId id |> Option.get
        let pos = {x=259306297081.32825<m>; y=241501446953.00452<m>; z=23589032097.114777<m>}
        
        
        let best = MapSearch.findClosestCelestials id pos
        
        match best with        
        | Some (Stargate (id,_,_,_),_) when id = 50013146 -> true
        | Some(c,_) -> failwith (sprintf "%A returned" c)
        | _ -> failwith "Nothing returned"
