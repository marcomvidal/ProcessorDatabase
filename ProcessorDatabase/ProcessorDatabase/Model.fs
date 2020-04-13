module Model

type MenuOption = 
    | Create
    | ShowSummary
    | Invalid

type Processor = 
    {
        manufacturer: string
        model: string
        frequency: decimal
        coreCount: int
    }
