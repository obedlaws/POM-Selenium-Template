using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.DefaultWaitHelpers;

using csharp.pages;

namespace csharp.tests;

public class Tests : DriverHelper
{
    string SITE = "https://www.google.com/";

    // Initialize Pages

    HomePage home = new HomePage();
    ResultPage results = new ResultPage();


    [SetUp]
    public void Setup()
    {
        var options = new ChromeOptions();
        options.AddArgument("--headless");
        Driver = new ChromeDriver(options);

        Driver.Navigate().GoToUrl(SITE);
    }

    [Test, Order(1)]
    public void HomeSmokeTest()
    {

        Assert.That(Driver.Title, Is.EqualTo("Google"));

    }


    [Test, Order(2)]
    public void SearchResultTest()
    {   


        Driver.WaitUntil(ExpectedConditionsSearchContext.ElementExists(By.XPath(home.inputPath)));
        home.InputSearchBar(Driver, "Macroblank");
        home.ClickSearchButton(Driver);

        var res = Driver.FindElement(By.XPath(results.resultOnePath)).Text;

        Assert.That(res, Is.EqualTo("Macroblank: Music"));

    }

    [TearDown]
    public void TearDown()
    {

        Driver.Quit();

    }
}