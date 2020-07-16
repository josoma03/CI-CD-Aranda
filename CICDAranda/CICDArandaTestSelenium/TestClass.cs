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
            
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Aranda Software");
            

            // TODO: Add your test code here
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }


        [Test, Category("Smoke Testing")]
        public void TestMethod2()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Aranda Software");
        }
    }
}
 