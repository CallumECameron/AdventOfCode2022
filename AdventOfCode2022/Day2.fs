namespace AdventOfCode2022

open System
open System.IO
open Microsoft.FSharp.Collections

module Day2 =
    let playScore (line : string) =
        match line with
        | text when text.EndsWith("X") -> 1
        | text when text.EndsWith("Y") -> 2
        | text when text.EndsWith("Z") -> 3
        | _ -> raise <| new ArgumentException()

    let resultScore line =
        match line with
        | "A X" -> 3
        | "A Y" -> 6
        | "A Z" -> 0
        | "B X" -> 0
        | "B Y" -> 3
        | "B Z" -> 6
        | "C X" -> 6
        | "C Y" -> 0
        | "C Z" -> 3
        | _ -> raise <| new ArgumentException()

    let roundScore (line : string) =
        playScore line + resultScore line

    let strategyScore file =
        file
        |> File.ReadLines
        |> Seq.map roundScore
        |> Seq.sum