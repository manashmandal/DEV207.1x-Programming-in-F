//Immutable problem was solved

open System

let a = 100
let b = 1000


let f x y = x + y / 10

[<EntryPoint>]
let main argv = 
    let a = 101
    let z = f a b
    printfn "%A" z
    Console.ReadKey()
    0 // return an integer exit code
