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

    let caloriesPerElf s =
        s
        |> Seq.map intSeq
        |> Seq.map Seq.sum

    let mostCalories s =
        s
        |> caloriesPerElf
        |> Seq.max

    let sumCaloriesTop n s =
        s
        |> caloriesPerElf
        |> Seq.sortDescending
        |> Seq.take n
        |> Seq.sum

    let paragraphs fileName =
        fileName
        |> File.ReadLines
        |> splitBy empty

    let caloriesCarriedByElfWithMostCalories fileName =
        fileName
        |> paragraphs
        |> mostCalories
        
    let caloriesCarriedByTopThreeElves fileName =
        fileName
        |> paragraphs
        |> sumCaloriesTop 3