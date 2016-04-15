open System.IO
open System

let usDic = Path.Combine(__SOURCE_DIRECTORY__, "dict.txt")

let loadDictFromPath path =
    File.ReadAllLines path


let loadDict () =
    let dict = loadDictFromPath usDic
    dict

