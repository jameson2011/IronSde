namespace IronSde.Generator

open System
open System.Collections.Generic

module Strings=
    let join (delimiter: string) (values: seq<string>) = System.String.Join(delimiter, values)
        
    let areUnique (values: seq<string>)=        
        let rec checkUnique (lookup: HashSet<string>) (strings: string list)=
            match strings with
            | [] ->     true
            | s::t ->   if not(lookup.Add s) then false
                        else checkUnique lookup t
        values |> List.ofSeq |> checkUnique (new HashSet<string>(StringComparer.InvariantCultureIgnoreCase))
      