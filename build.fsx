#r ".\\packages\\FAKE\\tools\\FakeLib.dll"
#load "scripts/http.fsx"

open Fake.Core
open Fake.DotNet
open Fake.FileHelper
open Fake.EnvironmentHelper
open Fake.IO.Globbing.Operators
open Fake.Core.TargetOperators
open Fake.ProcessHelper
open Fake.DotNet.Testing.XUnit2
open Http


let sdeVersion = "sde-20180508-TRANQUILITY"
let latestSdeUri = sprintf "https://cdn1.eveonline.com/data/sde/tranquility/%s.zip" sdeVersion

let buildDir = ".\\artifacts\\"
let buildGeneratorDir = buildDir @@ "Generator"
let buildNamesDir = buildDir @@ "Names"
let buildUniverseDir = buildDir @@ "Universe"
let packageDir = buildDir @@ "package"
let packageSourceFiles = buildUniverseDir @@ "IronSde*.*"
let buildTestsDir = ".\\testartifacts\\"

let dataDir = ".\\data\\"
let downloadDir = dataDir @@ "download\\"
let sdeZipFile = downloadDir @@ "sde.zip"
let sdeFolder = dataDir @@ "sde\\"

let generatorSolution = ".\\src\\IronSde.Generator.sln"
let unitTestsSolution = ".\\src\\IronSde.UnitTests.sln"
let namesSolution = ".\\src\\IronSde.Names.sln"
let namesSolutionDir = __SOURCE_DIRECTORY__ @@ ".\\src\\IronSde.Names\\"
let universeSolution = ".\\src\\IronSde.Universe.sln"
let universeSolutionDir = __SOURCE_DIRECTORY__ @@ ".\\src\\IronSde.Universe\\"
let itemtypesSolution = ".\\src\\IronSde.ItemTypes.sln"
let itemtypesSolutionDir = __SOURCE_DIRECTORY__ @@ ".\\src\\IronSde.ItemTypes\\"
let sharedSourceSolutionDir = __SOURCE_DIRECTORY__ @@ ".\\src\\Shared\\"
let frontSolution = ".\\src\\IronSde.sln"
let generatorExe = buildGeneratorDir @@ "IronSde.Generator.exe"
let assemblyInfo = @".\src\Shared\GlobalAssemblyInfo.fs"



Target.Description "Patch AssemblyInfo"
Target.Create "PatchAssemblyInfo" (fun _ -> Fake.DotNet.AssemblyInfoFile.UpdateAttributes 
                                                assemblyInfo
                                                [ AssemblyInfo.Attribute("AssemblyInformationalVersion", (sprintf "\"%s\"" sdeVersion), "", "") ] )  

Target.Description "Clean local workspaces"
Target.Create "CleanWorkspace" (fun _ -> CleanDirs [ dataDir; ])

Target.Description "Clean build artifacts"
Target.Create "CleanArtifacts" (fun _ -> CleanDirs [ buildDir; buildTestsDir; ])


Target.Description "Create local workspaces"
Target.Create "CreateWorkspace" (fun _ -> CleanDirs [ sdeFolder; downloadDir; packageDir; ] )

Target.Description "Download Static Data"
Target.Create "DownloadSde" (fun _ -> downloadFileAsync sdeZipFile latestSdeUri |> Async.RunSynchronously |> sprintf "Downloaded %s" |> Trace.trace)

Target.Description "Unzip the Static Data"
Target.Create "UnzipSde" (fun _ -> Fake.ZipHelper.Unzip sdeFolder sdeZipFile )

Target.Description "Verify Static Data"
Target.Create "VerifySde" (fun _ -> Trace.trace "Verify complete" )

Target.Description "Build IronSde.Generator"
Target.Create "BuildGenerator"  (fun _ ->
                                          !! generatorSolution
                                            |> MsBuild.RunRelease buildGeneratorDir "Build"
                                            |> Trace.Log "AppBuild-Output: "
                                        )

