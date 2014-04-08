// https://www.hackerrank.com/challenges/fp-list-length

[<EntryPoint>]
let main args = 
  Seq.initInfinite (fun _ -> System.Console.ReadLine())
  |> Seq.takeWhile (fun s -> s <> null)
  |> Seq.map (fun _ -> 1)
  |> Seq.sum
  |> printfn "%i"
  0