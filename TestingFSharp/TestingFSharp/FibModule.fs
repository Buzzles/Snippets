namespace testing

module FibModule = 

    let testModuleValue = 4;

    let squarer (par1:int) (par2:int) :int = 
        let x = par1 * par2;
        x

    let rec fibber fib1 =
        if fib1 = 0 then 0
        else if fib1 = 1 then 1
        else
        fibber(fib1-1) + fibber(fib1-2)
