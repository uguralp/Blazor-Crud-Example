using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TestSamples
{
    [TestFixture]
    public class TestCases
    {
            public IWebDriver driver;
            public StringBuilder verificationErrors;
            public string baseURL;

        [SetUp]
            public void SetupTest()
            {
                driver = new FirefoxDriver();
                //If using the same URL several times
                baseURL = "http://localhost:1907/";
            }

            [TearDown]
            public void TeardownTest()
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }

            [TestCase]
            public void SpanShouldsayIncorrectValueforThePhoneNumber()
            {
            driver.Navigate().GoToUrl(baseURL);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.LinkText("Fetch user")));
            myDynamicElement.Click();
            driver.FindElement(By.LinkText("Fetch user")).Click();
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Phone Number'])[1]/following::input[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Phone Number'])[1]/following::input[1]")).Clear();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Phone Number'])[1]/following::input[1]")).SendKeys("11232");
        }

        [TestCase]
            public void SpanShouldsayIncorrectValueforTheEmail()
            {
                driver.Navigate().GoToUrl(baseURL);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.LinkText("Fetch user")));
            myDynamicElement.Click();
                driver.FindElement(By.LinkText("Create New")).Click();
                driver.FindElement(By.XPath("//input")).Click();
                driver.FindElement(By.XPath("//input")).Clear();
                driver.FindElement(By.XPath("//input")).SendKeys("212");
                driver.FindElement(By.XPath("//button[@type='submit']")).Click();

                string error = driver.FindElement(By.XPath("//div[2]/span")).Text;

                Assert.AreEqual(error, "Incorrect value!");
            }

            [TestCase]
            public void SpanShouldShowTheErrorForTheEmail()
            {
                driver.Navigate().GoToUrl(baseURL);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.LinkText("Fetch user")));
            myDynamicElement.Click();
            driver.FindElement(By.LinkText("Create New")).Click();
                driver.FindElement(By.XPath("//input")).Click();
                driver.FindElement(By.XPath("//input")).Clear();
                driver.FindElement(By.XPath("//input")).SendKeys("212");
                driver.FindElement(By.XPath("//button[@type='submit']")).Click();

                string error = driver.FindElement(By.XPath("//div[2]/span")).Text;

                Assert.AreEqual(error, "Incorrect value!");
            }

            [TestCase]
            public void NoErrorForTheFullname()
            {
                driver.Navigate().GoToUrl(baseURL);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.LinkText("Fetch user")));
            myDynamicElement.Click();
            driver.FindElement(By.LinkText("Create New")).Click();
                driver.FindElement(By.XPath("//input")).Click();
                driver.FindElement(By.XPath("//input")).Clear();
                driver.FindElement(By.XPath("//input")).SendKeys("Uguralp Onbasli");
                driver.FindElement(By.XPath("//button[@type='submit']")).Click();

                string error = driver.FindElement(By.XPath("//div/span")).Text;

                Assert.AreEqual(error, "");
            }

            [TestCase]
            public void NoErrorForTheEmail()
            {
            driver.Navigate().GoToUrl(baseURL);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.LinkText("Fetch user")));
            myDynamicElement.Click();
            driver.FindElement(By.LinkText("Create New")).Click();
                driver.FindElement(By.XPath("//input")).Click();
                driver.FindElement(By.XPath("//input")).Clear();
                driver.FindElement(By.XPath("//input")).SendKeys("Uonbasli@conestogac.on.ca");
                driver.FindElement(By.XPath("//button[@type='submit']")).Click();

                string error = driver.FindElement(By.XPath("//div[1]/span")).Text;
            ;

            Assert.AreEqual(error, "");
            }

        }

    }

