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
                
        let serialiser = new SharpYaml.Serialization.Serializer()
        use rdr = new System.IO.StreamReader(file)
        serialiser.Deserialize(rdr) :?> List<Object>
            |> Seq.map castObjectMap 
            |> Seq.map map            


    