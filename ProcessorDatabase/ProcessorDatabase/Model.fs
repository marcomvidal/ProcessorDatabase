module Model

type MenuOperation = 
    | Create
    | ShowAll
    | Edit
    | Delete
    | Invalid

type MenuOption =
    {
        id: string
        description: string
        operation: MenuOperation
    }

type Processor = 
    {
        id: int
        manufacturer: string
        model: string
        frequency: decimal
        coreCount: int
    }
