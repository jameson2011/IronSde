namespace IronSde.Names
open System.Reflection
open System.Resources
module ResourceUtils=
    let category =
        let asm = Assembly.GetExecutingAssembly()
        let resourceManagers = [| "IronSde.Names.CategoryNames" |] |> Array.map (fun n -> new ResourceManager(n, asm))
        let resMgr id =
            match id with
            | _ -> resourceManagers.[0]
        (fun id ->   try
                         let res = resMgr id
                         res.GetString(IronSde.ResourceUtils.categoryResourceName id) |> Some
                     with
                     | :? System.Resources.MissingManifestResourceException as ex -> None)
    let group =
        let asm = Assembly.GetExecutingAssembly()
        let resourceManagers = [| "IronSde.Names.GroupNames" |] |> Array.map (fun n -> new ResourceManager(n, asm))
        let resMgr id =
            match id with
            | _ -> resourceManagers.[0]
        (fun id ->   try
                         let res = resMgr id
                         res.GetString(IronSde.ResourceUtils.groupResourceName id) |> Some
                     with
                     | :? System.Resources.MissingManifestResourceException as ex -> None)
    let itemtype =
        let asm = Assembly.GetExecutingAssembly()
        let resourceManagers = [| "IronSde.Names.TypeNames" |] |> Array.map (fun n -> new ResourceManager(n, asm))
        let resMgr id =
            match id with
            | _ -> resourceManagers.[0]
        (fun id ->   try
                         let res = resMgr id
                         res.GetString(IronSde.ResourceUtils.itemtypeResourceName id) |> Some
                     with
                     | :? System.Resources.MissingManifestResourceException as ex -> None)
    let name =
        let asm = Assembly.GetExecutingAssembly()
        let resourceManagers = [| "IronSde.Names.Names0";"IronSde.Names.Names1";"IronSde.Names.Names2";"IronSde.Names.Names3";"IronSde.Names.Names4";"IronSde.Names.Names5";"IronSde.Names.Names6";"IronSde.Names.Names7" |] |> Array.map (fun n -> new ResourceManager(n, asm))
        let resMgr id =
            match id with
            | x when x <= 40043688 -> resourceManagers.[0]
            | x when x <= 40108751 -> resourceManagers.[1]
            | x when x <= 40173824 -> resourceManagers.[2]
            | x when x <= 40238952 -> resourceManagers.[3]
            | x when x <= 40304001 -> resourceManagers.[4]
            | x when x <= 40377720 -> resourceManagers.[5]
            | x when x <= 40442744 -> resourceManagers.[6]
            | _ -> resourceManagers.[7]
        (fun id ->   try
                         let res = resMgr id
                         res.GetString(IronSde.ResourceUtils.nameResourceName id) |> Some
                     with
                     | :? System.Resources.MissingManifestResourceException as ex -> None)
