// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using CICDArandaTestSelenium.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CICDArandaTestSelenium
{
    [TestFixture]
    public class TestClass: BaseClass
    {
        [Test, Category("Regression Testing")]
        public void TestMethod()
        {
            
            IWebElement nameTextField = driver.FindElement(By.XPath(".//*[@id='materialContactFormName']"));
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='materialContactFormEmail']"));
            IWebElement noteTextField = driver.FindElement(By.XPath(".//*[@id='materialContactFormMessage']"));
            
            nameTextField.SendKeys("Jhonattan Solarte");
            emailTextField.SendKeys("jhonattan.solarte@arandasoft.com");
            noteTextField.SendKeys("La vivienda social en México, es un tema polémico en donde intervienen sobre todo factores sociales, económicos y políticos. Pero al mismo tiempo es una condición materializada en donde se pueden observar elementos físicos a partir de los cuales se puede tener una discusión y se pueden tomar decisiones de diseño futuras. ");




            // TODO: Add your test code here
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }


        [Test, Category("Smoke Testing")]
        public void TestMethod2()
        {
            IWebElement nameTextField = driver.FindElement(By.XPath(".//*[@id='materialContactFormName']"));
            nameTextField.SendKeys("Aranda Software");
        }
    }
}
 