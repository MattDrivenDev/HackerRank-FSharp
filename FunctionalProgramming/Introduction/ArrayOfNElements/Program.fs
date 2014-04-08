// https://www.hackerrank.com/challenges/fp-array-of-n-elements

open System

let readInput() = Console.ReadLine()

[<EntryPoint>]
let main argv = 
  let n = readInput() |> int
  seq { for i in 1..n do yield i }
  |> Seq.fold (fun s i ->
    if s = "" then sprintf "%i" i
    else sprintf "%s, %i" s i) ""
  |> (fun s -> sprintf "[%s]" s)
  |> Console.WriteLine
  0 // return an integer exit code

// This test case is broken on HackerRank at the moment.
// https://www.hackerrank.com/challenges/fp-array-of-n-elements/forum/questions/5274