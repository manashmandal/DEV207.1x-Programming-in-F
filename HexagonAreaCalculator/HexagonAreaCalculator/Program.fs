//Calculates area of a hexagon

open System
let hexarea t:float = (3.0 * Math.Sqrt(3.0) / 2.0) * Math.Pow(t, 2.0)


[<EntryPoint>]
let main argv = 
    let value = Console.ReadLine()
    let f = float value

    //Execute Calc
    let calc = hexarea f

    printf "%f" calc

    Console.ReadKey()
    0 // return an integer exit code
