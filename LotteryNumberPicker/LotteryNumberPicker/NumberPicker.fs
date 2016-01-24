#light

module NumberPicker

type NumberPicker (maxRange, amountOfNumbers) =
    let numberRange = {1..maxRange}
    member s.GetNumbers =
        let outarray =
            numberRange 
            |> Seq.map (fun values -> s.GetRandomWithRange(values) )     
            |> Seq.take amountOfNumbers
        outarray
    member s.GetRandomWithRange (x) =
        let rng = System.Random()
        let r = rng.Next(1, maxRange)
        r