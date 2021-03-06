﻿using NUnit.Framework;

namespace Shouldly.Tests.Strings.ShouldNotStartWith
{
    public class ShouldIgnoreCaseByDefault
    {
        [Test]
        public void Test()
        {
            TestHelpers.Should.Error(()=>
            "Cheese".ShouldNotStartWith("CH"),
            "\"Cheese\" should not start with \"CH\" but was \"Cheese\"");
        }
    }
}