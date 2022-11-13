[<NUnit.Framework.TestFixture>]
[<NUnit.Allure.Core.AllureNUnit>]

[<NUnit.Allure.Attributes.AllureEpic("Unit testing in F#")>]
[<NUnit.Allure.Attributes.AllureFeature([| "Syntax tests" |])>]
[<NUnit.Allure.Attributes.AllureStory([| "Syntax" |])>]
[<NUnit.Allure.Attributes.AllureSuite("Syntax")>]
[<NUnit.Allure.Attributes.AllureTag([| "Syntax" |])>]
module NUnit.Samples.AssertSyntaxTests1

open System
open System.Collections
open NUnit.Allure.Attributes
open NUnit.Allure.Core
open NUnit.Framework
open NUnit.Framework.Constraints

/// <summary>
/// This test fixture attempts to exercise all the syntactic
/// variations of Assert without getting into failures, errors 
/// or corner cases. Thus, some of the tests may be duplicated 
/// in other fixtures.
/// 
/// Each test performs the same operations using the classic
/// syntax (if available) and the constraint syntax. The
/// inherited syntax is not used in this example, since it
/// would require using a class to hold the tests, which
/// seems to make it less useful in F#.
/// </summary>

[<Test>]
[<AllureName("Assert.IsNull")>]
let IsNull() =
    let nada : obj = null
    Assert.IsNull(nada)
    Assert.That(nada, Is.Null)

[<Test>]
[<AllureName("Assert.IsNotNull")>]
let IsNotNull() =
    Assert.IsNotNull(42)
    Assert.That(42, Is.Not.Null)

// [<NUnit.Framework.TestFixture>]
// [<NUnit.Allure.Core.AllureNUnit>]
//
// [<NUnit.Allure.Attributes.AllureEpic("Unit testing in F#")>]
// [<NUnit.Allure.Attributes.AllureFeature([| "NUnit tests" |])>]
// [<NUnit.Allure.Attributes.AllureStory([| "NUnit" |])>]
// [<NUnit.Allure.Attributes.AllureSuite("NUnit")>]
// [<NUnit.Allure.Attributes.AllureTag([| "NUnit" |])>]
// module SampleTests
//
// open System
// open System.Collections
// open NUnit.Allure.Attributes
// open NUnit.Allure.Core
// open NUnit.Framework
// open NUnit.Framework.Constraints

[<SetUp>]
let Setup () = ()

[<Test>]
[<AllureName("basic NUnit test")>]
let Test1 () = Assert.Pass()
