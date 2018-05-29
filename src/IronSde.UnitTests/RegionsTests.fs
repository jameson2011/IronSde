namespace IronSde.UnitTests

open System
open Xunit
open IronSde

type RegionsTests(output: Xunit.Abstractions.ITestOutputHelper)=

    let adirainId = 30005003
    let jitaId = 30000142
    let abyssRegions = [| 12000001; 12000002; 12000003;12000004; 12000005 |] |> Set.ofSeq

    [<Fact>]
    member __.RegionsReturnsExpectedCount() =
        let regions =TestData.regions() |> Array.ofSeq

        Assert.True(regions.Length >= 105)
        
        
    
    [<Theory>]
    [<InlineData(10000064, "Essence")>]
    [<InlineData(10000002, "The Forge")>]
    member __.RegionIsPopulated(regionId, expectedName)=
        let region = IronSde.Regions.ofId regionId

        Assert.Equal(expectedName, region.Value.name)

    [<Theory>]
    [<InlineData(10000064, 9)>]
    [<InlineData(10000002, 13)>]
    member __.RegionConstellationsAreReturned(regionId, expectedCount)=
        let values = IronSde.Regions.constellations regionId |> Array.ofSeq

        Assert.Equal(expectedCount, values.Length)

    [<Theory>]
    [<InlineData(10000064, 67)>]
    [<InlineData(10000002, 93)>]
    member __.RegionSolarSystemsAreReturned(regionId, expectedCount)=
        let values = IronSde.Regions.solarSystems regionId |> Array.ofSeq

        Assert.Equal(expectedCount, values.Length)

    [<Fact>]
    member __.AbyssalRegionSolarSystemsAreReturned()=

        let abyssRegions = IronSde.Regions.all() |> Seq.filter (fun r -> Set.contains r.id abyssRegions)
        let systems = abyssRegions |> Seq.map (fun r -> r.id) |> Seq.collect IronSde.Regions.solarSystems 
        
        let nonAbyss = systems |> Seq.filter (fun s -> s.level <> SecurityLevel.Abyssal) |> Array.ofSeq

        Assert.Equal(0, nonAbyss.Length)
        
    [<Fact>]
    member __.NonAbyssalRegionSolarSystemsDoNotContainAbyssSystems()=
        
        
        let isNotAbyss (r: Region) = Set.contains r.id abyssRegions |> not
        let nonAbyssRegions = IronSde.Regions.all() |> Seq.filter isNotAbyss
        let systems = nonAbyssRegions |> Seq.map (fun r -> r.id) |> Seq.collect IronSde.Regions.solarSystems 
        
        let nonAbyss = systems |> Seq.filter (fun s -> s.level = SecurityLevel.Abyssal) |> Array.ofSeq

        Assert.Equal(0, nonAbyss.Length)