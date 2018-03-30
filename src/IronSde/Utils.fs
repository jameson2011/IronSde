namespace IronSde

module internal Seq=
    let mapToSomes (values: seq<'a option>)=
        values  |> Seq.filter (fun v -> v.IsSome)
                |> Seq.map (fun v -> v.Value)        
    