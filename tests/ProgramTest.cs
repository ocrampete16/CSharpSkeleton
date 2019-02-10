using CSharpSkeleton;
using NUnit.Framework;

namespace Tests
{
    public class ProgramTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            HelloWorld helloWorld = new CSharpSkeleton.HelloWorld();
            Assert.AreEqual("Hello Alice!", helloWorld.Greet("Alice"));
        }
    }
}