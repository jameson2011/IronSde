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

    let toIntOption (value: Object option)=
        value |> Option.map (fun v -> v :?> int)

    let toFloat (value: Object)=
        value :?> float

    let castToInt (x: Object) = 
        try
            Some (x :?> int)
        with
        | :? InvalidCastException -> None

    let castToFloat (x: Object) = 
        try
            Some (x :?> float)
        with
        | :? InvalidCastException -> None
    
    let castToLong (x: Object) = 
        try
            Some (x :?> int64)
        with
        | :? InvalidCastException -> None
    
    let coerceToFloat (x: Object) =
        match castToFloat x with
        | Some f -> Some f
        | _ -> match castToInt x with
                | Some i -> float i |> Some
                | _ -> match castToLong x with
                        | Some l -> float l |> Some
                        | _ -> None

    let toFloatOption (value: Object option)=
        value |> Option.map (fun v -> v :?> float)

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
    
    let getInt (key: string)  =
        get key >> toInt

    let getStr key =
        get key >> toStr

    let tryGetFloatOption (key: string)  =
        tryGet key >> toFloatOption
        
    let tryCoerceFloatOption (key: string)  =
        tryGet key >> Option.bind coerceToFloat 

    let tryGetIntOption (key: string)  =
        tryGet key >> toIntOption