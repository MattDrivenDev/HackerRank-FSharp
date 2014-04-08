// https://www.hackerrank.com/challenges/fp-update-list

[<EntryPoint>]
let main args = 
  let negate n = if n < 0 then -n else n
  Seq.initInfinite (fun _ -> System.Console.ReadLine())
  |> Seq.takeWhile (fun s -> s <> null)
  |> Seq.map (int >> negate)
  |> Seq.iter (printfn "%i")
  0