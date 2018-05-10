namespace IronSde.UnitTests

open System.Linq
open Xunit
open FsCheck.Xunit
open IronSde

module ItemTypesTests=
    
    [<Fact>]
    let CategoriesReturnsAtLeastOne() =
        let cats = IronSde.ItemTypes.categories() |> Array.ofSeq

        Assert.NotEqual(0, cats.Length)


    [<Property(Verbose = true, MaxTest = 1000)>]
    let ItemTypeCategoriesYieldGroups(category: ItemTypeCategories) =
        let result = category 
                        |> IronSde.ItemTypes.groups 
                        |> Array.ofSeq

        result.Length > 0

    [<Fact>]
    let GroupsByCategoryReturnsAtLeastOne()=
        let groups = IronSde.ItemTypes.categories() 
                            |> Seq.collect IronSde.ItemTypes.groups 
                            |> Array.ofSeq

        Assert.NotEqual(0, groups.Length)

    [<Fact>]
    let GroupsEnumeratedAndFetched()=
        let keys = System.Enum.GetValues(typeof<IronSde.ItemTypeGroups>)
                                .OfType<IronSde.ItemTypeGroups>()
                                .ToArray()
        let groups = keys
                        |> Seq.map IronSde.ItemTypes.group 
                        |> Array.ofSeq

        Assert.NotEqual(0, groups.Length)


    [<Fact>]
    let ItemTypesByGroupsReturnsAtLeastOne()=
        let itemTypes = IronSde.ItemTypes.categories() 
                                |> Seq.collect IronSde.ItemTypes.groups 
                                |> Seq.collect IronSde.ItemTypes.itemTypes 
                                |> Array.ofSeq
        
        Assert.NotEqual(0, itemTypes.Length)

    [<Fact>]
    let ItemTypesHaveGroup()=
        let groups = IronSde.ItemTypes.categories() 
                                |> Seq.collect IronSde.ItemTypes.groups 
                                |> Seq.collect IronSde.ItemTypes.itemTypes 
                                |> Seq.map (fun it -> it.group)
                                |> Array.ofSeq
        
        Assert.NotEqual(0, groups.Length)

    [<Theory>]
    [<InlineData(587)>]
    let ItemTypeByIdReturnsAttributes(id)=
        let itemType = IronSde.ItemTypes.itemType id |> Option.get
        
        Assert.NotEqual(0, itemType.attributes.Length)

    [<Theory>]
    [<InlineData(587, IronSde.AttributeTypes.hiSlots, true, 3.0)>]
    [<InlineData(670, IronSde.AttributeTypes.hiSlots, false, 0)>]
    [<InlineData(672, IronSde.AttributeTypes.hiSlots, true, 0)>]
    [<InlineData(672, IronSde.AttributeTypes.lowSlots, true, 0)>]
    [<InlineData(672, IronSde.AttributeTypes.medSlots, true, 0)>]
    [<InlineData(672, IronSde.AttributeTypes.rigSlots, false, 0)>]
    let ItemTypeAttributeReturnsMinimalAmount(id, attr: IronSde.AttributeTypes, isSome, count: float)=
        let value = id  |> IronSde.ItemTypes.itemType 
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
    [<InlineData(2, "Corporation", false, false)>]    
    [<InlineData(587, "Rifter", false, true)>]
    [<InlineData(671, "Erebus", false, true)>]
    [<InlineData(33526, "High-grade Ascendancy Delta", false, true)>]
    [<InlineData(2889, "200mm AutoCannon II", true, true)>]
    [<InlineData(19191, "Pithum A-Type Medium Shield Booster", true, true)>]    
    [<InlineData(14666, "Hakim's Modified Heavy Warp Scrambler", true, true)>]
    let ItemTypeReturned(id: int, name: string, hasMeta: bool, hasMarket: bool)=
        let result = IronSde.ItemTypes.itemType id
        match result with
        | Some r -> Assert.Equal(id, r.id)
                    Assert.Equal(name, r.name)
                    if hasMeta then 
                        Assert.NotNull(r.meta)
                    else
                        Assert.Null(r.meta)
                    if hasMarket then
                        Assert.NotNull(r.marketGroup)
                    else    
                        Assert.Null(r.marketGroup)
        | _ -> failwith "Not found"
     
     
    [<Fact>]
    let MarketGroupRootsReturnsNonEmptyList()=
        let mgs = IronSde.ItemTypes.marketGroupRoots() |> Array.ofSeq

        Assert.NotEqual(0, mgs.Length)

    
    [<Theory>]
    [<InlineData(IronSde.MarketGroups.Ships)>]
    let MarketGroupReturnsNonEmptyValue(id)=
        let entity = IronSde.ItemTypes.marketGroup id
        
        Assert.NotNull(entity)

    [<Theory>]
    [<InlineData(1366)>]
    let MarketGroupByIdReturnsNonEmptyValue(id)=
        let entity = IronSde.ItemTypes.marketGroupById id |> Option.get
        
        Assert.NotNull(entity)

    [<Theory>]
    [<InlineData(0)>]
    [<InlineData(-10)>]
    let MarketGroupByIdReturnsNullValue(id)=
        let entity = IronSde.ItemTypes.marketGroupById id
        
        Assert.Null(entity)


    [<Theory>]
    [<InlineData(IronSde.MarketGroups.Ships)>]
    let MarketGroupChildrenReturnsNonEmptyList(id)=
        let root = IronSde.ItemTypes.marketGroup id
        let mgs = IronSde.ItemTypes.marketGroupChildren(root) |> Array.ofSeq

        Assert.NotEqual(0, mgs.Length)


    [<Theory>]
    [<InlineData(IronSde.MarketGroups.Ships_Frigates_AdvancedFrigates_AssaultFrigates_Gallente)>]
    let MarketGroupPathReturnsNonEmptyList(id) =
        let mg = IronSde.ItemTypes.marketGroup id
        let path = IronSde.ItemTypes.marketGroupPath mg

        Assert.NotEqual(0, path.Length)
