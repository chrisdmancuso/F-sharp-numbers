// Learn more about F# at http://fsharp.org

open System

printfn "Enter the size of the array \n"

let userInput = System.Console.ReadLine() //takes user input and converts to int. Then creates array of that size.
let userNumber = System.Int32.Parse(userInput)
let myArray = Array.create userNumber ""

for i in 0 .. myArray.Length - 1 do
    printfn "\n Enter integer values: \n"
    let arrayElements = System.Console.ReadLine()
    let intElements = System.Int32.Parse(arrayElements)
    Array.set myArray i (intElements.ToString())

printfn "\n\"%i\" is your array size \n" userNumber
printfn "\"%A\" is your array" (myArray.[0..])
printfn "\"%A\" is your %ith element" (myArray.[userNumber - 1]) (userNumber - 1)

System.Console.ReadKey() |> ignore
