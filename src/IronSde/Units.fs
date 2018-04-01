namespace IronSde

open System

[<Measure>] type m
[<Measure>] type km
[<Measure>] type AU
[<Measure>] type LY

[<AutoOpen>]
module Units=
    let toMetres (x: float) = x * 1.0<m>

    let metresToKm (x: float<m>) = 
        ((float x) / 1000.0) * 1.0<km>

    let metresToAU (x: float<m>) = 
        ((float x) / 149597870700.0)  * 1.0<AU>

    let metresToLY (x: float<m>) = 
        ((float x) / 9460730472580800.0)  * 1.0<LY>
        
    let kmToMetres (x: float<km>) = 
        (float x) * 1000.0<m>

    let auToMetres (x: float<AU>) = 
        ((float x) * 149597870700.0) |> toMetres

    let lyToMetres (x: float<LY>) = 
        ((float x) * 9460730472580800.0) |> toMetres
        
    