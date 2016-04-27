using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DistanceLib
{
    [TestFixture]
    public class Calculator_Tests
    {
        [TestCase("abc", "abc", 0.0)]
        [TestCase("abc", "abx", 1.0/3.0)]
        [TestCase("abc", "abz", 2.0/3.0)]
        [TestCase("abc", "abe", 2.0/3.0)]
        [TestCase("abc", "xyz", 7.0/3.0)]
        [TestCase("abc123", "abc1234", 7.0)]
        public void strings_match(string a, string b, double expected)
        {
            Assert.That(new Calculator().distance(a, b), Is.EqualTo(expected));
        }
    }
}
