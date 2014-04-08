// https://www.hackerrank.com/challenges/fp-hello-world-n-times

open System

let readInput() = Console.ReadLine()

[<EntryPoint>]
let main argv = 
    let n = readInput() |> int
    seq { for i in 1..n do yield "Hello World" }
    |> Seq.iter (printfn "%s")
    0 // return an integer exit code