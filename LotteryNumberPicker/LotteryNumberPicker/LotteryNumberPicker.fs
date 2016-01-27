#light

namespace LotteryNumberPicker

type NumberPicker (maxRange, amountOfNumbers) =
    let numberRange = {1..maxRange}
    let rng = System.Random()
    let GetRandomWithRange (x) =
        let r = rng.Next(1, maxRange)
        r
    member this.GetNumbers =
        let outarray =
            numberRange 
            |> Seq.map (fun value -> GetRandomWithRange(value) )  // essentially linq x => GetRandomWithRange(x)
            |> Seq.take amountOfNumbers
        outarray    
