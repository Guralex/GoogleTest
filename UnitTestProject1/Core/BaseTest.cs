using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using UnitTestProject1.Pages;


public class BaseTest
    {
    public static IWebDriver driver;
    public GooglePage googlePage;

        [OneTimeSetUp]
        public void start()
        {
            driver = new ChromeDriver();
        driver.Manage().Window.Maximize();


    }

    [OneTimeTearDown]
        public void finish()
        {
            driver.Close();
        }

    }
