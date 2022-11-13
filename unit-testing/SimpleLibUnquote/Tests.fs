module Tests

open Xunit
open Swensen.Unquote
open Allure.Commons
open Allure.Xunit.Attributes

[<AllureEpic("Unit testing in F#")>]
[<AllureFeature([| "Single tests" |])>]
[<AllureStory([| "Unquote" |])>]
[<AllureSuite("Unquote")>]
[<AllureTag([| "Unquote" |])>]
[<AllureSeverity(SeverityLevel.normal)>]
[<AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")>]


[<AllureXunit>]
let ``My test`` () = Assert.True(true)

[<AllureXunit>]
let ``demo Unquote xUnit support`` () =
    test <@ [ 3; 2; 1; 0 ] |> List.map ((+) 1) = [ 1 + 3 .. 1 + 0 ] @>
