module UserInterface

open Model
open System
open Presenter

let banner() = 
    drawTitle "Processor Database"

let menu() = 
    printfn """Select an option:
    1. Create a processor
    2. Show all processors
    3. Edit a processor
    """
    printf "Select option [1-3]: "
    let option = Console.ReadLine()

    match option with
    | "1" -> MenuOption.Create
    | "2" -> MenuOption.ShowAll
    | "3" -> MenuOption.Edit
    | _ -> MenuOption.Invalid

let invalidOption() = 
    "Invalid option. Select an option again."
    |> breakLineAfter
    |> printf "%s"

let create id processors = 
    drawTitle "Register a processor"
    let processor = fillProcessorInformation id
    processor :: processors

let showAll processors showMode = 
    drawTitle "Summary"

    match processors with
    | [] -> printfn "%s" ("No processors registered." |> breakLineAfter)
    | p :: ps ->
        processors
        |> List.sortBy (fun p -> p.id)
        |> List.iter showMode

let edit processors =
    drawTitle "Edit a processor"
    showAll processors asSummary
    let id = ask ("Select a processor by its ID:" |> breakLineBefore) |> int
    let toDelete = processors |> List.find (fun p -> id = p.id)

    processors
    |> List.filter (fun p -> p <> toDelete)
    |> create id
