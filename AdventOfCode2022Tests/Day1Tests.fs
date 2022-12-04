module Tests

open System
open Xunit
open AdventOfCode2022.Day1

let examplePath = "/Users/callumcameron/Repos/AdventOfCode2022/Day1/Example1.txt"

[<Fact>]
let ``empty of zero length string is true`` () =
    "" |> empty |> Assert.True

[<Fact>]
let ``empty of nonzero length string is false`` () =
    "hi" |> empty |> Assert.False

[<Fact>]
let ``caloriesCarriedByElfWithMostCalories of example is 24000`` () =
    let result = caloriesCarriedByElfWithMostCalories examplePath
    Assert.Equal(24000, result)
    
[<Fact>]
let ``caloriesCarriedByTopThreeElves of example`` () =
    let result = caloriesCarriedByTopThreeElves examplePath
    Assert.Equal(45000, result)