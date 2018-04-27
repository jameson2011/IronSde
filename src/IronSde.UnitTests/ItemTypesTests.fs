namespace IronSde.UnitTests

open System
open Xunit

module ItemTypesTests=

    [<Fact>]
    let CategoriesReturnsAtLeastOne() =
        let cats = IronSde.ItemTypes.categories() |> Array.ofSeq

        Assert.NotEqual(0, cats.Length)

    [<Fact>]
    let GroupsByCategoryReturnsAtLeastOne()=
        let groups = IronSde.ItemTypes.categories() 
                            |> Seq.collect IronSde.ItemTypes.groups 
                            |> Array.ofSeq

        Assert.NotEqual(0, groups.Length)

    [<Fact>]
    let ItemTypesByGroupsReturnsAtLeastOne()=
        let itemTypes = IronSde.ItemTypes.categories() 
                                |> Seq.collect IronSde.ItemTypes.groups 
                                |> Seq.collect IronSde.ItemTypes.itemTypes 
                                |> Array.ofSeq
        
        Assert.NotEqual(0, itemTypes.Length)

    [<Theory>]
    [<InlineData(587)>]
    let ItemTypeByIdReturnsAttributes(id)=
        let itemType = IronSde.ItemTypes.itemtype id |> Option.get
        
        Assert.NotEqual(0, itemType.attributes.Length)


    [<Fact>]
    let ItemTypesBySpecificGroupReturnsAtLeastOne()=        
        let itemTypes = IronSde.ItemTypeCategories.Ship 
                            |> IronSde.ItemTypes.groups
                            |> Seq.collect IronSde.ItemTypes.itemTypes 
                            |> Array.ofSeq

        Assert.True(itemTypes.Length >= 488)


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
        
