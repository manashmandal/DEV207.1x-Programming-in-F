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
    let mutable checkval = true
    let mutable i = 0

    while checkval do
        printfn "%A" (checknum i)
        i <- i + 1
        if i = check then 
            checkval <- false


    Console.ReadKey();
    0