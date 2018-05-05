namespace IronSde

module ItemTypes=
    open System.Linq
    
    let private ofItemTypeAttributeData (value: IronSde.Types.ItemTypeAttributeData) =
        { ItemTypeAttribute.key = LanguagePrimitives.EnumOfValue<int, AttributeTypes> value.attributeId;
                            value = value.value |> Option.defaultValue 0. }

    let private ofAttrTypeData (value: IronSde.Types.AttributeTypeData) =
        { ItemTypeAttribute.key = LanguagePrimitives.EnumOfValue<int, AttributeTypes> value.id;
                            value = value.defaultValue |> Option.defaultValue 0. }


    [<CompiledName("GetCategories")>]
    let categories() =
        System.Enum.GetValues(typeof<ItemTypeCategories>).OfType<ItemTypeCategories>()
        
    [<CompiledName("GetGroup")>]
    let group (key: ItemTypeGroups)=        
        let map (value: Types.ItemTypeGroupData)=
            IronSde.Names.ResourceUtils.group value.id
                |> Option.map (fun n -> { ItemTypeGroup.id = value.id; name = n; key = key;
                                                    category = LanguagePrimitives.EnumOfValue value.categoryId; })

        key |> LanguagePrimitives.EnumToValue 
            |> IronSde.ItemTypes.ItemTypeGroups.group 
            |> Option.bind map

    [<CompiledName("GetGroups")>]
    let groups (category: ItemTypeCategories)=
        category    |> LanguagePrimitives.EnumToValue 
                    |> IronSde.ItemTypes.ItemTypeGroups.groupsByCategory 
                    |> Seq.map (fun g -> LanguagePrimitives.EnumOfValue<int, ItemTypeGroups> g)                    
                    |> Seq.map group
                    |> Seq.mapToSomes

    [<CompiledName("GetItemType")>]
    let itemType id = 
        let name = IronSde.Names.ResourceUtils.itemtype id
        let meta = IronSde.ItemTypes.MetaGroups.itemtypesMeta id
                    |> Option.map (fun m -> let key = LanguagePrimitives.EnumOfValue m.id
                                            { ItemMetagroup.key = key; name = m.name } )
        let data = IronSde.ItemTypes.ItemTypes.itemtype id
        match name, data, meta with
        | Some n, Some d, m -> Some { ItemType.id = id; 
                                                name = n; 
                                                group = d.groupId |> LanguagePrimitives.EnumOfValue |> group |> Option.get;
                                                attributes = d.attributes |> Array.map ofItemTypeAttributeData;
                                                meta = m }
        | _ -> None         

    [<CompiledName("GetItemTypes")>]
    let itemTypes (group: ItemTypeGroup)=
        group.id    |> IronSde.ItemTypes.ItemTypeGroups.itemTypesByGroup 
                    |> Seq.map (itemType >> Option.get)                
    
    [<CompiledName("GetAttributeValue")>]
    let attribute (key: AttributeTypes) (itemType: ItemType) =
        itemType.attributes 
            |> Seq.filter (fun a -> a.key = key)
            |> Seq.tryHead
        
    [<CompiledName("GetDefaultAttributeValue")>]
    let defaultAttribute (key: AttributeTypes) =
        key |> LanguagePrimitives.EnumToValue
            |> IronSde.ItemTypes.AttributeTypes.attributeType
            |> Option.map ofAttrTypeData
        