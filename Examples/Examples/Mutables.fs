module Mutables

// Imperative Support

// Non mutable, as it's function. In C# it's like: static int y() { return 1; }, not quite a getter.
//let y = 1
//y <= 2

// Define 'x' with initial value '1'
let mutable x = 1
// Change the value of 'x' to '3'
x <- 3