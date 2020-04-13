module UserInterface

open Model
open System
open Presenter

let banner() = 
    drawTitle "Processor Database"

let fillProcessorInformation =
    {
        manufacturer = ask "- Manufacturer:";
        model = ask "- Model:";
        frequency = ask "- Frequency (in GHz):" |> decimal;
        coreCount = ask "- Core count:" |> int
    }

let create processors = 
    drawTitle "Register a processor"
    fillProcessorInformation :: processors

let showSummary processors = 
    drawTitle "Summary"

    processors
    |> Seq.sortBy (fun processor -> processor.manufacturer)
    |> Seq.iter (fun processor -> printfn "%s" processor.model)

let menu() = 
    printfn """Select an option:
    1. Create a processor
    2. Show all processors
    """
    printf "Select option [1-2]: "
    let option = Console.ReadLine()

    match option with
    | "1" -> MenuOption.Create
    | "2" -> MenuOption.ShowSummary
    | _ -> MenuOption.Invalid

let invalidOption() = 
    printfn "\nInvalid option. Select again."