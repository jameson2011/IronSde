namespace IronSde.Generator

open System
open IronSde.Generator.ObjectMaps

type MarketGroupsReader(path)=

    let marketGroup (value: ObjectMap) =
        { MarketGroup.id =          value |> get "marketGroupID" |> toInt; 
                        parentId =  value |> tryGet "parentGroupID" |> toIntOption;
                        name =      value |> get "marketGroupName" |> toStr }

    let marketGroups filePath =
        filePath    |> ObjectMaps.toObjectList
                    |> Seq.map (castObjectMap >> marketGroup)

    member __.MarketGroups()=
        IO.combine path """sde\\bsd\\invMarketGroups.yaml"""
            |> marketGroups
