open System
open Microsoft.FSharp.Core
open Shapes
open testing
// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

    (* filename: hello.fs *)
let _ = printfn "Hello world"

let x = 5;
let y = 25;
let z = x*y;

let xx = printfn "Derp + z";
let xy = 
        printfn "Derp %u" z;

let mult x = x * x;

let xz = mult x

let printGeneric (foo: 'T when 'T :> Shape) =
    printfn "Typeof %A" <| foo.GetType().Name;
    printfn "Area %A" foo.Area;
    printfn "Perimeter %A" foo.Perimeter;

let typeMatch (t : obj) =
    match t with
    | :? String -> printfn "t is a string"
    | _ -> printfn "unknown type"

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    let foo1 = new Square(5);
    printGeneric(foo1);
    let foo2 = new Triangle(5,5);
    printGeneric(foo2);
    let fibOut = FibModule.squarer 3 4;
    printfn "%A" fibOut;
    printfn "Finished: Press any key to close.";
    let x = Console.ReadKey(true)
    0 // return an integer exit code
    