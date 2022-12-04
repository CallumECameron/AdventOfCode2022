namespace AdventOfCode2022

open System
open System.IO
open Microsoft.FSharp.Collections

module Day2 =
    let playScore1 (line : string) =
        match line with
        | text when text.EndsWith("X") -> 1
        | text when text.EndsWith("Y") -> 2
        | text when text.EndsWith("Z") -> 3
        | _ -> raise <| new ArgumentException()

    let resultScore1 line =
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

    let roundScore1 (line : string) =
        playScore1 line + resultScore1 line

    let strategyScore1 file =
        file
        |> File.ReadLines
        |> Seq.map roundScore1
        |> Seq.sum
        
        
    let playScore2 line =
        match line with
        | "A X" -> 3
        | "A Y" -> 1
        | "A Z" -> 2
        | "B X" -> 1
        | "B Y" -> 2
        | "B Z" -> 3
        | "C X" -> 2
        | "C Y" -> 3
        | "C Z" -> 1
        | _ -> raise <| new ArgumentException()

    let resultScore2 (line : string) =
        match line with
        | text when text.EndsWith("X") -> 0
        | text when text.EndsWith("Y") -> 3
        | text when text.EndsWith("Z") -> 6
        | _ -> raise <| new ArgumentException()

    let roundScore2 (line : string) =
        playScore2 line + resultScore2 line

    let strategyScore2 file =
        file
        |> File.ReadLines
        |> Seq.map roundScore2
        |> Seq.sum