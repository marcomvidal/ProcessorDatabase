module Operations

open Model

let save processor processors =
    processor :: processors

let findById id processors =
    processors |> List.tryFind (fun p -> id = p.id)

let delete processor processors =
    processors |> List.filter (fun p -> processor <> p)
