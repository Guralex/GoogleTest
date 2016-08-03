using System;
using NUnit.Framework;
using UnitTestProject1.Pages;




[TestFixture]
    public class UnitTest1: BaseTest
    {

    [OneTimeSetUp]
    public void componentSetUp()
    {
        googlePage = GooglePage.GetGooglePage(driver);
    }
       
        [Test]
        public void test()
        {
        driver.Navigate().GoToUrl("http://www.google.com");
        googlePage.performSearch("Vasya");
        System.Threading.Thread.Sleep(5000);
        googlePage.checkResult();
    }

}

