namespace IronSde.UnitTests

open Xunit
open FsCheck
open IronSde

type MapSearchTest(output: Xunit.Abstractions.ITestOutputHelper)=
    
    [<Theory>]
    [<InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)>]
    [<InlineData(1.0, 0.0, 0.0, 3.0, 0.0, 0.0, 2.0)>]
    [<InlineData(0.0, 1.0, 0.0, 0.0, 3.0, 0.0, 2.0)>]
    [<InlineData(0.0, 0.0, 1.0, 0.0, 0.0, 3.0, 2.0)>]
    [<InlineData(1.0, 2.0, 0.0, 1.0, 2.0, 81.0, 81.0)>]
    member __.DifferenceBetweenPositions(x1, y1, z1, x2, y2, z2, expected) =
        let p1 = Position.OfDoubles x1 y1 z1
        let p2 = Position.OfDoubles x2 y2 z2
        
        let result = MapSearch.distance p1 p2
        
        Assert.Equal(Units.toMetres expected, result)

    [<RealFloatsProperty(Verbose = true)>]
    member __.DifferenceIsCummutative(x1, y1, z1, x2, y2, z2) =
        let p1 = Position.OfDoubles x1 y1 z1
        let p2 = Position.OfDoubles x2 y2 z2
        
        (MapSearch.distance p1 p2) = (MapSearch.distance p2 p1)
        
        


    [<SolarSystemsProperty(Verbose=true)>]
    member __.StarAlwaysFoundOnZeroCoordSearch(solarSystem: SolarSystem)=        
        let pos = Position.Empty

        let best = MapSearch.findClosestCelestial solarSystem.id pos

        match best with
        | Some (x,_) -> match x with     
                        | Star (_,_,_) -> true
                        | _ -> failwith "Star not returned"
        | _ -> failwith "Nothing returned"
    
    [<SolarSystemCelestialsPropertyAttribute(Verbose = true, MaxTest = 100)>]
    member __.CelestialsAlwaysFoundInSystem(solarSystem: SolarSystem, celestial: Celestial)=        
        let pos = Celestials.position celestial

        let result,_ = MapSearch.findClosestCelestial solarSystem.id pos |> Option.get
        
        Assert.Equal(celestial, result)
        
    [<Fact>]
    member __.TimeCelestialsSearch()=
        let samples = 10000
        let celestials = TestData.systems()
                            |> Seq.collect (fun s -> s |> TestData.celestials |> Seq.map (fun c -> s,c))
                            |> Seq.truncate samples
                            |> Array.ofSeq

        let rng = new System.Random()

        TestUtils.initSampling samples
            |> TestUtils.takeSamples    (fun () -> Array.item (rng.Next(celestials.Length)) celestials ) 
                                        (fun (s,c) -> MapSearch.findClosestCelestial s.id (Celestials.position c) |> ignore)
            |> TestUtils.finaliseSamples
            |> TestUtils.reportSamples (output)
        
    
    [<Fact>]
    member __.SpotcheckAdirainCelestialsFromCentre()=
        let id = 30005003
        
        let celestials = IronSde.SolarSystems.celestials id |> Array.ofSeq
        
        let distances = celestials  |> IronSde.MapSearch.getCelestialDistances Position.Empty |> Array.ofSeq

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
    member __.SpotcheckKillPosition69074016()=        
        let id = 30004210
        let sys = IronSde.SolarSystems.fromId id |> Option.get
        let pos = {x=259306297081.32825<m>; y=241501446953.00452<m>; z=23589032097.114777<m>}
        
        
        let best = MapSearch.findClosestCelestial id pos
        
        match best with        
        | Some (Stargate (id,_,_,_),_) when id = 50013146 -> true
        | Some(c,_) -> failwith (sprintf "%A returned" c)
        | _ -> failwith "Nothing returned"

    
    [<Fact>]
    member __.SpotcheckIshomilkenCelestialsFromCentre()=
        let id = 30002756
        
        let pos = Position.Empty

        let celestials = IronSde.SolarSystems.celestials id |> Array.ofSeq
        
        let distances = IronSde.MapSearch.getCelestialDistances pos celestials |> Array.ofSeq

        let result = distances
                        |> Seq.map (fun (c,d) -> IronSde.Celestials.name c, Units.metresToAU d)
                        |> Seq.sortBy (fun (_,d) -> d)
                        |> Seq.map (fun (n,_) -> n)
                        |> Array.ofSeq
        
        let expected = [|
                        "Ishomilken - Star";
                        "Ishomilken I";
                        "Ishomilken II";
                        "Ishomilken III";
                        "Ishomilken IV";
                        "Ishomilken V";
                        "Ishomilken VI";
                        "Ishomilken VII";
                        "Stargate (Uuna)";
                        "Ishomilken VIII";
                        "Ishomilken IX";
                        "Ishomilken X";
                        "Stargate (Nikkishina)";
                        "Stargate (Usi)";
                    |]

        result = expected

    // https://zkillboard.com/kill/67723862/
    [<Fact>]
    member __.SpotcheckIshomilkenKillPosition67723862()=        
        let id = 30002756
        let sys = IronSde.SolarSystems.fromId id |> Option.get
        let pos = {x= 295820325852.43896<m>; y= -242964233840.97263<m>; z= -578503307448.0066<m>}
        
        let celestials = IronSde.SolarSystems.celestials id |> Array.ofSeq
        
        let distances = IronSde.MapSearch.getCelestialDistances pos celestials 
                                |> Seq.map (fun (c,d) -> Celestials.id c, Celestials.name c, d, Units.metresToAU d)
                                |> Array.ofSeq        
        
        let best = MapSearch.findClosestCelestial id pos
        
        match best with        
        | Some (Moon (id,_,_,_),_) when id = 40175007 -> true
        | Some(c,_) -> failwith (sprintf "%A returned" c)
        | _ -> failwith "Nothing returned"
        
    // https://zkillboard.com/kill/67722966/
    [<Fact>]
    member __.SpotcheckOlettiersKillPosition67722966()=        
        let id = 30002686
        let sys = IronSde.SolarSystems.fromId id |> Option.get
        let pos = {x= 172543038076.22244<m>; y= -7025172307.224813<m>; z= 1635045561441.1003<m>}
        
        let celestials = IronSde.SolarSystems.celestials id |> Array.ofSeq
        
        let distances = IronSde.MapSearch.getCelestialDistances pos celestials 
                                |> Seq.map (fun (c,d) -> Celestials.id c, Celestials.name c, d, Units.metresToAU d)
                                |> Array.ofSeq        
        
        let best = MapSearch.findClosestCelestial id pos
        
        match best with        
        | Some (Belt (id,_,_,_),_) when id = 40170878 -> true
        | Some(c,_) -> failwith (sprintf "%A returned" c)
        | _ -> failwith "Nothing returned"
        