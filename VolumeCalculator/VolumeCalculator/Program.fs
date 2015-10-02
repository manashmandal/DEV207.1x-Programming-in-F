// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

//Using System Namespace for Console I/O
open System

let rect_area h w = h * w // calculate area function
let cubic_volume h w b = (rect_area h w) * b // Calculate volume function which calls rect_area


[<EntryPoint>]
let main argv = 
    Console.Write("Enter Height: ") //Print out
    let h = Console.ReadLine() // Read a value
    let h = int h // Convert the value into integer
    
    Console.Write("Enter Width: ")
    let w = Console.ReadLine()
    let w = int w

    Console.Write("Enter Breadth: ")
    let b = Console.ReadLine()
    let b = int b

    let volume = cubic_volume h w b //Calling cubic_volume function

    Console.Write("Calculated Volume: ")
    printfn "%A" volume

    Console.ReadKey() // waiting to close until a key is pressed
    0 // return an integer exit code
