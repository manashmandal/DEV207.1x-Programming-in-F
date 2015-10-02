open System

let cylinder_volume (radius:float) (height:float) = 2.0 * 3.14 * Math.Pow(radius, 2.0) * height // V = 2 * PI * r^2 * h

[<EntryPoint>]
let main argv = 
    Console.Write("Enter radius: ")
    let rad = Console.ReadLine()
    let rad = float rad

    Console.Write("Enter height: ")
    let hei = Console.ReadLine()
    let hei = float hei

    let vol = cylinder_volume rad hei //Calculate the volume

    Console.WriteLine("Volume of the cylinder with radius {0} and height {1} is : {2}", rad, hei, vol) //Print out the volume

    Console.ReadKey()
    0 // return an integer exit code
