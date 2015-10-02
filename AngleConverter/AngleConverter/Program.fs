//A F# Program for angle conversion [degree <-> radian]

open System

//F# Hands on assesment 1
//Convert 67 in radian

let deg2rad (deg:float) = (deg * 3.14) / 180.0
let rad2deg (rad:float) = (rad * 180.0) / 3.14


[<EntryPoint>]
let main argv = 
    let radian = deg2rad 67.0
    Console.Write("67.0 Degree in radian: {0}", radian)
    Console.ReadKey()
    0 // return an integer exit code
