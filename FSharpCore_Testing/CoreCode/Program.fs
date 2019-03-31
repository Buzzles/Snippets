// Learn more about F# at http://fsharp.org

open System
open Patterns

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let x = Console.ReadKey(true)
    printfn "Passing x: %A:" x
    let y = (x) |> PatternMatching.BasicTypeMatch

    Console.ReadKey(true) |> ignore
    0 // return an integer exit code
