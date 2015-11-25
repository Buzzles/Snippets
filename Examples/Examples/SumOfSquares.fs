module SumOfSquares

let sqr x = x * x  // let === most important keyword

// C# style
let sumOfSquarsI nums =
    let mutable acc = 0.0
    for x in nums do
        acc <- acc + sqr x
    acc

// Math style with recursion (acceptable, but recusive) 
let rec sumOfSquaresF nums = 
    match nums with // Branching / switch on steroids + binding
    | [] -> 0.0
    | h::t -> sqr h + sumOfSquaresF t  // list binding h::t head and tail of list, so can be referred

// Proper F# way - Written in the way you'd say it. Take sequence, square each element, then sum the squared numbers
let sumOfSquares nums = 
    nums
    |> Seq.map sqr   // Pipeline, bit like linq. Takes left, uses on right.
    |> Seq.sum