open System.IO
open System

let usDic = Path.Combine(__SOURCE_DIRECTORY__, "dict.txt")

let loadDictFromPath path =
    File.ReadAllLines path


let loadDict () =
    let dict = loadDictFromPath usDic
    printfn __SOURCE_DIRECTORY__
    dict

let loaded = loadDict()

let filtering =
    let data = [|"butyl";"byer";"buzzy";"bwana";"bylaw"|]
    let candidates = data |> Array.filter (fun word -> word.Contains "w")
    candidates


let filter2 (prefix:string) (data:string[]) =
    let candidates = data |> Array.filter (fun word -> word.StartsWith(prefix))
    candidates

filter2 "z" loaded

