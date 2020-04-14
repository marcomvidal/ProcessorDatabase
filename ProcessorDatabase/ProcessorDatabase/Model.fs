module Model

type MenuOption = 
    | Create
    | ShowAll
    | Edit
    | Invalid

type Processor = 
    {
        id: int
        manufacturer: string
        model: string
        frequency: decimal
        coreCount: int
    }
