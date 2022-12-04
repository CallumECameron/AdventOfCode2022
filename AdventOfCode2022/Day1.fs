namespace AdventOfCode2022

open System.IO
open Microsoft.FSharp.Collections

module Day1 =
    let splitBy f input =
        let i = ref 0
        input
        |> Seq.groupBy (fun x ->
            if f x then incr i
            !i)
        |> Seq.map snd

    let empty s =
        String.length s = 0

    let filterEmpty s =
        s |> Seq.where (fun x -> x |> empty |> not)

    let intSeq s =
        s
        |> filterEmpty
        |> Seq.map int

    let mostCalories s =
        s
        |> Seq.map intSeq
        |> Seq.map Seq.sum
        |> Seq.max

    let caloriesCariedByElfWithMostCalories fileName =
        fileName
        |> File.ReadLines
        |> splitBy empty
        |> mostCalories