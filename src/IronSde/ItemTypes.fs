namespace IronSde

module ItemTypes=

    let itemtype id = 
        let name = IronSde.Names.ResourceUtils.itemtype id
        let meta = IronSde.ItemTypes.ItemTypes.itemtypesMeta id
                    |> Option.map (fun m -> { ItemMetagroup.id = m.id; name = m.name } )
        match name, meta with
        | Some n, m -> Some { ItemType.id = id; name = n; meta = m }
        | _ -> None 
        

