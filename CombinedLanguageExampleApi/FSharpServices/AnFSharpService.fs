namespace FSharpServices

type AnFSharpService() = 
    interface IFSharpService with
        member __.Doubler x =
            x * 2

////module AnFSharpService =

////    let hello name =
////        printfn "Hello %s" name
    
////    let doubler x =
////        x * x