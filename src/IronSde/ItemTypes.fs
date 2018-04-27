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
        
    [<CompiledName("GetGroups")>]
    let groups (category: ItemTypeCategories)=
        category    |> LanguagePrimitives.EnumToValue 
                    |> IronSde.ItemTypes.ItemTypeGroups.groupsByCategory 
                    |> Seq.map (fun g -> LanguagePrimitives.EnumOfValue<int, ItemTypeGroups> g)                    

    [<CompiledName("GetItemType")>]
    let itemtype id = 
        let name = IronSde.Names.ResourceUtils.itemtype id
        let meta = IronSde.ItemTypes.MetaGroups.itemtypesMeta id
                    |> Option.map (fun m -> { ItemMetagroup.id = m.id; name = m.name } )
        let data = IronSde.ItemTypes.ItemTypes.itemtype id
        match name, data, meta with
        | Some n, Some d, m -> Some { ItemType.id = id; 
                                                name = n; 
                                                group = LanguagePrimitives.EnumOfValue d.groupId;
                                                attributes = d.attributes |> Array.map ofItemTypeAttributeData;
                                                meta = m }
        | _ -> None         

    [<CompiledName("GetItemTypes")>]
    let itemTypes (group: ItemTypeGroups)=
        group   |> LanguagePrimitives.EnumToValue 
                |> IronSde.ItemTypes.ItemTypeGroups.itemTypesByGroup 
                |> Seq.map (itemtype >> Option.get)                
    
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
        