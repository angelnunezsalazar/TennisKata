using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Tennis.Features.StepDefinitions
{
    [Binding]
    public sealed class CommonSteps
    {
        static IWebDriver driver;

        [BeforeFeature]
        public static void BeforeFeature()
        {
            driver = new FirefoxDriver();
        }

        [AfterFeature]
        public static void AfterFeature() {
            driver.Quit();
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            driver.Url = "http://www.google.com";
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            driver.FindElement(By.Name("q")).SendKeys("cats");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            
        }

    }
}
