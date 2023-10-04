using MyFirstProject.Drivers;
using MyFirstProject.PageObjects;
using MySpecflowProject;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace MyFirstProject.Steps
{
    [Binding]
    class StepDefinitions
    {
        
        private DriverPropertyy _driverPropertyy;
        PageObject page;

        public StepDefinitions(DriverPropertyy driverPropertyy)
        {
            _driverPropertyy = driverPropertyy;
             page = new PageObject(_driverPropertyy.Driver);
        }


        [Given(@"the user navigates to the website")]
        public void GivenTheUserNavigatesToTheWebsite()
        {
            _driverPropertyy.Driver.Navigate().GoToUrl("https://demo.nopcommerce.com/");
            _driverPropertyy.Driver.Manage().Window.Maximize();
            //Screeshot Method
            //((ITakesScreenshot)_driverPropertyy.Driver).GetScreenshot().SaveAsFile("test.png", ScreenshotImageFormat.Png);
        }

        [When(@"the user purchases a macbook")]
        public void WhenTheUserPurchasesAMacbook()
        {
            page.PurchaseMacbook();
            Thread.Sleep(3000);
            page.RegisterUser("ImranAli123@gmail.com", "password123", "Imran", "Ali");
            page.EnterBillingDetails();
            Thread.Sleep(2000);
            //page.Login("LogInTest");
            //Thread.Sleep(2000);
            //page.SkipBillDetails.Click();
            //Thread.Sleep(2000);
            page.EnterShippingDetailsEtc();
        }

        [Then(@"the trasaction should succeed")]
        public void ThenTheTrasactionShouldSucceed()
        {
            //_driverPropertyy.Driver.Close();
        }

    }
}


