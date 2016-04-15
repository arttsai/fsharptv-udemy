module FSharp.Tv.PredictiveText

open System.IO
open System

let private usDic = Path.Combine(__SOURCE_DIRECTORY__, "dict.txt")

///Allows you to load your own dictionary of data
let LoadDictFromPath path =
    File.ReadAllLines path

///Loads the default dictionary
let LoadDict () =
    let dict = LoadDictFromPath usDic
    dict

///Provide a prefix with an array and returns matches.
let Autocomplete (prefix:string) (data:string[]) =
    let candidates = data |> Array.filter (fun word -> word.StartsWith prefix)
    candidates

