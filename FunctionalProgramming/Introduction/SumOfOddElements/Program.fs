// https://www.hackerrank.com/challenges/fp-sum-of-odd-elements

open System

let readInputs() = 
  Seq.initInfinite (fun _ -> System.Console.ReadLine())
  |> Seq.takeWhile (fun s -> s <> null)

[<EntryPoint>]
let main args = 
  readInputs()
  |> Seq.map int
  |> Seq.filter (fun i -> i % 2 <> 0)
  |> Seq.sum
  |> printfn "%i"
  0