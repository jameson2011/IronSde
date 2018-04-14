namespace IronSde.Generator

open System
open System.Collections.Generic
open IronSde.Generator.ObjectMaps

module NamesReader=
    
    let names(path) =
        let file = IO.combine path """sde\\bsd\\invNames.yaml"""
        
        let map (value: ObjectMap) =
            { Name.id = (value |> get "itemID" |> toInt);
                name = (value |> get "itemName" |> toStr) }
                
        file 
            |> ObjectMaps.toObjectList
            |> Seq.map castObjectMap 
            |> Seq.map map            


    