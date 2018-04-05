namespace IronSde.UnitTests

open System
open Xunit

type ConstellationsTests(output: Xunit.Abstractions.ITestOutputHelper)=
        
    [<Theory>]
    [<InlineData(20000020, "Kimotoro")>]
    [<InlineData(20000732, "Peccanouette")>]
    member __.ConstellationIsPopulated(constellationId, expectedName)=
        let value = IronSde.Constellations.ofId constellationId
        
        Assert.Equal(expectedName, value.Value.name)
        Assert.Equal(constellationId, value.Value.id)

    [<Theory>]
    [<InlineData(20000020, "The Forge", 10000002)>]
    [<InlineData(20000732, "Essence", 10000064)>]
    member __.ConstellationReturnsRegion(id, expectedName, expectedId) =
        let value = IronSde.Constellations.region id
        
        Assert.Equal(expectedName, value.name)
        Assert.Equal(expectedId, value.id)
    
    [<Theory>]
    [<InlineData(20000020, 7)>]
    [<InlineData(20000732, 8)>]
    member __.ConstellationReturnsSolarSystems(id, expectedCount) =
        let systems = IronSde.Constellations.solarSystems id |> Array.ofSeq

        Assert.Equal(expectedCount, systems.Length)
    
    [<ConstellationsPropertyAttribute>]
    member __.ConstellationsAlwaysHaveARegion(value: IronSde.Constellation)=
        
        let region = IronSde.Constellations.region value.id

        true
