﻿module UserInterface

open Model
open System
open Presenter
open Service

let banner() = 
    drawTitle "Processor Database"

let menu (options : MenuOption list) = 
    drawMenu options
    let lastId = options |> List.rev |> List.head |> fun o -> o.id
    showSelectOption lastId
    let option = Console.ReadLine()

    match options |> List.tryFind (fun o -> o.id = option) with
    | Some option -> option.operation
    | None -> Invalid

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
