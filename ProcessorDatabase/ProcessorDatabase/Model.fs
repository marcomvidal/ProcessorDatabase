module Model

type MenuOption = 
    | Create
    | ShowAll
    | Edit
    | Delete
    | Invalid

type Processor = 
    {
        id: int
        manufacturer: string
        model: string
        frequency: decimal
        coreCount: int
    }
