namespace IronSde.Generator

open System.Xml.Linq
open IronSde.Generator.IO

type private ResourceBlock = { id: int; name: string; fileName: string }

type NamesSourceWriter(dir, blockCount)=

    let resouceFileName = sprintf "Names%i"
    let categoryResourceFileName = "CategoryNames"
    let groupResourceFileName = "GroupNames"
    let typeResourceFileName = "TypeNames"

    let xns s = XName.Get(s, "http://schemas.microsoft.com/developer/msbuild/2003")
    let xn s = XName.Get(s)

    let mutable categoryResources: ResourceBlock list = []
    let mutable groupResources: ResourceBlock list = []
    let mutable typeResources: ResourceBlock list = []
    let mutable nameResources: ResourceBlock list = []

    let writeBlock (resName: int -> string) resFileName (names: Name []) = 
        let fileName = sprintf "%s.resx" resFileName
        let outfile = combine dir fileName

        use writer= new System.IO.StreamWriter(outfile)
        use resWriter = new System.Resources.ResXResourceWriter(writer)

        names |> Seq.iter (fun n -> resWriter.AddResource(resName n.id, n.name))
        
        writer.Flush()
        resWriter.Close()        
        writer.Close()
        
        fileName

    let writeResourceFunc (method: string) (names: ResourceBlock list) =
        let resMgrNames = names |> Seq.map (fun rb -> sprintf "\"IronSde.Names.%s\"" rb.name) 
                                |> Source.toArrayOfStrings
        
        let resMgrMatches = seq { 
                                    yield! names |> Seq.truncate (names.Length - 1)
                                                    |> Seq.mapi (fun idx rb -> sprintf "| x when x <= %i -> resourceManagers.[%i]" rb.id idx)
                                    yield sprintf "| _ -> resourceManagers.[%i]" (names.Length-1)
                                }
        let methodHeaders = [ (sprintf "let %s =" method) ] |> Seq.map Source.indent |> List.ofSeq

        let lines = seq {
                            yield "let asm = Assembly.GetExecutingAssembly()";
                            yield sprintf "let resourceManagers = %s |> Array.map (fun n -> new ResourceManager(n, asm))" resMgrNames;
                            yield "let resMgr id =";
                            yield "match id with" |> Source.indent;
                            yield! resMgrMatches |> Seq.map Source.indent 
                            yield "(fun id ->   try"
                            yield "                 let res = resMgr id"
                            yield sprintf "                 res.GetString(IronSde.ResourceUtils.%sResourceName id) |> Some" method
                            yield "             with"
                            yield "             | :? System.Resources.MissingManifestResourceException as ex -> None)" 
                        } |> Seq.map Source.indent2 |> List.ofSeq
        List.concat [methodHeaders; lines] 
    
    let writeResourceUtils (filepath: string) (categories: ResourceBlock list) (groups: ResourceBlock list)
                            (types: ResourceBlock list) (names: ResourceBlock list) =        
        let funcs = List.concat [   writeResourceFunc "category" categories; 
                                    writeResourceFunc "group" groups; 
                                    writeResourceFunc "itemtype" types; 
                                    writeResourceFunc "name" names;
                                    ]
        
        let headers = [ "namespace IronSde.Names"; "open System.Reflection"; 
                        "open System.Resources"; "module ResourceUtils="; ]
        
        
        use writer = new System.IO.StreamWriter(filepath)
        
        Seq.concat [headers; funcs] 
            |> Seq.iter writer.WriteLine        

        writer.Flush()
        writer.Close()

        
    let lastId (names: seq<Name>) = names |> Seq.last |> (fun n -> n.id) 

    let writeCategories (names: seq<Name>) = 
        let names = Array.ofSeq names 
        [ { ResourceBlock.id = lastId names;
                                name = categoryResourceFileName; 
                                fileName = (writeBlock IronSde.ResourceUtils.categoryResourceName categoryResourceFileName names) } ]        
                                        
    let writeGroups (names: seq<Name>) = 
        let names = Array.ofSeq names 
        [ { ResourceBlock.id = lastId names;
                                name = groupResourceFileName; 
                                fileName = (writeBlock IronSde.ResourceUtils.groupResourceName groupResourceFileName names) } ]
    
    let writeTypes (names: seq<Name>) = 
        let names = Array.ofSeq names 
        [ { ResourceBlock.id = lastId names;
                                name = typeResourceFileName; 
                                fileName = (writeBlock IronSde.ResourceUtils.itemtypeResourceName typeResourceFileName names) } ]

    let writeNames (names: seq<Name>) = 
        let nameBlocks = names  |> Seq.sortBy (fun n -> n.id)
                                |> Seq.splitInto blockCount
                                |> Seq.mapi (fun i ns ->    let lastId = lastId ns
                                                            let blockName = resouceFileName i
                                                            lastId, blockName, ns)                                

        nameBlocks  |> Seq.map (fun (lastId, name, names) -> {ResourceBlock.id = lastId; name = name; fileName = (writeBlock IronSde.ResourceUtils.nameResourceName name names)} )
                    |> List.ofSeq
        


    let setProject (fsprojfile: string) names =
        
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
            
    member __.WriteCategories (names: seq<Name>) =
        categoryResources <- writeCategories names
        
    member __.WriteGroups (names: seq<Name>) =
        groupResources <- writeGroups names
    
    member __.WriteTypes (names: seq<Name>) =
        typeResources <- writeTypes names
    
    member __.WriteNames (names: seq<Name>) = 
        nameResources <- writeNames names                

    member __.Close () = 
        
        writeResourceUtils (combine dir "ResourceUtils.fs")  categoryResources groupResources typeResources nameResources

        let files = nameResources 
                        |> Seq.append categoryResources
                        |> Seq.append groupResources
                        |> Seq.append typeResources
                        |> Seq.map (fun rb -> rb.fileName) 
                        |> List.ofSeq
        
        setProject (combine dir "IronSde.Names.fsproj") files
        

    