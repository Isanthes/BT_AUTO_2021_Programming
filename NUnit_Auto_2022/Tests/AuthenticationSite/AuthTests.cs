﻿using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM;
using NUnit_Auto_2022.PageModels.PageFactory;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{ 
    class AuthTests: BaseTest
    {
        string url = FrameworkConstants.GetUrl();
        
        //Test auth with Page Object Model
        [Test]
        public void BasicAuth()
        {
            driver.Navigate().GoToUrl(url + "login");
            PageModels.POM.LoginPage lp = new PageModels.POM.LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login("user1", "pass1");
        }

        //Test auth with Page Factory
        [Test]
        public void BasicAuthPF()
        {
            driver.Navigate().GoToUrl(url + "login");
            PageModels.PageFactory.LoginPage lp = new PageModels.PageFactory.LoginPage(driver);
            Assert.AreEqual("Authentication",lp.CheckPage());
            lp.Login("user1", "pass1");
        }


    }
}
