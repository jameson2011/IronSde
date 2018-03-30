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
        
