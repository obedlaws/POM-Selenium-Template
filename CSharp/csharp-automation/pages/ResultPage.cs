using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace csharp_automation.pages;

public class ResultPage : DriverHelper
{
    public string resultOnePath = "/html/body/ytd-app/div[1]/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[2]/div[1]/div/div[1]/div/h3/a/yt-formatted-string";
    
    public IWebElement resultOne => Driver.FindElement(By.XPath(resultOnePath));

}