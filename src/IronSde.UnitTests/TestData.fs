namespace IronSde.UnitTests

module TestData=
    
    let regions() = IronSde.Regions.all() 
    
    let constellations() = 
        regions() 
            |> Seq.collect (fun r -> IronSde.Regions.constellations r.id)
    
    let systems() = 
        constellations() 
            |> Seq.collect (fun c -> IronSde.Constellations.solarSystems c.id)

        
    