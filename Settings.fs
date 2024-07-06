namespace OpilioCraft

open System

[<RequireQualifiedAccess>]
module Settings =
    [<Literal>]
    let SolutionIdentifier = "OpilioCraft"

    // location of app specific data
    let AppDataLocation = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), SolutionIdentifier)
