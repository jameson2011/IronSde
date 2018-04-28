namespace IronSde.Generator

open System
open IronSde.Generator.ObjectMaps
open IronSde.Types

type internal MetaTypesReader(path)=
    
    let groups (typeMaps: Map<int, int []>) (file: string)= 
        let map value = 
            let id = value |> get "metaGroupID" |> toInt
            let typeIds id = typeMaps |> Map.tryFind id |> Option.defaultValue [||]
            { MetaGroupData.id = id;
                        name = value |> get "metaGroupName" |> toStr;
                        typeIds = typeIds id }

        file    |> ObjectMaps.toObjectList
                |> Seq.map (castObjectMap >> map)
                |> List.ofSeq

    let typeMaps () = 
        let map value = 
            ( value |> get "metaGroupID" |> toInt, value |> get "typeID" |> toInt )

        """sde\bsd\invMetaTypes.yaml""" 
                |> IO.combine path 
                |> ObjectMaps.toObjectList
                |> Seq.map (castObjectMap >> map)
                |> Seq.groupBy fst
                |> Seq.map (fun (k,ts) -> k, ts |> Seq.map snd |> Seq.sort |> Array.ofSeq)
                |> Map.ofSeq  

    member __.Groups()=
        let typeMaps = typeMaps()
        """sde\bsd\invMetaGroups.yaml""" 
            |> IO.combine path 
            |> groups typeMaps
            
