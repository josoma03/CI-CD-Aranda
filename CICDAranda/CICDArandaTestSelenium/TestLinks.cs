// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using CICDArandaTestSelenium.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace CICDArandaTestSelenium
{
    [TestFixture]
    public class TestLinks
    {

        [Test, Category("Smoke Testing")]
        [Author("Jhonattan Solarte", "jhonattan.solarte@arandasoft.com")]
        [Description("Validar links")]
        [TestCaseSource("DataDrivenTesting")]
        public void TestUrls(string url)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = url;
            driver.Quit();
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://cicdaranda.azurewebsites.net/");
            list.Add("https://cicdaranda.azurewebsites.net/counter");
            list.Add("https://cicdaranda.azurewebsites.net/fetchdata");
            return list;
        }
    }
}
 