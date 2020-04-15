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

let asSummary processor =
    printfn "%i) %s %s" processor.id processor.manufacturer processor.model

let asFullDescription processor =
    asSummary processor
    printfn "- Frequency: %.2f GHz" processor.frequency
    printfn "- Core count: %i \n" processor.coreCount

let fillProcessorInformation id =
    {
        id = id
        manufacturer = ask "- Manufacturer:";
        model = ask "- Model:";
        frequency = ask "- Frequency (in GHz):" |> decimal;
        coreCount = ask "- Core count:" |> int
    }

let showAll showMode processors = 
    drawTitle "Summary"

    match processors with
    | [] -> printfn "%s" ("No processors registered." |> breakLineAfter)
    | p :: ps ->
        processors
        |> List.sortBy (fun p -> p.id)
        |> List.iter showMode

let showSummaryAndAskId processors = 
    showAll asSummary processors
    ask ("Select a processor by its ID:" |> breakLineBefore) |> int

let noProcessorFoundById processors =
    printfn "The processor with the requested ID does not exist."
    processors
