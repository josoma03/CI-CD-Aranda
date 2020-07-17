// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using CICDArandaTestSelenium.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace CICDArandaTestSelenium
{
    [TestFixture]
    public class TestClass: BaseClass
    {
        [Test, Category("Regression Testing")]
        [Author("Jhonattan Solarte", "jhonattan.solarte@arandasoft.com")]
        [Description("Validación de campos básicos")]
        public void TestMethod()
        {
            Thread.Sleep(1000);
            IWebElement nameTextField = driver.FindElement(By.XPath(".//*[@id='materialContactFormName']"));
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='materialContactFormEmail']"));

            nameTextField.SendKeys("Jhonattan Solarte");
            emailTextField.SendKeys("jhonattan.solarte@arandasoft.com");
            

            // TODO: Add your test code here
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }


        [Test, Category("Smoke Testing")]
        [Author("Jhonattan Solarte", "jhonattan.solarte@arandasoft.com")]
        [Description("Seleccionar combobox transporte por Index")]
        public void TestMethod2()
        {
            IWebElement cmbTransporte = driver.FindElement(By.XPath(".//*[@id='cmbTransporte']"));
            SelectElement element = new SelectElement(cmbTransporte);
            element.SelectByIndex(2);
        }

    }
}
 