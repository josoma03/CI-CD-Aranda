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
        [Author("Jhonattan Solarte", "jhonattan.solarte@arandasoft.com")]
        [Description("Siempre Pass")]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test, Category("Unit")]
        [Author("Jhonattan Solarte", "jhonattan.solarte@arandasoft.com")]
        [Description("Validacion de Edad")]
        public void Test2() 
        {
            int age = 40;
            Assert.That(age, Is.LessThan(50), "Edad mayor a 50");
        }
    }
}