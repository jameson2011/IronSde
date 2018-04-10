namespace IronSde.Names.UnitTests

open Xunit

module GroupTests=

    [<Theory>]
    [<InlineData(1, "Character")>]
    [<InlineData(2, "Corporation")>]
    [<InlineData(3, "Region")>]
    [<InlineData(4, "Constellation")>]
    [<InlineData(25, "Frigate")>]    
    let EnsureStringReturned(id: int, expectedName: string) = 
        
        let result = IronSde.Names.ResourceUtils.group id 
                       
        Assert.True(result.IsSome)
        Assert.Equal(result.Value, expectedName);

