namespace IronSde

module internal Seq=
    let mapToSomes (values: seq<'a option>)=
        values  |> Seq.filter Option.isSome
                |> Seq.map Option.get
                
    