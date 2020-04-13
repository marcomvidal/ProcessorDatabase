module Presenter

open System

let generateDashLine title = 
    title
    |> Seq.map (fun _ -> "-")
    |> String.Concat

let breakLine line = 
    line + "\n"

let generateTitle title = 
    ("" |> breakLine) +
        (title |> generateDashLine |> breakLine) +
        (title |> breakLine) +
        (title |> generateDashLine |> breakLine)

let drawTitle title = 
    printfn "%s" (generateTitle title)

let ask question =
    printfn "%s" question
    Console.ReadLine()
