using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace csharp_automation;

public class DriverHelper
{
    /*
    This helper is just so you dont have 
    to initilize the Driver in every single file.
    */


    public ChromeDriver Driver = new ChromeDriver();

        
    
}