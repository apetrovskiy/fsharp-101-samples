[<NUnit.Framework.TestFixture>]
[<NUnit.Allure.Core.AllureNUnit>]

[<NUnit.Allure.Attributes.AllureEpic("Unit testing in F#")>]
[<NUnit.Allure.Attributes.AllureFeature([| "NUnit tests" |])>]
[<NUnit.Allure.Attributes.AllureStory([| "NUnit" |])>]
[<NUnit.Allure.Attributes.AllureSuite("NUnit")>]
[<NUnit.Allure.Attributes.AllureTag([| "NUnit" |])>]

// these two do not work)
// module NUnit.Samples.AssertSyntaxTests2
// module SimpleLibNUnitTests2
module NUnit.Samples.SimpleLibNUnitTests

open System
open System.Collections
open NUnit.Allure.Attributes
open NUnit.Allure.Core
open NUnit.Framework
open NUnit.Framework.Constraints

open type NUnit.Framework.Assert
open SimpleLib


let factorialTestData () = //: IEnumerable<TestCaseData> =
    [ new TestCaseData(0, 1)
      new TestCaseData(1, 1)
      new TestCaseData(2, 2)
      new TestCaseData(3, 6)
      new TestCaseData(4, 24) ]




[<Test>]
[<AllureName("simple NUnit test")>]
let someTest () =
    let n = 3
    AreEqual(n * n, FuncLib.square n)

[<Test>]
let oneMoreTest () = Assert.AreEqual(1, 1)

[<AllureEpic("Unit testing in F#")>]
[<AllureFeature([| "Parameterized tests" |])>]
[<AllureStory([| "NUnit" |])>]

[<AllureTag([| "NUnit" |])>]
// [<AllureSeverity(SeverityLevel.normal)>]
[<AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")>]
// [<AllureId(123)>]
[<AllureName("test0001 NUnit")>]


// [<Test>]
// [<TestCaseSource(typeof< testClass001>, "factorialTestData" )>]
// [<TestCaseSource("factorialTestData")>]
// [<TestCaseSource(typeof< testData>, "factorialTestData" )>]
// [<TestCaseSource(typeof<testData>, nameof testData.factorialTestData)>]
[<TestCaseSource(nameof factorialTestData)>]
// [<TestCaseSource(typeof SimpleLibNUnitTests, nameof factorialTestData )>]
[<Description("NUnit parameterized test")>]
let factorialTest (number: int, expectedResult: int) =
    let actualResult = FuncLib.factorial number
    AreEqual(expectedResult, actualResult, $"Expected = {expectedResult}, actual = {actualResult}")
