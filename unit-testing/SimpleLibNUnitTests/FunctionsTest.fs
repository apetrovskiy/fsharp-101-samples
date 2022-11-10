[<NUnit.Framework.TestFixture>]
module SimpleLibNUnitTests


open System
open System.Collections.Generic
// open Allure.Net.Commons
open Allure.Commons
open NUnit.Allure.Attributes
open NUnit.Allure.Core
open NUnit.Framework

open type NUnit.Framework.Assert


open SimpleLib



let factorialTestData () : IEnumerable<TestCaseData> =
    [ new TestCaseData(0, 1)
      new TestCaseData(1, 1)
      new TestCaseData(2, 2)
      new TestCaseData(3, 6)
      new TestCaseData(4, 24) ]



[<AllureEpic("Unit testing in F#")>]
[<AllureFeature([| "Parameterized tests" |])>]
[<AllureStory([| "NUnit" |])>]
[<AllureSuite("NUnit")>]
[<AllureTag([| "NUnit"; |])>]
// [<AllureSeverity(SeverityLevel.normal)>]
[<AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")>]
// [<AllureId(123)>]
[<AllureName("test0001 NUnit")>]

[<Test>]
[<TestCaseSource("factorialTestData")>]
let factorialTest (number: int, expectedResult: int) =
    let actualResult = FuncLib.factorial number
    AreEqual(expectedResult, actualResult, $"Expected = {expectedResult}, actual = {actualResult}")
