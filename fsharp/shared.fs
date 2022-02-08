module Utils

open System.IO

let readFile filePath = 
    try
        seq { 
            use reader = new StreamReader(File.OpenRead(filePath))
            while not reader.EndOfStream do
                yield reader.ReadLine()
        } |> Ok
    with
    | ex -> Error ex

let convertTo f data = Seq.map f data
