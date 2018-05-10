namespace IronSde

module ItemTypes=
    open System.Linq
    
    let private ofItemTypeAttributeData (value: IronSde.Types.ItemTypeAttributeData) =
        { ItemTypeAttribute.key = LanguagePrimitives.EnumOfValue<int, AttributeTypes> value.attributeId;
                            value = value.value |> Option.defaultValue 0. }

    let private ofAttrTypeData (value: IronSde.Types.AttributeTypeData) =
        { ItemTypeAttribute.key = LanguagePrimitives.EnumOfValue<int, AttributeTypes> value.id;
                            value = value.defaultValue |> Option.defaultValue 0. }

    let private ofItemTypeGroupData (key: ItemTypeGroups) (value: Types.ItemTypeGroupData)=
        IronSde.Names.ResourceUtils.group value.id
            |> Option.get
            |> (fun n -> { ItemTypeGroup.id = value.id; name = n; key = key;
                                                category = LanguagePrimitives.EnumOfValue value.categoryId; })

    let private itemTypeMeta id = 
        id  |> IronSde.ItemTypes.MetaGroups.itemtypesMeta
            |> Option.map (fun m -> let key = LanguagePrimitives.EnumOfValue m.id
                                    { ItemMetagroup.key = key; name = m.name } )

    
    let private marketGroupEntity id = 
        id  |> IronSde.ItemTypes.MarketGroups.marketgroup
            |> Option.map (fun d -> { MarketGroup.id = id; 
                                                    key = LanguagePrimitives.EnumOfValue id;
                                                    name = d.name; 
                                                    parentId = d.parentId } )
    

    let private marketGroupByParent id =
        id  |> IronSde.ItemTypes.MarketGroups.marketGroupChildren
            |> Seq.map marketGroupEntity
            

    /// Get a MarketGroup
    [<CompiledName("GetMarketGroup")>]
    let marketGroup(key: MarketGroups) = 
        key |> LanguagePrimitives.EnumToValue
            |> marketGroupEntity
            |> Option.get
    
    /// Get a MarketGroup by its ID
    [<CompiledName("GetMarketGroupById")>]
    let marketGroupById(id: int) = 
        id  |> marketGroupEntity
    

    /// Get all root MarketGroups
    [<CompiledName("GetMarketGroupRoots")>]
    let marketGroupRoots() = 
        marketGroupByParent None
            |> Seq.mapToSomes
            |> Seq.sortBy (fun mg -> mg.name)

    /// Get all child MarketGroups
    [<CompiledName("GetMarketGroupChildren")>]
    let marketGroupChildren(parent: MarketGroup) =
        marketGroupByParent (Some parent.id)
            |> Seq.mapToSomes
            |> Seq.sortBy (fun mg -> mg.name)

    /// Get a MarketGroup's path to its root
    [<CompiledName("GetMarketGroupPath")>]
    let marketGroupPath (value: MarketGroup) = 
        let rec path id result =
            match id with
            | None -> result
            | Some x -> let mg = marketGroupEntity x |> Option.get
                        path mg.parentId (mg::result)
        path (Some value.id) []

    /// Get all ItemType Categories
    [<CompiledName("GetCategories")>]
    let categories() =
        System.Enum.GetValues(typeof<ItemTypeCategories>).OfType<ItemTypeCategories>()
        
    /// Get an ItemTypeGroup given its key
    [<CompiledName("GetGroup")>]
    let group (key: ItemTypeGroups)=        
        key |> LanguagePrimitives.EnumToValue 
            |> IronSde.ItemTypes.ItemTypeGroups.group 
            |> Option.get
            |> ofItemTypeGroupData key
            
    /// Get all ItemTypeGroups for a given ItemType category
    [<CompiledName("GetGroups")>]
    let groups (category: ItemTypeCategories)=
        category    |> LanguagePrimitives.EnumToValue 
                    |> IronSde.ItemTypes.ItemTypeGroups.groupsByCategory 
                    |> Seq.map (fun g -> LanguagePrimitives.EnumOfValue<int, ItemTypeGroups> g)                    
                    |> Seq.map group
                    
    /// Get an ItemType by its ID
    [<CompiledName("GetItemType")>]
    let itemType id = 
        let name = IronSde.Names.ResourceUtils.itemtype id
        let meta = itemTypeMeta id
        let data = IronSde.ItemTypes.ItemTypes.itemType id
        let marketGroup = data |> Option.bind (fun d -> d.marketGroupId) |> Option.bind marketGroupEntity 

        match name, data, meta with
        | Some n, Some d, m -> Some { ItemType.id = id; 
                                                name = n; 
                                                group = d.groupId |> LanguagePrimitives.EnumOfValue |> group;
                                                marketGroup = marketGroup;
                                                attributes = d.attributes |> Array.map ofItemTypeAttributeData;
                                                meta = m;
                                                capacity = d.capacity; 
                                                volume = d.volume;
                                                radius = d.radius;
                                                mass = d.mass}
        | _ -> None         

    /// Get all ItemTypes for a given ItemTypeGroup
    [<CompiledName("GetItemTypes")>]
    let itemTypes (group: ItemTypeGroup)=
        group.id    |> IronSde.ItemTypes.ItemTypeGroups.itemTypesByGroup 
                    |> Seq.map (itemType >> Option.get)                
    
    /// Get an ItemTypeAttribute for a given ItemType and AttributeType
    [<CompiledName("GetAttributeValue")>]
    let attribute (key: AttributeTypes) (itemType: ItemType) =
        itemType.attributes 
            |> Seq.filter (fun a -> a.key = key)
            |> Seq.tryHead
        
    /// Get the default value for a given AttributeType
    [<CompiledName("GetDefaultAttributeValue")>]
    let defaultAttribute (key: AttributeTypes) =
        key |> LanguagePrimitives.EnumToValue
            |> IronSde.ItemTypes.AttributeTypes.attributeType
            |> Option.map ofAttrTypeData
        