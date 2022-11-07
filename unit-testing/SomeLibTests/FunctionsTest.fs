module SomeLib

open Functions

[<Test>]
let FunctionsTest =
    let actualResult = factorial 3
    Assert.Equal 6, actualResult, "Result is wrong"
