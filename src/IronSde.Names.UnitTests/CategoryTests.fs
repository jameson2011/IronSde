namespace IronSde.Names.UnitTests

open Xunit

module CategoryTests=        

    [<Theory>]
    [<InlineData(6, "Ship")>]
    [<InlineData(2, "Celestial")>]
    [<InlineData(65, "Structure")>]
    [<InlineData(91, "Super Kerr-Induced Nanocoatings")>]
    let EnsureStringReturned(id: int, expectedName: string) = 
        
        let result = IronSde.Names.ResourceUtils.category id 
                       
        Assert.True(result.IsSome)
        Assert.Equal(result.Value, expectedName);

