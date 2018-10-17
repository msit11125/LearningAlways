using DotNetDesignPatternDemos.Creational.Builder.Coding.Exercise;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise.UnitTests
{
    // 1. 安裝NUnit 擴充功能
    // 2. NuGet 安裝NUnit
    [TestFixture]
    public class FirstTestSuite
    {
        private static string Preprocess(string s)
        {
            return s.Trim().Replace("\r\n", "\n");
        }

        [Test]
        public void EmptyTest()
        {
            var cb = new CodeBuilder("Foo");
            Assert.That(Preprocess(cb.ToString()), Is.EqualTo("public class Foo\n{\n}"));
        }

        [Test]
        public void PersonTest()
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Assert.That(Preprocess(cb.ToString()),
              Is.EqualTo(
                @"public class Person
{
  public string Name;
  public int Age;
}"
              ));
        }
    }
}
