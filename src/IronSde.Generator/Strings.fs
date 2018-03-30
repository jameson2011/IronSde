namespace IronSde.Generator

open System

module Strings=
    let join (delimiter: string) (values: seq<string>) = System.String.Join(delimiter, values)

