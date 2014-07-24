using System;
using NUnit.Framework;

namespace Sample.Test.unit
{
    [TestFixture]
    public class TargetTest
    {
        [Test]
        public void AddoneTest()
        {
            const int expected = 2;
            var actual = Target.AddOne(1);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void MethodWithBranchingTest_1()
        {
            const int expected = 1;
            var actual = Target.MethodWithBranching(1);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void MethodWithBranchingTest_Exception()
        {
            Assert.Throws(
                typeof (ArgumentOutOfRangeException),
                () => Target.MethodWithBranching(1000));
        }
    }
}
