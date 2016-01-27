namespace LotteryNumberPicker

open System.Collections.Generic

type NumberPicker2 (maxRange, amountOfNumbers) =
    let mutable numberRange = {1..maxRange}
    let results = [1..amountOfNumbers]
    let rng = System.Random()
    let GetRnd =
        let r = rng.Next(1, Seq.last numberRange)
        r
    let JumbleList = 
    // Apply Fisher-Yates shuffle / Knuth shuffle (start at 0, generate a random k less than current length, move to index of k, add number to new list and remove from old, repeat.
        numberRange  
    let GetRandomWithRange (x) =
        let r = rng.Next(1, Seq.last numberRange)
        let b = new List<int>(results)
        let c = b.Remove(x); 
    //  let newResults = results |> Seq.choose  (fun value -> match value with value.Equals(r) == true)
        r
    member this.GetNumbers =
        let outarray =
            numberRange 
            |> Seq.map (fun value -> GetRandomWithRange(value) )
            |> Seq.take amountOfNumbers
        outarray