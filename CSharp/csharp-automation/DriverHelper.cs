using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace csharp_automation;

public class DriverHelper
{
    /*
    This helper is just so you dont have 
    to initilize the Driver in every single file.
    */

    ChromeOptions opts = new ChromeOptions();
    opts.AddArgument("--headless", "--window-size=1920,1080");
    IWebDriver Driver = new ChromeDriver(opts);

        
    
}