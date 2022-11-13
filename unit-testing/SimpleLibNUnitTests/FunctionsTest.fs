open NUnit.Framework

type testData =

    static member factorialTestData() = //: IEnumerable<TestCaseData> =
        [ new TestCaseData(0, 1)
          new TestCaseData(1, 1)
          new TestCaseData(2, 2)
          new TestCaseData(3, 6)
          new TestCaseData(4, 24) ]

[<TestFixture>]
[<NUnit.Allure.Core.AllureNUnit>]
[<NUnit.Allure.Attributes.AllureSuite("NUnit")>]
module SimpleLibNUnitTests =


    open System
    open System.Collections.Generic
    open Allure.Net.Commons
    // open Allure.Commons
    open NUnit.Allure.Attributes
    open NUnit.Allure.Core
    open NUnit.Framework

    open type NUnit.Framework.Assert


    open SimpleLib

    // let factorialTestData () = //: IEnumerable<TestCaseData> =
    //     [ new TestCaseData(0, 1)
    //       new TestCaseData(1, 1)
    //       new TestCaseData(2, 2)
    //       new TestCaseData(3, 6)
    //       new TestCaseData(4, 24) ]


    [<Test>]
    [<AllureName("simple NUnit test")>]
    let someTest () =
        let n = 3
        AreEqual(n * n, FuncLib.square n)

    // [<TestFixture>]
    // [<AllureNUnit>]
    // [<AllureSuite("NUnit")>]
    // type testClass001() =

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
    [<TestCaseSource(typeof<testData>, nameof testData.factorialTestData)>]
    // [<TestCaseSource( nameof factorialTestData )>]
    // [<TestCaseSource(typeof SimpleLibNUnitTests, nameof factorialTestData )>]
    // [<Description("NUnit parameterized test")>]
    let factorialTest (number: int, expectedResult: int) =
        let actualResult = FuncLib.factorial number
        AreEqual(expectedResult, actualResult, $"Expected = {expectedResult}, actual = {actualResult}")
