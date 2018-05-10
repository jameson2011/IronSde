namespace IronSde.Generator

open System
open IronSde.Types

type MarketGroupsWriter(targetPath: string)=
    
    let toMarketGroupData (value: MarketGroup) =
        { MarketGroupData.id = value.id; parentId = value.parentId; name = value.name }

    let marketGroupDataFuncName (value: MarketGroupData)=
        sprintf "marketGroup%i" value.id

    let toMarketGroupDataFunc (value: MarketGroupData)=
        sprintf "let private %s()= {%s.id = %i; parentId = %s; name = \"%s\"; }" 
            (marketGroupDataFuncName value) typeof<MarketGroupData>.Name value.id (Source.ofInt32Option value.parentId) value.name

    let dataHeaders = seq {
                            yield Source.declareItemtypesNamespace
                            yield Source.importIronSdeNamespace
                            yield Source.importIronSdeTypesNamespace
                            yield Source.declareMarketGroupsModule
                        }

    let enumHeaders = seq {
                            yield Source.declareIronSdeNamespace
                            yield Source.declareMarketGroupsEnum
                        }

    let marketGroupDataFuncs (marketGroups: seq<MarketGroupData>) =
        let factories = seq {
                            yield! marketGroups |> Seq.map toMarketGroupDataFunc
                            } |> Seq.map Source.indent
        
        let caseIds = marketGroups |> Seq.map (fun mg -> sprintf "| %i -> %s() |> Some" mg.id (marketGroupDataFuncName mg))
        let cases = seq {
                            yield "let marketgroup = "
                            yield "function" |> Source.indent
                            yield! caseIds |> Seq.map Source.indent
                            yield Source.defaultNoneCase |> Source.indent
                        } |> Seq.map Source.indent
        
        Seq.concat [factories; cases; ] 

    let marketGroupHierarchyCases (marketGroups: seq<MarketGroupData>) =
        let groups = marketGroups   |> Seq.groupBy (fun mg -> mg.parentId)
                                    |> Seq.map (fun (p,mgs) -> p, mgs |> Seq.map (fun mg -> mg.id) 
                                                                        |> Seq.sort |> Array.ofSeq )
        let toCase (group,ids) =
            sprintf "| %s -> %s" (Source.ofInt32Option group) (Source.toArrayOfInts ids)
        let cases = groups |> Seq.map toCase

        seq {
                yield "let marketGroupChildren = function"
                yield! cases |> Seq.map Source.indent
                yield Source.defaultEmptyArrayCase |> Source.indent
                } |> Seq.map Source.indent
    
    let marketGroupEnums (marketGroups: seq<MarketGroupData>) =
        let mgDict = marketGroups |> Seq.map (fun v -> v.id, v) |> Map.ofSeq
        
        let toEnumName = Source.makeValidEnum >> Source.toEnumName
        
        let getParents value = 
            let rec parents (value: MarketGroupData) result = 
                match value.parentId with
                | None -> result
                | Some id -> let mg = mgDict.[id] 
                             parents mg (mg::result)
            parents value [ value ]

        let fullPaths = marketGroups    |> Seq.map (fun mg -> mg, getParents mg 
                                                                    |> Seq.map (fun x -> toEnumName x.name)
                                                                    |> Strings.join "_")
                                        
        fullPaths |> Seq.map (fun (mg,n) -> sprintf "| %s = %i" n mg.id)
        

    member __.WriteData(marketGroups: seq<MarketGroup>)=
        let data = marketGroups |> Seq.map toMarketGroupData

        let dataFilePath = IO.combine targetPath "MarketGroups.fs"
        
        use writer = new System.IO.StreamWriter(dataFilePath)
        
        let funcLines = data |> marketGroupDataFuncs
        let groupLines = marketGroupHierarchyCases data

        let lines = Seq.concat [ dataHeaders; funcLines; groupLines]
                
        lines |> Seq.iter writer.WriteLine            

        writer.Flush()    
        writer.Close()
        
    member __.WriteEnums(marketGroups: seq<MarketGroup>)=
        let data = marketGroups |> Seq.map toMarketGroupData

        let dataFilePath = IO.combine targetPath "MarketGroupEnum.fs"

        use writer = new System.IO.StreamWriter(dataFilePath)
        
        let enumLines = data |> marketGroupEnums |> Seq.map Source.indent
        
        let lines = Seq.concat [ enumHeaders; enumLines; ]
                
        lines |> Seq.iter writer.WriteLine            

        writer.Flush()    
        writer.Close()