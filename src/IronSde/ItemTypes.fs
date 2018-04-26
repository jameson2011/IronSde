namespace IronSde

module ItemTypes=
    open System.Linq
    
    let private toAttr (value: IronSde.Types.ItemTypeAttributeData) =
        { ItemTypeAttribute.key = LanguagePrimitives.EnumOfValue<int, AttributeTypes> value.attributeId;
                            value = value.value |> Option.defaultValue 0. }

    [<CompiledName("GetCategories")>]
    let categories() =
        System.Enum.GetValues(typeof<ItemTypeCategories>).OfType<ItemTypeCategories>()
            
    [<CompiledName("GetGroups")>]
    let groups (category: ItemTypeCategories)=
        category    |> LanguagePrimitives.EnumToValue 
                    |> IronSde.ItemTypes.ItemTypeGroups.groupsByCategory 
                    |> Option.map (fun gs -> gs |> Seq.map (fun g -> LanguagePrimitives.EnumOfValue<int, ItemTypeGroups> g))
                    |> Option.defaultValue Seq.empty        

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
                                                attributes = d.attributes |> Array.map toAttr;
                                                meta = m }
        | _ -> None         

    [<CompiledName("GetItemTypes")>]
    let itemTypes (group: ItemTypeGroups)=
        group   |> LanguagePrimitives.EnumToValue 
                |> IronSde.ItemTypes.ItemTypeGroups.itemTypesByGroup 
                |> Option.map (fun ids -> ids 
                                            |> Seq.map (itemtype >> Option.get))
                |> Option.defaultValue Seq.empty
    