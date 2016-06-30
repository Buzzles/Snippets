module PatternMatching

let round x = 
    match x with
    | _ when x >= 100 -> 100
    | _ when  x < 0 -> 0
    | _ -> x
        
let tst = round(4)

printf "%i" tst

let testM1 x =
    match x with
    | h :: t -> printfn "First item %A" h
    | [] -> printfn "Empty list"

let typeMatch (t : obj) =
    match t with
    | :? string -> printfn "t is a string"
    | :? int -> printfn "t is an int"
    | _ -> printfn "unknown type"

let moreComplexMatch (x, y) = 
    if x >= 100 || y >= 100 then 100, 100
    elif x < 0 || y < 0 then 0, 0
    else x, y