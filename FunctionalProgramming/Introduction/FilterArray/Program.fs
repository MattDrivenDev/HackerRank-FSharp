// https://www.hackerrank.com/challenges/fp-filter-array

[<EntryPoint>]
let main args = 
  let inputs = 
    Seq.initInfinite (fun _ -> System.Console.ReadLine())
    |> Seq.takeWhile (fun s -> s <> null)
    |> Seq.map int
    |> List.ofSeq
  List.filter (fun x -> x < (List.head inputs)) (List.tail inputs)
  |> List.iter (printfn "%i")
  0