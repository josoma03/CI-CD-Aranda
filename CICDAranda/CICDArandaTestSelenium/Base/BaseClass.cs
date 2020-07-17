using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDArandaTestSelenium.Base
{
    public class BaseClass
    {
        public IWebDriver driver;
        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Url = "https://cicdaranda.azurewebsites.net/";
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
