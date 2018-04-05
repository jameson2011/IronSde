﻿namespace IronSde

module Constellations=
    
    [<CompiledName("GetById")>]
    let ofId constellationId =
        constellationId    
                    |> IronSde.Universe.Constellations.constellation
                    |> Option.map Maps.ofConstellation
    
    [<CompiledName("GetRegion")>]
    let region constellationId =
        constellationId    
                    |> IronSde.Universe.Constellations.constellation
                    |> Option.bind (fun c -> c.regionId |> Regions.ofId)
                    |> Option.get

    [<CompiledName("GetSolarSystems")>]
    let solarSystems constellationId =
        constellationId
            |> IronSde.Universe.Systems.constellationSystems
            |> Seq.map (IronSde.Universe.Systems.solarSystem >> (Option.map Maps.ofSolarSystem) )
            |> Seq.mapToSomes

