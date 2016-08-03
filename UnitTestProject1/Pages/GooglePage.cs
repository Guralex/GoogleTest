using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;


namespace UnitTestProject1.Pages
{
   public class GooglePage
    {
      private static  GooglePage page;

        public static GooglePage GetGooglePage(IWebDriver driver)
        {
            page = new GooglePage();
           PageFactory.InitElements(driver, page);

            return page;
        }

        public const String INPUT = "q";
        public const String BUTTON = "btnG";
        public const String RESULTS = "resultStats";

        [FindsBy(How=How.Name, Using =INPUT)]
        public IWebElement googleInput;

        [FindsBy(How = How.Name, Using = BUTTON)]
        public IWebElement googleSearchButton;

        [FindsBy(How = How.Id, Using = RESULTS)]
        public IWebElement googleResultStat;

        public void performSearch(String text)
        {
            googleInput.SendKeys(text);
            googleSearchButton.Click();
        }

        public void checkResult()
        {
            Assert.IsTrue(googleResultStat.Displayed);
        }

    }
}