Target.Description "Generate SDE source"
Target.Create "RunGenerator"  (fun _ -> let shellParams = { defaultParams with Program = generatorExe; 
                                                                                WorkingDirectory = __SOURCE_DIRECTORY__;
                                                                                Args = [    ("/sde", __SOURCE_DIRECTORY__ @@ sdeFolder); 
                                                                                            ("/names", namesSolutionDir);
                                                                                            ("/universe", universeSolutionDir);
                                                                                            ("/types", itemtypesSolutionDir);
                                                                                            ("/shared", sharedSourceSolutionDir);
                                                                                        ] }
                                        match shellParams |> asyncShellExec |> Async.RunSynchronously with
                                        | 0 -> ignore 0
                                        | x -> failwith (sprintf "RC %i from IronSde.Generator " x)
                                        
                                        )

Target.Description "Build IronSde.Names"
Target.Create "BuildNames"  (fun _ ->
                                          !! namesSolution
                                            |> MsBuild.RunRelease buildNamesDir "Build"
                                            |> Trace.Log "AppBuild-Output: " )
                                        
Target.Description "Build IronSde.Names.fsproj"
Target.Create "BuildNamesProj"  (fun _ ->
                                          !! ".\\src\\IronSde.Names\\IronSde.Names.fsproj"
                                            |> MsBuild.RunRelease buildNamesDir "Build"
                                            |> Trace.Log "AppBuild-Output: " )

Target.Description "Build IronSde.Universe"
Target.Create "BuildUniverse"  (fun _ ->
                                          !! universeSolution
                                            |> MsBuild.RunRelease buildUniverseDir "Build"
                                            |> Trace.Log "AppBuild-Output: " )



Target.Description "Build IronSde.ItemTypes"
Target.Create "BuildItemTypes"  (fun _ ->
                                          !! itemtypesSolution
                                            |> MsBuild.RunRelease buildUniverseDir "Build"
                                            |> Trace.Log "AppBuild-Output: " )

Target.Description "Build IronSde"
Target.Create "BuildIronSde"  (fun _ ->
                                          !! frontSolution
                                            |> MsBuild.RunRelease buildUniverseDir "Build"
                                            |> Trace.Log "AppBuild-Output: " )


Target.Description "Build IronSde.UnitTests"
Target.Create "BuildUnitTests"  (fun _ ->
                                          !! unitTestsSolution
                                            |> MsBuild.RunRelease buildTestsDir "Build"
                                            |> Trace.Log "TestsBuild-Output: "
                                        )

Target.Description "Run unit tests"
Target.Create "UnitTests" (fun _ -> 
                            !! (buildTestsDir @@ "*.UnitTests.dll")
                            |> xUnit2 (fun p ->
                                            { p with 
                                                ShadowCopy = false;
                                                HtmlOutputPath = Some (buildTestsDir @@ "UnitTestResults.html")
                                            }
                                        )                            
                            )

Target.Description "Create package dir"
Target.Create "CreatePackageDir" ( fun _ -> Fake.IO.Directory.ensure packageDir)

Target.Description "Copy package files"
Target.Create "CopyPackageFiles" (fun _ -> !! packageSourceFiles
                                                |> Fake.IO.Shell.CopyFiles packageDir
                                                )

Target.Create "All" (fun _ -> Trace.trace "All done" )

"CleanWorkspace"
==> "CreateWorkspace"
==> "DownloadSde"
==> "UnzipSde"
==> "VerifySde"

"CleanArtifacts"
==> "PatchAssemblyInfo"
==> "BuildGenerator"
==> "RunGenerator"
==> "BuildNames"


"BuildIronSde"
==> "BuildUnitTests"
==> "UnitTests"

"CreatePackageDir"
==> "CopyPackageFiles"

"VerifySde"
==> "All"
"BuildNames"
==> "All"
"BuildItemTypes"
==> "All"
"BuildUniverse"
==> "All"
"UnitTests"
==> "All"
"CopyPackageFiles"
==> "All"

Target.RunOrDefault "All"

