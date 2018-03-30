namespace IronSde.Names
open System.Reflection
open System.Resources
module ResourceUtils=
    let name =
        let asm = Assembly.GetExecutingAssembly()
        let resourceManagers = [| "IronSde.Names.Names0";"IronSde.Names.Names1";"IronSde.Names.Names2";"IronSde.Names.Names3";"IronSde.Names.Names4";"IronSde.Names.Names5";"IronSde.Names.Names6";"IronSde.Names.Names7" |] |> Array.map (fun n -> new ResourceManager(n, asm))
        let resMgr id =
            match id with
            | x when x <= 40043882 -> resourceManagers.[0]
            | x when x <= 40108917 -> resourceManagers.[1]
            | x when x <= 40173963 -> resourceManagers.[2]
            | x when x <= 40239064 -> resourceManagers.[3]
            | x when x <= 40304085 -> resourceManagers.[4]
            | x when x <= 40377776 -> resourceManagers.[5]
            | x when x <= 40442772 -> resourceManagers.[6]
            | _ -> resourceManagers.[7]
        (fun id ->   try
                         let res = resMgr id
                         res.GetString(IronSde.ResourceUtils.nameResourceName id) |> Some
                     with
                     | :? System.Resources.MissingManifestResourceException as ex -> None)
