module Application

open Model
open UserInterface

let mutable processors : Processor list = []

let rec run() = 
    banner()
    let option = menu()

    match option with
    | MenuOption.Create -> processors <- create processors
    | MenuOption.ShowSummary -> showSummary processors
    | MenuOption.Invalid -> invalidOption()
    
    run()
