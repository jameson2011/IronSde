namespace IronSde.UnitTests

open System
open FsCheck.Xunit
open IronSde

module UnitsTest=


    [<RealFloatsProperty>]
    let valuesToetresToIsSymmetric(value: float)=        
        let m = Units.toMetres value

        (float m) = value

    [<RealFloatsProperty>]
    let metresToKmIsSymmetric(value: float)=        
        let result = value |> Units.toMetres |> Units.metresToKm |> Units.kmToMetres
        let actual = float result
        
        TestUtils.areEqual value actual
    
    [<RealFloatsProperty>]
    let metresToAuIsSymmetric(value: float)=        
        let result = value |> Units.toMetres |> Units.metresToAU |> Units.auToMetres
        let actual = float result
        
        TestUtils.areEqual value actual

    [<RealFloatsProperty>]
    let metresToLyIsSymmetric(value: float)=        
        let result = value |> Units.toMetres |> Units.metresToLY |> Units.lyToMetres
        let actual = float result
        
        TestUtils.areEqual value actual
