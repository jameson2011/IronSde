namespace IronSde.UnitTests

open IronSde

module TestData=
    
    let regions() = Regions.all() 
    
    let constellations() = 
        regions() 
            |> Seq.collect (fun r -> Regions.constellations r.id)
    
    let systems() = 
        constellations() 
            |> Seq.collect (fun c -> Constellations.solarSystems c.id)

    let celestials (solarSystem: SolarSystem) = 
        solarSystem.id
        |> SolarSystems.celestials
        |> Seq.append (SolarSystems.belts solarSystem.id)
        |> Seq.append (SolarSystems.stations solarSystem.id)
        |> Seq.append (SolarSystems.moons solarSystem.id)
        
    