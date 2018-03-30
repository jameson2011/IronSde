namespace IronSde

open System

[<Measure>] type m
[<Measure>] type km
[<Measure>] type AU
[<Measure>] type LY

[<AutoOpen>]
module Units=
    let metresToKm (f: float<m>) = 
        ((float f) / 1000.0) * 1.0<km>

    let metresToAU (f: float<m>) = 
        ((float f) / 149597870700.0)  * 1.0<AU>

    let metresToLY (f: float<m>) = 
        ((float f) / 9460730472580800.0)  * 1.0<LY>
        
    let kmToMetres (f: float<km>) = 
        (float f) * 1000.0<m>

    let auToMetres (f: float<AU>) = 
        (float f) * 149597870700.0 * 1.0<m>

    let lyToMetres (f: float<LY>) = 
        (float f) * 9460730472580800.0 * 1.0<m>
        
    