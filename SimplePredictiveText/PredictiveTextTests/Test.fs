module Tests

open FsUnit
open NUnit.Framework

[<Test>]
let testing () =
    [0] |> should not' (be Empty)


[<Test>]
let testing2 () =
    true |> not

      

