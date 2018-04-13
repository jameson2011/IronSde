namespace IronSde.UnitTests

open System
open Xunit

module ItemTypesTests=

    [<Theory>]
    [<InlineData(2, "Corporation", false)>]    
    [<InlineData(587, "Rifter", false)>]
    [<InlineData(671, "Erebus", false)>]
    [<InlineData(371027, "X-MS16 Snowball Launcher", false)>]
    [<InlineData(2889, "200mm AutoCannon II", true)>]
    [<InlineData(19191, "Pithum A-Type Medium Shield Booster", true)>]    
    let ItemTypeReturned(id: int, name: string, hasMeta: bool)=
        let result = IronSde.ItemTypes.itemtype id
        match result with
        | Some r -> Assert.Equal(id, r.id)
                    Assert.Equal(name, r.name)
                    if hasMeta then 
                        Assert.NotNull(r.meta)
                    else
                        Assert.Null(r.meta)
        | _ -> failwith "Not found"
        