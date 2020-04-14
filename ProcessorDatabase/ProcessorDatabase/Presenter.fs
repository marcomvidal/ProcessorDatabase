module Presenter

open System
open Model

let generateDashLine title = 
    title
    |> Seq.map (fun _ -> "-")
    |> String.Concat

let breakLineBefore line =
    "\n" + line

let breakLineAfter line = 
    line + "\n"

let generateTitle title = 
    ("" |> breakLineAfter) +
        (title |> generateDashLine |> breakLineAfter) +
        (title |> breakLineAfter) +
        (title |> generateDashLine |> breakLineAfter)

let drawTitle title = 
    printfn "%s" (generateTitle title)

let ask question =
    printf "%s" (question + " ")
    Console.ReadLine()

let asFullDescription processor =
    printfn "%i) %s %s" processor.id processor.manufacturer processor.model
    printfn "- Frequency: %.2f GHz" processor.frequency
    printfn "- Core count: %i \n" processor.coreCount

let asSummary processor =
    printfn "%i) %s %s" processor.id processor.manufacturer processor.model

let fillProcessorInformation id =
    {
        id = id
        manufacturer = ask "- Manufacturer:";
        model = ask "- Model:";
        frequency = ask "- Frequency (in GHz):" |> decimal;
        coreCount = ask "- Core count:" |> int
    }
