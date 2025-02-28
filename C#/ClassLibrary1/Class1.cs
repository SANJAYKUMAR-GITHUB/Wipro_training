using System;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void function1()
        {
            int result = 100, marks1 = 89, marks2 = 90;

            Assert.That(marks1, Is.Not.EqualTo(marks2));

            Assert.That(marks1, Is.LessThan(marks2));
        }
    }
}
