(*module SimpleLibMsTests


open System
open System.Collections.Generic
open Allure.Net.Commons
open Microsoft.VisualStudio.TestTools.UnitTesting
open Allure.Commons
open SimpleLib
open type Microsoft.VisualStudio.TestTools.UnitTesting.Assert


// xUnit
let factorialXunitTestData () : IEnumerable<(obj)[]> =
    [ [| 0; 1 |]
      [| 1; 1 |]
      [| 2; 2 |]
      [| 3; 6 |]
      [| 4; 24 |] ]


[<AllureEpic("Unit testing in F#")>]
[<AllureFeature([| "Parameterized tests" |])>]
[<AllureStory([| "MsTest" |])>]
[<AllureSuite("MsTest")>]
[<AllureTag([| "MsTest" |])>]
[<AllureSeverity(SeverityLevel.normal)>]
[<AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")>]
[<AllureId(123)>]
[<AllureName("test0001 MsTest")>]

// // NUnit
// [<Test>]
// [<TestCaseSource("factorialTestData")>]
//
// // xUnit
// [<AllureXunitTheory>]
// [<MemberData(nameof (factorialXunitTestData))>]


let factorialTest (number: int, expectedResult: int) =
    let actualResult = FuncLib.factorial number
    Equals(expectedResult, actualResult)
*)