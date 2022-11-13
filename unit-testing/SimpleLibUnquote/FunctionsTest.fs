module SimpleLibUnquoteTests



open System.Collections.Generic
open Allure.Commons



open Allure.Xunit.Attributes
open Swensen.Unquote
open Xunit

open type Xunit.Assert
open SimpleLib

[<AllureXunit>]
let squareTest =
    let n = 3
    // Equal(n * n, FuncLib.square n)
    test <@ n * n = FuncLib.square n @>



let factorialXunitTestData () : IEnumerable<(obj)[]> =
    [ [| 0; 1 |]
      [| 1; 1 |]
      [| 2; 2 |]
      [| 3; 6 |]
      [| 4; 24 |] ]


[<AllureEpic("Unit testing in F#")>]
[<AllureFeature([| "Parameterized tests" |])>]
[<AllureStory([| "Unquote" |])>]
[<AllureSuite("Unquote")>]
[<AllureTag([| "Unquote" |])>]
[<AllureSeverity(SeverityLevel.normal)>]
[<AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")>]



[<AllureXunitTheory>]
[<MemberData(nameof (factorialXunitTestData))>]
let factorialTest (number: int, expectedResult: int) =
    let actualResult = FuncLib.factorial number
    test <@ expectedResult = actualResult @>
