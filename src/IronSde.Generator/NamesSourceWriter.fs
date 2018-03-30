namespace IronSde.Generator

open System.Xml.Linq
open IronSde.Generator.IO

module NamesSourceWriter=
        
    let private resouceFileName = sprintf "Names%i"
    let private xns s = XName.Get(s, "http://schemas.microsoft.com/developer/msbuild/2003")
    let private xn s = XName.Get(s)

    let private writeBlock dir resName (names: (int * string) []) = 
        let fileName = sprintf "%s.resx" resName
        let outfile = combine dir fileName

        use writer= new System.IO.StreamWriter(outfile)
        use resWriter = new System.Resources.ResXResourceWriter(writer)

        names |> Seq.iter (fun (id,value) -> resWriter.AddResource(IronSde.ResourceUtils.nameResourceName id, value))
        
        writer.Flush()
        resWriter.Close()        
        writer.Close()
        
        fileName

    let private writeResourceUtils (filepath: string) (resources: (int * string * string) list) =
        let resMgrNames = resources |> Seq.map (fun (_,n,_) -> sprintf "\"IronSde.Names.%s\"" n) |> Source.toArrayOfStrings
        
        let resMgrMatches = seq { 
                                    yield! resources |> Seq.truncate (resources.Length - 1)
                                                    |> Seq.mapi (fun idx (id,_,_) -> sprintf "| x when x <= %i -> resourceManagers.[%i]" id idx)
                                    yield sprintf "| _ -> resourceManagers.[%i]" (resources.Length-1)
                                } 
        let headers = [ "namespace IronSde.Names"; "open System.Reflection"; 
                        "open System.Resources"; "module ResourceUtils="; ]
        
        let methodHeaders = [   "let name ="] |> Seq.map Source.indent |> List.ofSeq
 
        let lines = seq {
                            yield "let asm = Assembly.GetExecutingAssembly()";
                            yield sprintf "let resourceManagers = %s |> Array.map (fun n -> new ResourceManager(n, asm))" resMgrNames;
                            yield "let resMgr id =";
                            yield "match id with" |> Source.indent;
                            yield! resMgrMatches |> Seq.map Source.indent 
                            yield "(fun id ->   try"
                            yield "                 let res = resMgr id"
                            yield "                 res.GetString(IronSde.ResourceUtils.nameResourceName id) |> Some"
                            yield "             with"
                            yield "             | :? System.Resources.MissingManifestResourceException as ex -> None)" 
                        } |> Seq.map Source.indent2 |> List.ofSeq
        
        
        use writer = new System.IO.StreamWriter(filepath)
        
        Seq.concat [headers; methodHeaders; lines] 
            |> Seq.iter writer.WriteLine        

        writer.Flush()
        writer.Close()
        
        
    let writeNames dir blockCount (names: seq<int * string>) = 
        let nameBlocks = names  |> Seq.sortBy (fun (i,_) -> i)
                                |> Seq.splitInto blockCount                                
                                |> Seq.mapi (fun i ns ->    let lastId = ns |> Seq.last |> (fun (i,_) -> i) 
                                                            let blockName = resouceFileName i
                                                            lastId, blockName, ns)                                

        nameBlocks  |> Seq.map (fun (lastId, name, names) -> lastId, name, (writeBlock dir name names) )
                    |> List.ofSeq
        


    let private setProject (fsprojfile: string) names =               
        
        let doc = XDocument.Load(fsprojfile)
        let groups = doc.Element(xns "Project").Elements(xns "ItemGroup")
       
        let compileEntries = groups.Elements(xns "Compile") |> Array.ofSeq
        if compileEntries.Length = 0 then
            failwith "Unrecognised .fsproj"

        let parent = compileEntries.[0].Parent        
        parent.Elements(xns "EmbeddedResource") |> Array.ofSeq |> Seq.iter (fun n -> n.Remove())
        
        let embedded = names |> Seq.map (fun n -> new XElement(xns "EmbeddedResource", new XAttribute(xn "Include", n))) |> List.ofSeq
        embedded |> Seq.iter (fun e -> parent.Add(e))
        
        doc.Save(fsprojfile)
        

    let write dir blockCount (names: seq<int * string>) = 
        let resources = writeNames dir blockCount names

        writeResourceUtils (combine dir "ResourceUtils.fs") resources

        let files = resources |> Seq.map (fun (_,_,n) -> n) |> List.ofSeq

        setProject (combine dir "IronSde.Names.fsproj") files
        

    