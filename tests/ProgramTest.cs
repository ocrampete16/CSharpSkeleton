using CSharpSkeleton;
using NUnit.Framework;

namespace Tests
{
    public class ProgramTest
    {
        [Test]
        public void Test1()
        {
            HelloWorld helloWorld = new CSharpSkeleton.HelloWorld();
            Assert.AreEqual("Hello Alice!", helloWorld.Greet("Alice"));
        }
    }
}
