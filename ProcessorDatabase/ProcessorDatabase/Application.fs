module Application

open Model
open Presenter
open UserInterface

let mutable processors : Processor list = []
let mutable lastId = 0

let rec run() = 
    banner()
    let option = menu()

    match option with
    | MenuOption.Create ->
        lastId <- lastId + 1
        processors <- create lastId processors
    | MenuOption.ShowAll ->
        showAll processors asFullDescription
    | MenuOption.Edit ->
        processors <- edit processors
    | MenuOption.Invalid ->
        invalidOption()
    
    run()
