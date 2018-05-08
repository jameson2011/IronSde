namespace IronSde

open System

[<Measure>] type m
[<Measure>] type km
[<Measure>] type AU
[<Measure>] type LY

[<AutoOpen>]
module Units=
    /// Convert an arbitrary float to Metres
    [<CompiledName("ToMetres")>]
    let toMetres (x: float) = x * 1.0<m>

    /// Convert Metres to Kilometres
    [<CompiledName("MetresToKm")>]
    let metresToKm (x: float<m>) = 
        ((float x) / 1000.0) * 1.0<km>

    /// Convert Metres to AU
    [<CompiledName("MetresToAu")>]
    let metresToAU (x: float<m>) = 
        ((float x) / 149597870700.0)  * 1.0<AU>

    /// Convert Metres to Light years
    [<CompiledName("MetresToLy")>]
    let metresToLY (x: float<m>) = 
        ((float x) / 9460730472580800.0)  * 1.0<LY>
        
    /// Convert Kilometres to Metres
    [<CompiledName("KmToMetres")>]
    let kmToMetres (x: float<km>) = 
        (float x) * 1000.0<m>

    /// Convert AU to Metres
    [<CompiledName("AuToMetres")>]
    let auToMetres (x: float<AU>) = 
        ((float x) * 149597870700.0) |> toMetres

    /// Convert Light years to Metres
    [<CompiledName("LyToMetres")>]
    let lyToMetres (x: float<LY>) = 
        ((float x) * 9460730472580800.0) |> toMetres
        
    