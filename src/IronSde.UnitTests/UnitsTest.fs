namespace IronSde.UnitTests

open System
open FsCheck.Xunit
open IronSde

module UnitsTest=

    let epsilon = 1E-100

    let isEqual x y =
        if y = x then
            true
        else
            (y - x) < epsilon ||
            (x - y) < epsilon       

    [<RealFloatsProperty>]
    let metresToKmIsSymmetric(value: float)=        
        let result = value * 1.0<m> |> Units.metresToKm |> Units.kmToMetres
        let actual = float result
        
        isEqual value actual
    
    [<RealFloatsProperty>]
    let metresToAuIsSymmetric(value: float)=        
        let result = value * 1.0<m> |> Units.metresToAU |> Units.auToMetres
        let actual = float result
        
        isEqual value actual

    [<RealFloatsProperty>]
    let metresToLyIsSymmetric(value: float)=        
        let result = value * 1.0<m> |> Units.metresToLY |> Units.lyToMetres
        let actual = float result
        
        isEqual value actual
