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
    }
}
