namespace OpilioCraft

open System

[<RequireQualifiedAccess>]
module Settings =
    // location of app specific data
    let AppDataLocation = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "OpilioCraft")
