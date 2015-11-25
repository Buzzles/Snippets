module Test
open System
open Microsoft.FSharp.Core
open Shapes

let printGeneric (foo: 'T when 'T :> Shape) =
    printfn "Typeof %A" <| foo.GetType().Name;
    printfn "Area %A" foo.Area;
    printfn "Perimeter %A" foo.Perimeter;

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    let foo1 = new Square(5);
    printGeneric(foo1);
    let foo2 = new Triangle(5,5);
    printGeneric(foo2);
    printfn "Finished: Press any key to close.";
    let x = Console.ReadKey(true)
    0 // return an integer exit code