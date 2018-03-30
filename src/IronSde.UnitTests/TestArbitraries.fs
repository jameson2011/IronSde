namespace IronSde.UnitTests

open System
open FsCheck

type SolarSystems=
    static member Systems() = TestData.systems() |> Gen.elements |> Arb.fromGen
    

type SolarSystemsPropertyAttribute() =
    inherit FsCheck.Xunit.PropertyAttribute(
        Arbitrary = [| typeof<SolarSystems> |],
        QuietOnSuccess = false)

type RealFloats =
    static member Values() = Arb.Default.Float().Filter(fun d -> not (Double.IsNaN(d) || Double.IsInfinity(d) ))
                                

type RealFloatsPropertyAttribute() =
    inherit FsCheck.Xunit.PropertyAttribute(
        Arbitrary = [| typeof<RealFloats> |],
        QuietOnSuccess = false)
