[<Allure.Xunit.Attributes.AllureEpic("Unit testing in F#")>]
[<Allure.Xunit.Attributes.AllureFeature([| "Single tests" |])>]
[<Allure.Xunit.Attributes.AllureStory([| "Unquote" |])>]
[<Allure.Xunit.Attributes.AllureSuite("Unquote")>]
[<Allure.Xunit.Attributes.AllureTag([| "Unquote" |])>]
[<Allure.Xunit.Attributes.AllureSeverity(Allure.Commons.SeverityLevel.normal)>]
[<Allure.Xunit.Attributes.AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")>]
module Tests

open Xunit
open Swensen.Unquote
open Allure.Commons
open Allure.Xunit.Attributes




[<AllureXunit>]
let ``My test`` () = Assert.True(true)

[<AllureXunit>]
let ``demo Unquote xUnit support`` () =
    test <@ [ 3; 2; 1; 0 ] |> List.map ((+) 1) = [ 1 + 3 .. 1 + 0 ] @>
