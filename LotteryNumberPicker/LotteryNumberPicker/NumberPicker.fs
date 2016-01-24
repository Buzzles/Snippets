#light

module NumberPicker

type NumberPicker (maxRange, amountOfNumbers) =
    let numberRange = {1..maxRange}
    let rng = System.Random()
    member this.GetNumbers =
        let outarray =
            numberRange 
            |> Seq.map (fun value -> this.GetRandomWithRange(value) )     
            |> Seq.take amountOfNumbers
        outarray
    member this.GetRandomWithRange (x) =
        let r = rng.Next(1, maxRange)
        r