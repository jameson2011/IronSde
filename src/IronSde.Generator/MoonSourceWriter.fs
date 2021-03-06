﻿namespace IronSde.Generator

open IronSde.Universe
open IronSde.Generator.IO

module internal MoonSourceWriter=
    
    let moonFactoryName id = sprintf "moon%i" id
    
    let formatMoon (value: MoonData) =         
        sprintf "{ MoonData.id = %i; x = %.20E; y = %.20E; z = %.20E; solarSystemId = %i; planetId = %i;  }"
            value.id
            value.x value.y value.z
            value.solarSystemId
            value.planetId

    let formatMoons (values: seq<MoonData>) =
        values |> Seq.map formatMoon |> Source.toArrayOfStrings
        
    let private systemMoonCase solarSystemId values = 
        values |> formatMoons |> sprintf "| %i -> %s" solarSystemId

    let private systemMoonsChunkFile idx = (sprintf "Moons%i" idx)

    let private writeSystemMoons dir idx (values: seq<int * seq<MoonData>>) = 
        let path = combine dir (sprintf "%s.fs" (systemMoonsChunkFile idx))
        use writer = new System.IO.StreamWriter(path)
        
        let headers = seq {
                            yield Source.declareUniverseNamespace
                            yield Source.importIronSdeNamespace
                            yield Source.declareMoonChunksModule idx 
                        }
        let lines = seq {
                            
                            yield "let moons solarSystemId = "
                            yield "match solarSystemId with" |> Source.indent
                            yield! values |> Seq.map (fun (i,ms) -> systemMoonCase i ms |> Source.indent)
                            yield "| _ -> [||]" |> Source.indent                            
                        } |> Seq.map Source.indent

        Seq.concat [headers; lines] 
            |> Seq.iter writer.WriteLine

        writer.Flush()    
        writer.Close()
        
    let private writeMoonsAccessor dir (values: seq<int * seq<int>>) = 
        let path = combine dir "Moons.fs"
                
        
        let systemCase idx ids= 
            let lastIdx = ids |> Seq.last
            sprintf "| x when x <= %i -> %s.moons solarSystemId" lastIdx (systemMoonsChunkFile idx)

        use writer = new System.IO.StreamWriter(path)
        let headers = seq {
                            yield Source.declareUniverseNamespace
                            yield Source.importIronSdeNamespace
                            yield Source.declareMoonsModule
                        }
        let lines = seq {                            
                            yield "let moons solarSystemId = "
                            yield "match solarSystemId with" |> Source.indent
                            yield! values |> Seq.map (fun (idx,ids) -> systemCase idx ids |> Source.indent)
                            yield "| _ -> [||]" |> Source.indent                            
                        } |> Seq.map Source.indent

        Seq.concat [headers; lines] 
            |> Seq.iter writer.WriteLine

        writer.Flush()    
        writer.Close()

    let write dir chunks (values: seq<MoonData>) =       
                
        let moonChunks = values |> Seq.groupBy (fun m -> m.solarSystemId)
                                |> Seq.sortBy (fun (id,_) -> id)
                                |> Seq.splitInto chunks
                                |> Seq.cache
        
        moonChunks |> Seq.iteri (fun i ms -> writeSystemMoons dir i ms)

        
        let idsChunks = moonChunks |> Seq.mapi (fun idx ids -> idx, ids |> Seq.map (fun (id,_) -> id))        
        writeMoonsAccessor dir idsChunks
        

        
        
