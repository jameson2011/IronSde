namespace IronSde.Generator

open System
open IronSde.Universe

module internal Source=
    
    let indent = sprintf "    %s"
    let indent2 = indent >> indent
    let indentMany values = values |> Seq.map indent

    let toArrayOfStrings values = values |> (Strings.join ";" >> sprintf "[| %s |]")
    let toArrayOfInts values = values |> Seq.map (sprintf "%i") |> toArrayOfStrings


    let ofInt32Option (value: int option) =
        match value with
        | Some x -> sprintf "Some %i" x
        | None -> "None"

    let ofFloatOption (value: float option) =
        match value with
        | Some x -> sprintf "Some %f" x
        | None -> "None"

    let defaultNoneCase = "| _ -> None"

    let defaultEmptyArrayCase = "| _ -> [||]"

    let formatPosition (value: Position) =
        sprintf " { Position.x = %.20E; y = %.20E; z = %.20E } " value.x value.y value.z
    
    let cleanEnumName (value: string) =
        let isOk (c: char) = (System.Char.IsLetter c) || (System.Char.IsDigit c)
        value   |> Seq.filter isOk
                |> Array.ofSeq
                |> String

    let isValidStart (value: string) = (value.Chars 0 |> System.Char.IsLetter)
    let isNpcStart (value: string) = value.Chars 0 = '♦'

    let toEnumName (value: string) =        
        if not (isValidStart value) then
            failwith "Invalid name"       
        cleanEnumName value

    let ironSdeNamespace = "IronSde"
    let declareIronSdeNamespace = sprintf "namespace %s" ironSdeNamespace
    let importIronSdeNamespace = sprintf "open %s" ironSdeNamespace    

    let ironSdeTypesNamespace = "IronSde.Types"
    let importIronSdeTypesNamespace = sprintf "open %s" ironSdeTypesNamespace    
    
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

    let itemtypesNamespace = "IronSde.ItemTypes"
    let declareItemtypesNamespace = sprintf "namespace %s" itemtypesNamespace
    
    let itemTypeCategoriesEnumName = "ItemTypeCategories"
    let declareItemTypeCategoryEnumsTypeName = sprintf "type %s=" itemTypeCategoriesEnumName
    
    let itemtypesModuleName = "ItemTypes"
    let declareItemTypesModule = sprintf "module internal %s=" itemtypesModuleName

    let metaGroupsModuleName = "MetaGroups"
    let declareMetaGroupsModule = sprintf "module internal %s=" metaGroupsModuleName

    let metaGroupsEnumName = "MetaGroups"
    let declareMetaGroupsEnum = sprintf "type %s=" metaGroupsEnumName


    let itemTypeGroupsModuleName = "ItemTypeGroups"
    let declareItemTypeGroupsModule = sprintf "module internal %s=" itemTypeGroupsModuleName
    let declareItemTypeGroupsEnum = sprintf "type %s=" itemTypeGroupsModuleName

    let attributeCategoriesEnumName = "AttributeCategories"
    let declareAttributeCategoriesEnumName = sprintf "type %s=" attributeCategoriesEnumName

    let attributeTypesEnumName = "AttributeTypes"
    let declareAttributeTypesEnumName = sprintf "type %s=" attributeTypesEnumName

    let attributeTypesModuleName = "AttributeTypes"
    let declareAttributeTypesModule = sprintf "module internal %s=" attributeTypesModuleName


    