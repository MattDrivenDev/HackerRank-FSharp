// https://www.hackerrank.com/challenges/fp-reverse-a-list

open System

let readInputs() = 
  Seq.initInfinite (fun _ -> Console.ReadLine())
  |> Seq.takeWhile (fun s -> s <> null)

[<EntryPoint>]
let main argv = 
    readInputs()
    |> List.ofSeq
    |> List.fold (fun xs x -> x :: xs) []
    |> Seq.iter (printfn "%s")
    0 // return an integer exit code