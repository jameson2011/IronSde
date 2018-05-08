namespace IronSde


module MapSearch=
    
    let private sq (x: float) = x * x

    /// Get a Euclidean distance between 2 Positions
    [<CompiledName("GetDistance")>]
    let distance (p1: Position) (p2: Position) =
        [ p1.x - p2.x; p1.y - p2.y; p1.z - p2.z ]
            |> Seq.map (float >> abs >> sq)
            |> Seq.sum 
            |> sqrt
            |> Units.toMetres
    
    /// Get distances bwetween Celestials
    [<CompiledName("GetCelestialDistances")>]    
    let getCelestialDistances pos (celestials: seq<Celestial>)=
        celestials 
        |> Seq.map (fun c ->    let d = c |> Celestials.position |> distance pos
                                c,d)
        |> Seq.sortBy (fun (_,d) -> d)        
    
    /// Find the closest Celestial, given a SolarSystem ID & an arbitrary Position
    [<CompiledName("FindClosestCelestial")>]
    let findClosestCelestial solarSystemId (position: Position) =        
        
        let celestials = solarSystemId
                            |> SolarSystems.celestials
                            |> getCelestialDistances position
                            |> List.ofSeq
        
        match celestials with        
        | []  ->    None
        | h::t ->   let _,bestDistance = h
                    let range = Units.auToMetres 2.0<AU> + bestDistance
                    let planetCelestials = Celestials.id >> SolarSystems.planetCelestials solarSystemId

                    let bestCelestials =  t |> Seq.filter (fun (_,d) -> d <= range )
                                            |> Seq.append (Seq.singleton h)
                                            |> Seq.cache
            
                    let subCelestials = bestCelestials
                                            |> Seq.map (fun (c,_) -> c)
                                            |> Seq.collect planetCelestials
                                            |> getCelestialDistances position                    
                        
                    subCelestials 
                        |> Seq.append bestCelestials                    
                        |> Seq.minBy (fun (_,d) -> d) 
                        |> Some
        
