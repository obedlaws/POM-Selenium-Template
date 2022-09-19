using OpenQA.Selenium;

namespace csharp.pages;

public class HomePage
{
    // XPaths or selectos strings 
    public string inputPath = "/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input";
    public string searchButtonPath = "/html/body/div[1]/div[3]/form/div[1]/div[1]/div[3]/center/input[1]";

    // Element, Method and Combos using 

    public void InputSearchBar(IWebDriver Driver, string input)
    {
        Driver.FindElement(By.XPath(inputPath)).SendKeys(input);
    }

    public void ClickSearchButton(IWebDriver Driver)
    {
        Driver.FindElement(By.XPath(searchButtonPath)).Click();
    }

}