namespace IronSde.UnitTests

open System
open Xunit
open IronSde

type MapsTests(output: Xunit.Abstractions.ITestOutputHelper)=

    let adirainId = 30005003
    let jitaId = 30000142

    [<Fact>]
    member __.RegionsReturnsExpectedCount() =
        let regions =TestData.regions() |> Array.ofSeq

        Assert.Equal(100, regions.Length)
        
    
    [<Theory>]
    [<InlineData(10000064, "Essence")>]
    [<InlineData(10000002, "The Forge")>]
    member __.RegionIsPopulated(regionId, expectedName)=
        let region = IronSde.Regions.fromId regionId

        Assert.Equal(expectedName, region.Value.name)

    [<Theory>]
    [<InlineData(30005003, "Adirain")>]    
    [<InlineData(30000142, "Jita")>]    
    member __.SystemIsPopulated(systemId, expectedName)=
        let solarSystem = IronSde.SolarSystems.fromId systemId        

        Assert.Equal(expectedName, solarSystem.Value.name)

        

    [<Theory>]
    [<InlineData(30005003, "Peccanouette")>]
    [<InlineData(30000142, "Kimotoro")>]
    member __.SystemConstellationIsReturned(solarSystemId, expectedName)=
        let constellation = IronSde.SolarSystems.constellation solarSystemId
        Assert.Equal(expectedName, constellation.name)

    [<Theory>]
    [<InlineData(30005003, "Essence")>]
    [<InlineData(30000142, "The Forge")>]    
    member __.SystemRegionIsReturned(solarSystemId, expectedName)=
        let region = IronSde.SolarSystems.region solarSystemId
        Assert.Equal(expectedName, region.name)

    [<Fact>]
    member __.AdirainNeighboursAreReturned()=
        let neighbours = IronSde.SolarSystems.neighbours adirainId 
                            |> Seq.map (fun s -> s.name)
                            |> Seq.sort
                            |> Array.ofSeq
        match neighbours with
        | [| "Aeschee"; "Arnon"; "Laurvier" |] -> ignore 0
        | _ -> neighbours |> sprintf "Invalid neighbours: %A" |> failwith

    [<Theory>]
    [<InlineData(30005003)>]
    [<InlineData(30000142)>]
    member __.SystemPlanetsAreReturned(solarSystemId)=
        let celestials = IronSde.SolarSystems.celestials solarSystemId

        let planetCount = celestials |> Seq.filter 
                                            (function | IronSde.Celestial.Planet (_,_,_) -> true | _ -> false)
                                    |> Seq.length
        Assert.NotEqual(0, planetCount)

    [<Fact>]
    member __.AdirainStationsAreReturned()=
        let neighbours = IronSde.SolarSystems.stations adirainId 
                            |> Seq.map IronSde.Celestials.name
                            |> Seq.sort
                            |> Array.ofSeq
        match neighbours with
        | [|"Adirain IV - Moon 2 - Modern Finances Depository";
                "Adirain V - Moon 4 - CBD Corporation Storage" |] -> ignore 0
        | _ -> neighbours |> sprintf "Invalid stations: %A" |> failwith

    [<Fact>]
    member __.JitaStationsAreReturned()=
        let neighbours = IronSde.SolarSystems.stations jitaId
                            |> Seq.map IronSde.Celestials.name
                            |> Seq.sort
                            |> Array.ofSeq
        match neighbours with
        | [|"Jita IV - Caldari Business Tribunal Information Center";
              "Jita IV - Moon 10 - Caldari Business Tribunal Law School";
              "Jita IV - Moon 10 - Caldari Constructions Production Plant";
              "Jita IV - Moon 11 - Expert Housing Production Plant";
              "Jita IV - Moon 4 - Caldari Business Tribunal Bureau Offices";
              "Jita IV - Moon 4 - Caldari Navy Assembly Plant";
              "Jita IV - Moon 5 - Caldari Navy Assembly Plant";
              "Jita IV - Moon 6 - Caldari Provisions School";
              "Jita IV - Moon 6 - Hyasyoda Corporation Refinery";
              "Jita IV - Moon 6 - Ytiri Storage"; 
              "Jita V - Moon 14 - Ytiri Storage";
              "Jita V - Moon 17 - Caldari Constructions Production Plant";
              "Jita VI - Hyasyoda Corporation Refinery";
              "Jita VII - Moon 2 - Caldari Business Tribunal Law School"|]
                         -> ignore 0
        | _ -> neighbours |> sprintf "Invalid stations: %A" |> failwith

    [<Fact>]
    member __.WalkSolarSystems() =        
        let count = TestData.systems() |> Seq.length

        Assert.NotEqual (0, count)

    [<Fact>]
    member __.WalkSolarSystemCelestials() =        
        let count = TestData.systems() 
                        |> Seq.map (fun s -> s.id)
                        |> Seq.collect IronSde.SolarSystems.celestials
                        |> Seq.length

        Assert.NotEqual (0, count)

    [<Fact>]
    member __.WalkSolarSystemPlanetCelestials() =        
        let count = TestData.systems() 
                        |> Seq.map (fun s -> s.id)
                        |> Seq.collect (fun sid -> IronSde.SolarSystems.celestials sid
                                                    |> Seq.collect (fun cid -> IronSde.Celestials.id cid  
                                                                                |> IronSde.SolarSystems.planetCelestials sid) )
                        |> Seq.length

        Assert.NotEqual (0, count)

    [<SolarSystemsProperty>]
    member __.SolarSystemStarAlwaysAStar(solarSystem: SolarSystem)=        
        
        let stars = IronSde.SolarSystems.celestials solarSystem.id
                            |> Seq.filter (function
                                            | Star (_,_,_) -> true
                                            | _ -> false)
                            |> Array.ofSeq
        match stars with
        | [| s |] -> true
        | _ -> false
    
    [<Fact>]
    member __.TakeSolarSystemFetchTimeSamples() =
        let ids = TestData.systems() |> Seq.map (fun s -> s.id) |> Array.ofSeq        
        let rng = new System.Random()
        let preTest() = ids.[rng.Next(ids.Length)]
        let test = IronSde.SolarSystems.fromId >> ignore                                

        TestUtils.initSampling 10000
            |> TestUtils.takeSamples preTest test
            |> TestUtils.finaliseSamples
            |> TestUtils.reportSamples output
        
    [<Fact>]
    member __.TakeSolarSystemCelestialsFetchTimeSamples() =
        let ids = TestData.systems() |> Seq.map (fun s -> s.id) |> Array.ofSeq        
        let rng = new System.Random()
        let preTest() = ids.[rng.Next(ids.Length)]
        let test = IronSde.SolarSystems.celestials >> Array.ofSeq >> ignore                                

        TestUtils.initSampling 10000
            |> TestUtils.takeSamples preTest test
            |> TestUtils.finaliseSamples
            |> TestUtils.reportSamples output
        
    