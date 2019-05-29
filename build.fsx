#r @"packages/FAKE/tools/FakeLib.dll"
#r @"packages/FAKE.IO.FileSystem/lib/netstandard2.0/Fake.IO.FileSystem.dll"

#load "scripts/http.fsx"

open Fake.Core
open Fake.Core.TargetOperators
open Fake.DotNet
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open Fake.IO
open Fake.DotNet.Testing.XUnit2
open Http

let buildNumber() =
  match System.Environment.GetEnvironmentVariable("APPVEYOR_BUILD_VERSION") with
    | null -> System.Console.Out.WriteLine("APPVEYOR_BUILD_VERSION is null")
              "0.0.1"
    | v -> v          
 

let sdeVersion = "sde-20190529-TRANQUILITY"
let nugetPkgVersion = buildNumber() 
let latestSdeUri = sprintf "https://cdn1.eveonline.com/data/sde/tranquility/%s.zip" sdeVersion

let buildDir = ".\\artifacts\\"
let buildGeneratorDir = buildDir </> "Generator"
let buildNamesDir = buildDir </> "Names"
let buildUniverseDir = buildDir </> "Universe"
let packageDir = buildDir </> "package"
let nugetPackageDir = buildDir </> "nupkgs"
let packageTargetDir = packageDir </> "lib" </> "net461"
let packageSourceFiles = buildUniverseDir </> "IronSde*.*"
let buildTestsDir = ".\\testartifacts\\"

let dataDir = ".\\data\\"
let downloadDir = dataDir </> "download\\"
let sdeZipFile = downloadDir </> "sde.zip"
let sdeFolder = dataDir </> "sde\\"

let nugetExePath = ".\\.tools\\nuget.exe"
let generatorSolution = ".\\src\\IronSde.Generator.sln"
let unitTestsSolution = ".\\src\\IronSde.UnitTests.sln"
let namesSolution = ".\\src\\IronSde.Names.sln"
let namesSolutionDir = __SOURCE_DIRECTORY__ </> ".\\src\\IronSde.Names\\"
let universeSolution = ".\\src\\IronSde.Universe.sln"
let universeSolutionDir = __SOURCE_DIRECTORY__ </> ".\\src\\IronSde.Universe\\"
let itemtypesSolution = ".\\src\\IronSde.ItemTypes.sln"
let itemtypesSolutionDir = __SOURCE_DIRECTORY__ </> ".\\src\\IronSde.ItemTypes\\"
let sharedSourceSolutionDir = __SOURCE_DIRECTORY__ </> ".\\src\\Shared\\"
let frontSolution = ".\\src\\IronSde.sln"
let generatorExe = buildGeneratorDir </> "IronSde.Generator.exe"
let assemblyInfo = @".\src\Shared\GlobalAssemblyInfo.fs"
let msbuildOptions = fun opts -> { opts with
                                    RestorePackagesFlag = false
                                    Targets = ["Rebuild"]
                                    Verbosity = Some MSBuildVerbosity.Normal
                                    Properties =
                                      [ "VisualStudioVersion", "15.0"
                                        "Configuration", "Release"
                                      ] }


Target.description "Patch AssemblyInfo"
Target.create "PatchAssemblyInfo" (fun _ -> Fake.DotNet.AssemblyInfoFile.updateAttributes 
                                                assemblyInfo
                                                [ AssemblyInfo.Attribute("AssemblyInformationalVersion", (sprintf "\"%s\"" sdeVersion), "", "") ] )  

Target.description "Clean local workspaces"
Target.create "CleanWorkspace" (fun _ -> Shell.cleanDirs [ dataDir; ])

Target.description "Clean build artifacts"
Target.create "CleanArtifacts" (fun _ -> Shell.cleanDirs [ buildDir; buildTestsDir; ])


Target.description "Create local workspaces"
Target.create "CreateWorkspace" (fun _ -> Shell.cleanDirs [ sdeFolder; downloadDir; packageDir; packageTargetDir; nugetPackageDir;  ] )

Target.description "Download Static Data"
Target.create "DownloadSde" (fun _ -> downloadFileAsync sdeZipFile latestSdeUri |> Async.RunSynchronously |> sprintf "Downloaded %s" |> Trace.trace)

Target.description "Unzip the Static Data"
Target.create "UnzipSde" (fun _ -> Fake.IO.Zip.unzip sdeFolder sdeZipFile )

