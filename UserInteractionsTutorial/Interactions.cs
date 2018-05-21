using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace UserInteractionsTutorial
{

    [TestFixture]

    public class InteractionDemo
    {

        [Test]

        public void Example1()
        {
            var driver = new FirefoxDriver();
            Actions action = new Actions(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(6));

            driver.Navigate().GoToUrl("http://jqueryui.com/droppable/");
            wait.Until(ExpectedConditions.)

        }





    }










}