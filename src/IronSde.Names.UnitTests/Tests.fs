namespace IronSde.Names.UnitTests

open Xunit

module Tests=
    
    [<Fact>]
    let EnsureAssemblyLoads() = 
        let name = IronSde.Names.ResourceUtils.name

        let ids = [ 69000003; 40442776; 40377783; 40442775;
                    40304095; 40377782; 40239077; 40304094;
                    40173980; 40239076; 40108938; 40173979;
                    40043907; 40108937; 0; 40043906; 
                    ]
        let names = ids |> Seq.map name |> List.ofSeq
               
        // none of these must be none        
        Assert.False(names |> Seq.exists (fun o -> o.IsNone))

    [<Theory>]
    [<InlineData(69000003)>]
    [<InlineData(40442776)>]
    let EnsureStringReturned(id: int) = 
        let name = IronSde.Names.ResourceUtils.name
        
        let result = name id 
                       
        Assert.True(result.IsSome)
