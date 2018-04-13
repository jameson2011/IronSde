namespace IronSde.Generator

open System
open System.Collections.Generic
open IronSde.Generator.ObjectMaps

type TypesReader(path)=
    let castEntry (value: KeyValuePair<Object, Object>)=
        value.Key |> toInt, value.Value |> castObjectMap

    let getName (values: ObjectMap)=
        match values |> tryGet "en" with
            | Some n ->    toStr n
            | _ ->          ""

    let name (id: int32,value: ObjectMap) =            
        let name = value |> get "name" |> castObjectMap |> getName
        { Name.id = id; name = name }

    let itemNames (file: string) =
        file    |> ObjectMaps.toObjectMap
                |> Seq.map castEntry
                |> Seq.map name            

    member __.CategoryNames()=
        IO.combine path """sde\\fsd\\categoryIDs.yaml"""
            |> itemNames        

    member __.GroupNames()=        
        IO.combine path """sde\\fsd\\groupIDs.yaml"""
            |> itemNames

    member __.TypeNames()=            
        IO.combine path """sde\\fsd\\typeIDs.yaml"""
            |> itemNames
    
