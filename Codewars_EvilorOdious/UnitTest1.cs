using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_EvilorOdious
{
    [TestClass]
    public class EvilOrOdiousTests
    {
        [TestMethod]
        public void Input_0_Should_Be_ItsEvil()
        {
            var actual = EvilOrOdious.Evil(0);
            Assert.AreEqual("It's Evil!",actual);
        }
    }

    public class EvilOrOdious
    {
        public static string Evil(int i)
        {
            throw new NotImplementedException();
        }
    }
}
