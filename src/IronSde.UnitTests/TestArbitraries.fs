namespace IronSde.UnitTests

open System
open FsCheck
open IronSde

type SolarSystems=
    static member Systems() = TestData.systems() |> Gen.elements |> Arb.fromGen
    
type SolarSystemsPropertyAttribute() =
    inherit FsCheck.Xunit.PropertyAttribute(
        Arbitrary = [| typeof<SolarSystems> |],
        QuietOnSuccess = false)

type SolarSystemCelestials=
    static member Values() = TestData.systems() 
                                |> Seq.collect (fun s -> s |> TestData.celestials |> Seq.map (fun c -> s,c))
                                |> Gen.elements |> Arb.fromGen

type SolarSystemCelestialsPropertyAttribute() =
    inherit FsCheck.Xunit.PropertyAttribute(
                                            Arbitrary = [| typeof<SolarSystemCelestials> |],
                                            QuietOnSuccess = false)

type RealFloats =
    static member Values() = Arb.Default.Float().Filter(fun d -> not (Double.IsNaN(d) || Double.IsInfinity(d) ))
                                

type RealFloatsPropertyAttribute() =
    inherit FsCheck.Xunit.PropertyAttribute(
        Arbitrary = [| typeof<RealFloats> |],
        QuietOnSuccess = false)
