namespace IronSde.UnitTests

open System.Linq
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

    [<Theory>]
    [<InlineData(587, IronSde.AttributeTypes.hiSlots, true, 3.0)>]
    [<InlineData(670, IronSde.AttributeTypes.hiSlots, false, 0)>]
    [<InlineData(672, IronSde.AttributeTypes.hiSlots, true, 0)>]
    [<InlineData(672, IronSde.AttributeTypes.lowSlots, true, 0)>]
    [<InlineData(672, IronSde.AttributeTypes.medSlots, true, 0)>]
    [<InlineData(672, IronSde.AttributeTypes.rigSlots, false, 0)>]
    let ItemTypeAttributeReturnsMinimalAmount(id, attr: IronSde.AttributeTypes, isSome, count: float)=
        let value = id  |> IronSde.ItemTypes.itemtype 
                        |> Option.get
                        |> IronSde.ItemTypes.attribute attr
        
        Assert.Equal(isSome, value.IsSome)
        if isSome then
            Assert.True(value.Value.value >= count)

    [<Fact>]
    let AllAttributeKeysReturnValues()=
        let keys = System.Enum.GetValues(typeof<IronSde.AttributeTypes>)
                                .OfType<IronSde.AttributeTypes>()
                                .ToArray()
        let values = keys   |> Seq.map IronSde.ItemTypes.defaultAttribute
                            |> Array.ofSeq
        
        Assert.NotEqual(0, keys.Length)
        Assert.Equal(keys.Length, values.Length)


    [<Theory>]
    [<InlineData(IronSde.AttributeTypes.hiSlots, true, 0.0)>]
    let DefaultAttribute(key, isSome, count)=
        let value = IronSde.ItemTypes.defaultAttribute key

        Assert.Equal(isSome, value.IsSome)
        if isSome then
            Assert.True(value.Value.value >= count)

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
    [<InlineData(14666, "Hakim's Modified Heavy Warp Scrambler", true)>]
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
        
