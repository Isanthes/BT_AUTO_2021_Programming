using NUnit.Framework;
using NUnit_Auto_2022.PageModels.PMO;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{ 
    class AuthTests
    {

        IWebDriver driver;
        string url = FrameworkConstants.GetUrl();

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void BasicAuth()
        {
            driver.Navigate().GoToUrl(url + "login");
            LoginPage lp = new LoginPage(driver);
            Assert.AreEqual("Authentication", lp.ChackPage());
            lp.Login("user1", "pass1");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
