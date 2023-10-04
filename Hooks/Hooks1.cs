using MyFirstProject;
using MyFirstProject.Drivers;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace MySpecflowProject.Hooks
{
    [Binding]
    public sealed class Hooks1
    {

        private DriverPropertyy _driverPropertyy;
        public Hooks1(DriverPropertyy driverPropertyy)
        {
            _driverPropertyy = driverPropertyy;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions option = new ChromeOptions();
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driverPropertyy.Driver = new ChromeDriver(option);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverPropertyy.Driver.Quit();
        }
    }
}
