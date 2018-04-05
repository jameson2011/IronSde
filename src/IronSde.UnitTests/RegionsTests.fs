namespace IronSde.UnitTests

open System
open Xunit
open IronSde

type RegionsTests(output: Xunit.Abstractions.ITestOutputHelper)=

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
