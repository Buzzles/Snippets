module Lists

open FSharp.Collections

let l1 = [1; 2; 3]
let l2 = [4; 5]

let conExample =
    0 :: l1

let appendExample =
    l1 @ l2

// Iter example
let nop x : unit = 
    x |> ignore
    
let woo li =
    List.iter (fun x -> nop x) li

// .map example

