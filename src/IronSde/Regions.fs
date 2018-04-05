namespace IronSde

module Regions=
    
    [<CompiledName("GetById")>]
    let ofId regionId =
        regionId    |> IronSde.Universe.Regions.region 
                    |> Option.map Maps.ofRegion
    
    [<CompiledName("GetAll")>]
    let all() =
        IronSde.Universe.Regions.regions()
            |> Seq.map ofId
            |> Seq.mapToSomes

    [<CompiledName("GetConstellations")>]
    let constellations regionId =
        IronSde.Universe.Constellations.regionConstellations regionId
            |> Seq.map (IronSde.Universe.Constellations.constellation >> (Option.map Maps.ofConstellation) )
            |> Seq.mapToSomes
    
    [<CompiledName("GetSolarSystems")>]
    let solarSystems regionId =
        IronSde.Universe.Constellations.regionConstellations regionId
            |> Seq.collect IronSde.Universe.Systems.constellationSystems
            |> Seq.map (IronSde.Universe.Systems.solarSystem >> (Option.map Maps.ofSolarSystem) )
            |> Seq.mapToSomes

