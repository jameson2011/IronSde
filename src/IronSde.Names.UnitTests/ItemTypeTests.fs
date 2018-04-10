namespace IronSde.Names.UnitTests

open Xunit

module ItemTypeTests=

    [<Theory>]
    [<InlineData(2, "Corporation")>]    
    [<InlineData(587, "Rifter")>]
    [<InlineData(2889, "200mm AutoCannon II")>]
    [<InlineData(371027, "X-MS16 Snowball Launcher")>]
    let EnsureStringReturned(id: int, expectedName: string) = 
        
        let result = IronSde.Names.ResourceUtils.itemtype id 
                       
        Assert.True(result.IsSome)
        Assert.Equal(result.Value, expectedName);

