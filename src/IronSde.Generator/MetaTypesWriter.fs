namespace IronSde.Generator

open System
open IronSde.Types

type internal MetaTypesWriter(targetPath: string)=

    let dataFilePath = IO.combine targetPath "Metagroups.fs"

    let metagroupFactoryName id = sprintf "metagroup%i" id

    let typeMetagroupCase typeid groupid = sprintf "| %i -> %s() |> Some" typeid (metagroupFactoryName groupid )

    let dataFactory (value) =         
        sprintf "let private %s()= { MetaGroupData.id = %i; name = \"%s\"; typeIds = %s }" 
            (metagroupFactoryName value.id) value.id 
            value.name (value.typeIds |> Seq.map (fun s -> s.ToString()) |> Source.toArrayOfStrings)
            
    let dataFuncs values =
        values |> Seq.map dataFactory 
        
    let enums values =
        values |> Seq.map (fun v -> sprintf "| %s = %i" (Source.toEnumName v.name) v.id)
    
    let typeGroupCaseGroups count (values: MetaGroupData list)=
        let ids = values |> Seq.collect (fun mg -> mg.typeIds |> Seq.map (fun i -> i, mg.id) )
                         |> Seq.sortBy fst
        ids |> Seq.chunkBySize count
        
    let typeGroupCaseFuncName = sprintf "itemtypesMeta%i"

    let typeGroupCaseFuncs idx (values: seq<int * int>)=
        seq {
            yield typeGroupCaseFuncName idx |> sprintf "let private %s = " 
            yield "function" |> Source.indent 
            yield! values 
                    |> Seq.map (fun t -> typeMetagroupCase (fst t) (snd t) |> Source.indent )
            yield "| _ -> None" |> Source.indent 
        } |> List.ofSeq
        
    let writeData metagroups = 
        let headers = seq {
                            yield Source.declareItemtypesNamespace
                            yield Source.importIronSdeNamespace
                            yield Source.importIronSdeTypesNamespace
                            yield Source.declareMetaGroupsModule
                        }
        let factories = seq {
                            yield! metagroups |> dataFuncs
                            } |> Seq.map Source.indent

        let caseGroups = metagroups |> typeGroupCaseGroups 200
        
        let caseIds = caseGroups |> Seq.mapi (fun i pairs -> i, pairs |> Seq.map fst |> Seq.max, pairs)

        let caseFuncs = caseGroups  |> Seq.mapi (fun i xs -> typeGroupCaseFuncs i xs)
                                    |> Seq.collect (fun s -> s)
                                    |> Seq.map Source.indent
                                    
        let cases = seq {
                            yield "let itemtypesMeta = "
                            yield "function" |> Source.indent
                            yield! caseIds |> Seq.map (fun (i,id,_) -> sprintf "| x when x <= %i -> %s(x) " id  (typeGroupCaseFuncName i) |> Source.indent) 
                            yield "| _ -> None" |> Source.indent
                        } |> Seq.map Source.indent
        

        use writer = new System.IO.StreamWriter(dataFilePath)

        Seq.concat [headers; factories; caseFuncs; cases; ] 
            |> Seq.iter writer.WriteLine            

        writer.Flush()    
        writer.Close()

    let writeEnums metagroups = 
        let headers = seq {
                            yield Source.declareIronSdeNamespace
                            yield Source.declareMetaGroupsEnum
                        }

        let enums = seq {
                            yield! metagroups |> enums
                            } |> Seq.map Source.indent

        use writer = new System.IO.StreamWriter(dataFilePath)

        Seq.concat [headers; enums; ] 
            |> Seq.iter writer.WriteLine            

        writer.Flush()    
        writer.Close()

    member __.Write(metagroups: MetaGroupData list)=
        metagroups |> writeData
        
    member __.WriteEnums(metagroups: MetaGroupData list)=
        metagroups |> writeEnums
