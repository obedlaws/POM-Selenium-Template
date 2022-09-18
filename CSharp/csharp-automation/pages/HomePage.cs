using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace csharp_automation.pages;

public class HomePage : DriverHelper
{
	

    /* Locator String:
    In this case my recommendation of Selector will be to use XPath. From
    my experience Selenium failed to find elements when I tried to use 
	any other selector. You are welcome to use any selector you want.
	(I mean sometimes It fails using XPath Selector, but thats is because of 
	the Waits beign a little fuzzy and maybe sometimes don't work in C# )

	So having said that, this part is not necesary if you are using other selector but 
	it also helps in the modularity that POM can give you.

	So the following strings are just the XPaths to be used in the selectors later.

	Some additional tips:
	Some times you will need to use Wait and ExpectedCondition and you can easily make these
	variables public so you can use it in any other file in the project
    */

	public string searchBarPath = "/html/body/ytd-app/div[1]/div/ytd-masthead/div[3]/div[2]/ytd-searchbox/form/div[1]/div[1]/input";
	string searchButtonPath = "/html/body/ytd-app/div[1]/div/ytd-masthead/div[3]/div[2]/ytd-searchbox/button/yt-icon";


	/* Selectors
	If you have used Selenium before, this is a simple step. 
	We will just add selector using lambda functions. Really simple step.

	You can also make these elements public if they are needed any other part of the
	project.
	*/ 

	IWebElement searchBar => Driver.FindElement(By.XPath(searchBarPath));
	IWebElement searchButton => Driver.FindElement(By.XPath(searchButtonPath));


	/* Methods
	This is also a simple part of the page variables. These methods will use the elemets
	we just created above. Things you can do such as click or send and input in the page.
	This part is pritty simple too if you know the different function selenium can do.

	We also use Lamda function syntax in these functions.
	These methods will be used in the Test files.
	*/

	public void clickSearchBar() => searchBar.Click();
	public void inputSearchBar(string input) => searchBar.SendKeys(input);
	public void clickSearchButton() => searchButton.Click();
}
