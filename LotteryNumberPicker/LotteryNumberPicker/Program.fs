// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open LotteryNumberPicker
open System

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    
    let x = new NumberPicker(10, 6)
    let y = x.GetNumbers
    printfn "%A" <| Seq.toList y
    let a = Console.ReadKey(true)
    
    0 // return an integer exit