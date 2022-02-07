using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.PageModels.PageFactory
{
    public class LoginPage
    {


        IWebDriver driver;

        //page elements that are found automatically once the class is instantiated and page is loaded
        private IWebElement authPageTextElem => driver.FindElement(By.ClassName("text-muted"));
        private IWebElement usernameInputElem => driver.FindElement(By.Id("input-login-username"));
        private IWebElement usernameLabelElem => driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > label"));
        private IWebElement usernameErrorElem => driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"));
        private IWebElement asswordLabelElem => driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > label"));
        private IWebElement passwordInputElem => driver.FindElement(By.Id("input-login-password"));
        private IWebElement asswordErrorElem => driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"));
        private IWebElement submitButtonElem => driver.FindElement(By.ClassName("btn-primary"));

        //Login page Constructor that initializes the driver
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //returns the text that appears on the Auth page to be checked inthe test
        public string CheckPage()
        {
            return authPageTextElem.Text;
        }

        //login page with username and password passed from test
        public void Login (string user, string pass)
        {
            usernameInputElem.Clear();
            usernameInputElem.SendKeys(user);
            passwordInputElem.Clear();
            passwordInputElem.SendKeys(pass);
            submitButtonElem.Submit();

        }
    }

}
