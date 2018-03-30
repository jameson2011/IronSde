namespace IronSde.Generator

module internal UniverseSourceWriter=    
    
    let constellations regions = regions |> Seq.collect (fun r -> r.constellations)
    let systems constellations = constellations |> Seq.collect (fun c -> c.solarSystems)   

    let write dir (regions: seq<Region>) = 

        regions |> Seq.map (fun r -> r.data) |> RegionSourceWriter.write dir

        let constellations = regions |> constellations |> Seq.cache
        ConstellationSourceWriter.write dir (constellations |> Seq.map (fun c -> c.data) )
        
        let systems = constellations |> systems |> Seq.cache
        SystemSourceWriter.write dir systems
        
        let planets = systems |> Seq.collect (fun s -> s.planets) |> Seq.cache
                      
        let moons = planets |> Seq.collect (fun p -> p.moons)
        MoonSourceWriter.write dir 20 moons
        
        let belts = planets |> Seq.collect (fun p -> p.belts)
        BeltsSourceWriter.write dir belts
        
        let stargates = systems |> Seq.collect (fun s -> s.stargates)
        StargateSourceWriter.write dir stargates

        let stations = planets |> Seq.collect (fun p -> p.stations)
        StationsSourceWriter.write dir stations
        
