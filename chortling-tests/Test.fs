﻿namespace chortling_tests
open System
open NUnit.Framework

[<TestFixture>]
type Test() = 

    [<Test>]
    member x.TestCase() =
        Assert.IsTrue(true)

