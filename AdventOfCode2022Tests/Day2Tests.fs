module Day2Tests

open System
open Xunit
open AdventOfCode2022.Day2

let examplePath = "Day2Example.txt"
    
[<Fact>]
let ``strategyScore of example`` () =
    let result = strategyScore examplePath
    Assert.Equal(15, result)