namespace IronSde.Generator

module internal UniverseSourceWriter=    
    
    let constellations regions = regions |> Seq.collect (fun r -> r.constellations)
    let systems constellations = constellations |> Seq.collect (fun c -> c.solarSystems)   

    let write (console: string -> unit) dir (regions: seq<Region>) = 
        console "Writing regions..."
        regions |> Seq.map (fun r -> r.data) |> RegionSourceWriter.write dir

        console "Writing constellations..."
        let constellations = regions |> constellations |> Seq.cache
        ConstellationSourceWriter.write dir (constellations |> Seq.map (fun c -> c.data) )
        
        console "Writing solar systems..."
        let systems = constellations |> systems |> Seq.cache
        SystemSourceWriter.write dir systems
        
        let planets = systems |> Seq.collect (fun s -> s.planets) |> Seq.cache
                      
        console "Writing moons..."
        let moons = planets |> Seq.collect (fun p -> p.moons)
        MoonSourceWriter.write dir 20 moons
        
        console "Writing belts..."
        let belts = planets |> Seq.collect (fun p -> p.belts)
        BeltsSourceWriter.write dir belts
        
        console "Writing stargates..."
        let stargates = systems |> Seq.collect (fun s -> s.stargates)
        StargateSourceWriter.write dir stargates

        console "Writing stations..."
        let stations = planets |> Seq.collect (fun p -> p.stations)
        StationsSourceWriter.write dir stations
        
