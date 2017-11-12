using System;
using System.Linq;
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
            Assert.AreEqual("It's Evil!", actual);
        }

        [TestMethod]
        public void Input_1_Should_Be_ItsOdious()
        {
            var actual = EvilOrOdious.Evil(1);
            Assert.AreEqual("It's Odious!", actual);
        }
    }

    public class EvilOrOdious
    {
        public static string Evil(int n)
        {
            return Convert.ToString(n, 2).Count(x => x == 1) % 2 == 0 ? "It's Evil!": "It's Odious!";
        }
    }
}
