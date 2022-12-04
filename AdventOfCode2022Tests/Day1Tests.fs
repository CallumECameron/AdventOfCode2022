module Tests

open System
open Xunit
open AdventOfCode2022.Day1

[<Fact>]
let ``empty of zero length string is true`` () =
    "" |> empty |> Assert.True

[<Fact>]
let ``empty of nonzero length string is false`` () =
    "hi" |> empty |> Assert.False

[<Fact>]
let ``caloriesCariedByElfWithMostCalories of example is 24000`` () =
    let result = caloriesCariedByElfWithMostCalories "/Users/callumcameron/Repos/AdventOfCode2022/Day1/Example1.txt"
    Assert.Equal(result, 24000)