Target.description "Verify Static Data"
Target.create "VerifySde" (fun _ -> Trace.trace "Verify complete" )

Target.description "Build IronSde.Generator"
Target.create "BuildGenerator"  (fun _ ->
                                          generatorSolution
                                            |> MSBuild.build msbuildOptions
                                        )

Target.description "Generate SDE source"
Target.create "RunGenerator"  (fun _ -> let shellParams = { ExecParams.Empty 
                                                                           with Program = generatorExe; 
                                                                                WorkingDir = __SOURCE_DIRECTORY__;
                                                                                Args = [    ("/sde", __SOURCE_DIRECTORY__ </> sdeFolder); 
                                                                                            ("/names", namesSolutionDir);
                                                                                            ("/universe", universeSolutionDir);
                                                                                            ("/types", itemtypesSolutionDir);
                                                                                            ("/shared", sharedSourceSolutionDir);
                                                                                        ] }
                                        match shellParams |> Process.asyncShellExec |> Async.RunSynchronously with
                                        | 0 -> ignore 0
                                        | x -> failwith (sprintf "RC %i from IronSde.Generator" x)
                                        
                                        )

Target.description "Build IronSde.Names"
Target.create "BuildNames"  (fun _ ->
                                          namesSolution
                                            |> MSBuild.build msbuildOptions)
                                        
Target.description "Build IronSde.Names.fsproj"
Target.create "BuildNamesProj"  (fun _ ->
                                          ".\\src\\IronSde.Names\\IronSde.Names.fsproj"
                                            |> MSBuild.build msbuildOptions )

Target.description "Build IronSde.Universe"
Target.create "BuildUniverse"  (fun _ ->
                                          universeSolution
                                            |> MSBuild.build msbuildOptions )



Target.description "Build IronSde.ItemTypes"
Target.create "BuildItemTypes"  (fun _ ->
                                          itemtypesSolution
                                            |> MSBuild.build msbuildOptions )

Target.description "Build IronSde"
Target.create "BuildIronSde"  (fun _ ->
                                          frontSolution
                                            |> MSBuild.build msbuildOptions )


Target.description "Build IronSde.UnitTests"
Target.create "BuildUnitTests"  (fun _ ->
                                          unitTestsSolution
                                            |> MSBuild.build msbuildOptions)

Target.description "Run unit tests"
Target.create "UnitTests" (fun _ -> 
                            !! (buildTestsDir </> "*.UnitTests.dll")
                            |> run (fun p ->
                                            { p with 
                                                ShadowCopy = false;
                                                HtmlOutputPath = Some (buildTestsDir </> "UnitTestResults.html")
                                            }
                                        )                            
                            )


Target.description "Create package dir"
Target.create "CreatePackageDir" ( fun _ -> Fake.IO.Directory.ensure packageDir)

Target.description "Copy package files"
Target.create "CopyPackageFiles" (fun _ -> !! packageSourceFiles
                                                |> Fake.IO.Shell.copyFiles packageTargetDir;
                                                )

Target.description "Create nupkg"
Target.create "CreateNupkg" (fun p -> Fake.IO.Directory.ensure nugetPackageDir
                                      Fake.DotNet.NuGet.NuGet.NuGetPackDirectly 
                                        (fun p2 -> { p2 with ToolPath = nugetExePath; 
                                                              Version = nugetPkgVersion; 
                                                              WorkingDir = ".\\";
                                                              BasePath = Some packageDir;
                                                              OutputPath = nugetPackageDir;
                                                               }) 
                                        ".\\IronSde.nuspec")

Target.create "All" (fun _ -> Trace.trace "All done" )

"CleanWorkspace"
==> "CreateWorkspace"
==> "DownloadSde"
==> "UnzipSde"
==> "VerifySde"

?=> "CleanArtifacts"
==> "PatchAssemblyInfo"
==> "BuildGenerator"
==> "RunGenerator"

?=> "BuildNames"
==> "BuildItemTypes"
==> "BuildUniverse"
==> "BuildIronSde"

?=> "BuildUnitTests"
==> "UnitTests"

?=> "CreatePackageDir"
==> "CopyPackageFiles"
==> "CreateNupkg"

"VerifySde"
==> "All"
"RunGenerator"
==> "All"
"BuildIronSde"
==> "All"
"UnitTests"
==> "All"
"CopyPackageFiles"
==> "All"
"CreateNupkg"
==> "All"

Target.runOrDefault "All"

