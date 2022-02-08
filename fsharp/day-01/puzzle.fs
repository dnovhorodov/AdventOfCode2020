module AdventOfCode

(*
Find the two entries that sum to 2020 and then multiply those two numbers together.

For example, suppose your expense report contained the following:

1721
979
366
299
675
1456

In this list, the two entries that sum to 2020 are 1721 and 299. 
Multiplying them together produces 1721 * 299 = 514579, so the correct answer is 514579.
*)

open Utils

module DayOne = 

    let rec twoSum sum numbers = 
        match numbers with
        | hd::tl when hd < sum ->
            let sumOfTwo = 
                List.map (fun el -> (hd, el)) tl
                |> List.tryFind (fun (hd,el) -> (hd+el)=sum)
            match sumOfTwo with
            | Some (hd,el) -> [hd;el]
            | _ -> twoSum sum tl
        | _ -> []

    let sumUpTo2020 numbers = twoSum 2020 numbers

    let solveExample filePath = 
        readFile filePath 
        |> Result.map (convertTo int)
        |> Result.map List.ofSeq
        |> function
        | Ok numbers -> sumUpTo2020 numbers
        | _ -> []