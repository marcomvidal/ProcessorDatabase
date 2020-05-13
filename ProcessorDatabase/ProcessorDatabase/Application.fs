module Application

open Model
open Presenter
open UserInterface

let mutable processors : Processor list = []
let mutable lastId = 0

let options = [
    { id = "1"; description = "Create a processor"; operation = Create };
    { id = "2"; description = "Show all processors"; operation = ShowAll };
    { id = "3"; description = "Edit a processor"; operation = Edit };
    { id = "4"; description = "Delete a processor"; operation = Delete }
]

let rec run() = 
    banner()
    let option = menu options

    match option with
    | Create ->
        lastId <- lastId + 1
        processors <- create lastId processors
    | ShowAll -> showAll asFullDescription processors
    | Edit -> processors <- edit processors
    | Delete -> processors <- delete processors
    | Invalid -> invalidOption()
    
    run()
