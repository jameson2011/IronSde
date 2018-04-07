namespace IronSde.Generator

open IronSde.Universe

module internal Source=
    
    let indent = sprintf "    %s"
    let indent2 = indent >> indent

    let toArrayOfStrings values = values |> (Strings.join ";" >> sprintf "[| %s |]")

    let ofInt32Option (value: int option) =
        match value with
        | Some x -> sprintf "Some %i" x
        | None -> "None"

    let formatPosition (value: Position) =
        sprintf " { Position.x = %.20E; y = %.20E; z = %.20E } " value.x value.y value.z
        
    let universeNamespace = "IronSde.Universe"
    let declareUniverseNamespace = sprintf "namespace %s" universeNamespace
    
    let regionsModuleName = "Regions"
    let declareRegionsModule = sprintf "module internal %s=" regionsModuleName
    
    let constellationsModuleName = "Constellations"
    let declareConstellationsModule = sprintf "module internal %s=" constellationsModuleName
    
    let systemsModuleName = "Systems"
    let declareSystemsModule = sprintf "module internal %s=" systemsModuleName

    let stargatesModuleName = "Stargates"
    let declareStargatesModule = sprintf "module internal %s=" stargatesModuleName

    let planetsModuleName = "Planets"
    let declarePlanetsModule = sprintf "module internal %s=" planetsModuleName

    let moonsChunkModuleName = "Moons"
    let declareMoonChunksModule = sprintf "module internal %s%i=" moonsChunkModuleName

    let moonsModuleName = "Moons"
    let declareMoonsModule = sprintf "module internal %s=" moonsModuleName

    let beltsModuleName = "Belts"
    let declareBeltsModule = sprintf "module internal %s=" beltsModuleName

    let stationsModuleName = "Stations"
    let declareStationsModule = sprintf "module internal %s=" stationsModuleName
