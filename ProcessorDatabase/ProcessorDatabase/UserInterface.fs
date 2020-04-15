module UserInterface

open Model
open System
open Presenter
open Operations

let banner() = 
    drawTitle "Processor Database"

let menu() = 
    printfn """Select an option:
    1. Create a processor
    2. Show all processors
    3. Edit a processor
    4. Delete a processor
    """
    printf "Select option [1-3]: "
    let option = Console.ReadLine()

    match option with
    | "1" -> MenuOption.Create
    | "2" -> MenuOption.ShowAll
    | "3" -> MenuOption.Edit
    | "4" -> MenuOption.Delete
    | _ -> MenuOption.Invalid

let invalidOption() = 
    "Invalid option. Select an option again."
    |> breakLineAfter
    |> printf "%s"

let create id processors = 
    drawTitle "Register a processor"
    processors |> save (fillProcessorInformation id)
    
let edit processors =
    drawTitle "Edit a processor"
    let id = showSummaryAndAskId processors

    match processors |> findById id with
    | Some processor -> processors |> delete processor |> create id
    | None -> noProcessorFoundById processors

let delete processors =
    drawTitle "Delete a processor"
    let id = showSummaryAndAskId processors

    match processors |> findById id with
    | Some processor -> processors |> delete processor
    | None -> noProcessorFoundById processors
