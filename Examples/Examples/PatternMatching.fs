module PatternMatching

let round x = 
    match x with
    | _ when x >= 100 -> 100
    | _ when  x < 0 -> 0
    | _ -> x
        
let tst = round(4)

printf "%i" tst

let moreComplexMatch (x, y) = 
    if x >= 100 || y >= 100 then 100, 100
    elif x < 0 || y < 0 then 0, 0
    else x, y