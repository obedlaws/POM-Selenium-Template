using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.DefaultWaitHelpers;
using System;

namespace csharp_automation.Tests;

public class Tests : DriverHelper
{
    /*
    Here im just initilizing the pages so we can use
    any public variable and method.
    */

    pages.HomePage home = new pages.HomePage();
    pages.ResultPage result = new pages.ResultPage();

    /*
    Im just adding any other variable needed in the test here.
    */


    string SITE = "http://www.youtube.com";

    [SetUp]
    public void Setup()
    {
        
    }

    [Test, Order(1)]
    public void YoutubeSmokeTest()
    {   
        
        Driver.WaitUntil(ExpectedConditionsSearchContext.ElementToBeClickable(By.XPath(home.searchBarPath)));
        Assert.That(Driver.Title, Is.EqualTo("YouTube"));
    }

    [Test, Order(2)]
    public void SearchTest()
    {
        
        Driver.WaitUntil(ExpectedConditionsSearchContext.ElementIsVisible(By.XPath(home.searchBarPath)));
        home.clickSearchBar();
        home.inputSearchBar("痛みの永遠");
        home.clickSearchButton();

        Driver.WaitUntil(ExpectedConditionsSearchContext.ElementIsVisible(By.XPath(result.resultOnePath)));

        Assert.IsTrue(result.resultOne.Text.Contains("痛みの永遠"));

        Driver.Quit();
    }
}