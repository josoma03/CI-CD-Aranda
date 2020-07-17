using NUnit.Framework;

namespace CICDArandaTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, Category("Unit")]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test, Category("Unit")]
        public void Test2() 
        {
            int age = 40;
            Assert.That(age, Is.LessThan(50), "Edad mayor a 50");
        }
    }
}