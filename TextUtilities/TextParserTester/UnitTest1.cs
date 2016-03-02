using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextUtilities;
using FluentAssertions;

namespace TextUtilitiesTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TextParser_Parse_NullArg()
        {
            var parser = new Parser();
            Action action = () => parser.Parse(null);
            action.ShouldThrow<NullReferenceException>();
        }
    }
}
