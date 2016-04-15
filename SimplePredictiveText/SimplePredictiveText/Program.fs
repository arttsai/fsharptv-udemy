module FSharp.Tv.Program

open FSharp.Tv.PredictiveText


[<EntryPoint>]
let main argv = 
    autocomplete "z" usDic
    printfn "%A" argv
    0 // return an integer exit code




