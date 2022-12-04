module Day1Tests

open System
open Xunit
open AdventOfCode2022.Day1

let exampleFile = "Day1Example.txt"

[<Fact>]
let ``empty of zero length string is true`` () =
    "" |> empty |> Assert.True

[<Fact>]
let ``empty of nonzero length string is false`` () =
    "hi" |> empty |> Assert.False

[<Fact>]
let ``caloriesCarriedByElfWithMostCalories of example is 24000`` () =
    let result = caloriesCarriedByElfWithMostCalories exampleFile
    Assert.Equal(24000, result)
    
[<Fact>]
let ``caloriesCarriedByTopThreeElves of example`` () =
    let result = caloriesCarriedByTopThreeElves exampleFile
    Assert.Equal(45000, result)