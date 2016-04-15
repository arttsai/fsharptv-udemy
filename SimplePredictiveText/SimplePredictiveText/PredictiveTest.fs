module FSharp.Tv.PredictiveText

open System.IO
open System

let private usDic = Path.Combine(__SOURCE_DIRECTORY__, "dict.txt")

let loadDictFromPath path =
    File.ReadAllLines path


let loadDict () =
    let dict = loadDictFromPath usDic
    printfn __SOURCE_DIRECTORY__
    dict

let loaded = loadDict()

let autocomplete (prefix:string) (data:string[]) =
    let candidates = data |> Array.filter (fun word -> word.StartsWith prefix)
    candidates

