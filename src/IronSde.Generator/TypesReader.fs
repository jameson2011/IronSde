﻿namespace IronSde.Generator

open System
open System.Collections.Generic
open IronSde.Generator.ObjectMaps
open IronSde.Types

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

    let itemTypeGroup  (id, values: ObjectMap) =
        { ItemGroup.id = id; 
                    categoryId = values |> getInt "categoryID";
                    name = values |> get "name" |> castObjectMap |> getName }


    let attributeType (values: ObjectMap) =                 
        {AttributeType.id = (values |> getInt "attributeID");
                            name = values |> getStr "attributeName";
                            categoryId = values |> tryGetIntOption "categoryID";
                            defaultValue = values |> tryGetFloatOption "defaultValue";}

    let attributeCategory(values: ObjectMap)=
        {AttributeCategory.id = values |> getInt "categoryID";
                            name = values |> getStr "categoryName" }

    let itemAttribute(values: ObjectMap) =
        let value = match values |> tryGetFloatOption "valueFloat"  with
                    | Some v -> Some v
                    | _ ->      values |> tryGetIntOption "valueInt" |> Option.map float
                    
        { ItemTypeAttribute.itemTypeId =    values |> getInt "typeID";
                            attributeId =   values |> getInt "attributeID";
                            value =         value}

    let itemType(id, values: ObjectMap) =
        { ItemType.id =         id;
                    groupId =   values |> getInt "groupID" }


    let itemNames (file: string) =
        file    |> ObjectMaps.toObjectMap
                |> Seq.map (castEntry >> name)

    let itemTypeGroups file = 
        file    |> ObjectMaps.toObjectMap
                |> Seq.map (castEntry >> itemTypeGroup)                

    let attributeCategories (file: string)=
        file    |> ObjectMaps.toObjectList
                |> Seq.map (castObjectMap >> attributeCategory)

    let attributeTypes (file: string)=
        file    |> ObjectMaps.toObjectList
                |> Seq.map (castObjectMap >> attributeType)
                 
    
    let itemAttributes (file: string)=
        file    |> ObjectMaps.toObjectList
                |> Seq.map (castObjectMap >> itemAttribute)
                 

    let itemTypes (file: string) =
        file    |> ObjectMaps.toObjectMap
                |> Seq.map (castEntry >> itemType)

    member __.CategoryNames()=
        IO.combine path """sde\\fsd\\categoryIDs.yaml"""
            |> itemNames        

    member __.GroupNames()=        
        IO.combine path """sde\\fsd\\groupIDs.yaml"""
            |> itemNames
    
    member __.Groups()=        
        IO.combine path """sde\\fsd\\groupIDs.yaml"""
            |> itemTypeGroups

    member __.TypeNames()=            
        IO.combine path """sde\\fsd\\typeIDs.yaml"""
            |> itemNames
    
    member __.AttributeCategories()=
        IO.combine path """sde\\bsd\\dgmAttributeCategories.yaml"""
            |> attributeCategories

    member __.AttributeTypes()=
        IO.combine path """sde\\bsd\\dgmAttributeTypes.yaml"""
            |> attributeTypes
    
    member __.ItemTypeAttributes()=
        IO.combine path """sde\\bsd\\dgmTypeAttributes.yaml"""
            |> itemAttributes

    member __.Types()=
        IO.combine path """sde\\fsd\\typeIDs.yaml"""
            |> itemTypes
            