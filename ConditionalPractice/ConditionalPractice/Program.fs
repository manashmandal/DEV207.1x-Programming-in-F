// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

let checknum v = 
    if v = 5 then
        "I am 5"
    elif v < 5 then
        "I am less than 5"
    else 
        "I am another number"
     

[<EntryPoint>]
let main argv = 
    let check = Console.ReadLine()
    let check = int check
    printfn "%A" (checknum check)
    Console.ReadKey();
    0