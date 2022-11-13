[<NUnit.Framework.TestFixture>]
[<NUnit.Allure.Core.AllureNUnit>]
module SampleTests

open NUnit.Allure.Attributes
open NUnit.Allure.Core
open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
[<AllureName("basic NUnit test")>]
let Test1 () =
    Assert.Pass()
