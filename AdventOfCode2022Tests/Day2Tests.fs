module Day2Tests

open System
open Xunit
open AdventOfCode2022.Day2

let examplePath = "Day2Example.txt"
    
[<Fact>]
let ``strategyScore1 of example`` () =
    let result = strategyScore1 examplePath
    Assert.Equal(15, result)

[<Fact>]
let ``strategyScore2 of example`` () =
    let result = strategyScore2 examplePath
    Assert.Equal(12, result)