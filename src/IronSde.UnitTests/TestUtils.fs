namespace IronSde.UnitTests

open System

type TestSampling = 
    {
        iterations: int;
    }   

type TestSample = 
    {        
        iteration: int;
        duration: TimeSpan;
    }   

type TestSampleSummary = 
    {        
        iterations: int;
        avgTicks: float;
        minTicks: float;
        maxTicks: float;
    }   

module TestUtils=
    
    let epsilon = 1E-100

    let areEqual x y =
        if y = x then true
        else (y - x) < epsilon || (x - y) < epsilon

    let initSampling iterations =
        { TestSampling.iterations = iterations; }

    let takeSamples (preTest: unit -> 'a) (test: 'a -> unit) (init: TestSampling)=
        let sw = new System.Diagnostics.Stopwatch()

        let rec takeSample iteration result =
            match iteration with
            | 0 -> result
            | _ ->         
                    let r = preTest()
                    sw.Restart()            
                    test(r)
                    sw.Stop()

                    takeSample (iteration - 1) (sw.ElapsedTicks :: result)
        takeSample init.iterations []
        
    let finaliseSamples (times: int64 list)=
        let ticks = times |> List.skip 1
                          |> List.map (fun ts -> float ts)     

        let avg = ticks |> Seq.average
        let min = ticks |> Seq.min
        let max = ticks |> Seq.max
        
        { TestSampleSummary.avgTicks = avg; 
                            maxTicks = max; 
                            minTicks = min;
                            iterations = ticks.Length}

    let reportSamples (output: Xunit.Abstractions.ITestOutputHelper) (summary: TestSampleSummary) =        
        output.WriteLine(summary.iterations |> sprintf "Iterations: %i") 
        output.WriteLine(summary.avgTicks   |> sprintf "Avg ticks:  %f") 
        output.WriteLine(summary.minTicks   |> sprintf "Min ticks:  %f") 
        output.WriteLine(summary.maxTicks   |> sprintf "Max ticks:  %f") 
