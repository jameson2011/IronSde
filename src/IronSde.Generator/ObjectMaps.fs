namespace IronSde.Generator

open System
open System.Collections.Generic
        
type ObjectMap = Dictionary<Object, Object>

module ObjectMaps=

    let private ofFile (filePath: string) =
        let serialiser = new SharpYaml.Serialization.Serializer()
        use rdr = new System.IO.StreamReader(filePath)
        serialiser.Deserialize(rdr)
        
    let find (key: string) (value: ObjectMap) =        
        value |> Seq.map (fun kvp -> (kvp.Key.ToString()), kvp.Value)
                        |> Seq.filter (fun (k,_) -> k = key)
                        |> Seq.map (fun (_,v) -> v)
        

    let tryGet (key: string) (value: ObjectMap) =
        value |> find key |> Seq.tryHead
        
    let get (key: string) (value: ObjectMap) =
        value |> find key |> Seq.head        

    let toMap (value: Object) =
        value :?> ObjectMap

    let toInt (value: Object)=
        value :?> int

    let toFloat (value: Object)=
        value :?> float

    let toStr (value: Object)=
        if value = null then
            ""
        else
            value.ToString()

    let toObjectMap (filePath: string) =
        filePath |> ofFile :?> ObjectMap

    let toObjectList (filePath: string) =
        filePath |> ofFile :?> List<Object>
        
    let castObjectMap (o: Object)=
        o :?> ObjectMap
    