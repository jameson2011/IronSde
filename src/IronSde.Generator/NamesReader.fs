namespace IronSde.Generator

open IronSde.Generator.ObjectMaps

module NamesReader=
    
    let names(path) =
        let file = IO.combine path """sde\\bsd\\invNames.yaml"""
        let  map (value: ObjectMap) =
            (value.["itemID"] :?> int), (value.["itemName"].ToString())
            
        let serialiser = new SharpYaml.Serialization.Serializer()
        use rdr = new System.IO.StreamReader(file)
        serialiser.Deserialize(rdr) :?> System.Collections.Generic.List<System.Object>
            |> Seq.map castObjectMap 
            |> Seq.map map            
        

