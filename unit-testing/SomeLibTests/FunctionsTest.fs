module SomeLib


open NUnit.Framework
open FuncLib

[<Test>]
let FunctionsTest =
    let actualResult = FuncLib.factorial 3
    Assert.AreEqual 6 actualResult
