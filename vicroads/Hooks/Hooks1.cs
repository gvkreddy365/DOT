using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using vicroads.Helpers;

namespace vicroads.Hooks
{
    [Binding]
    public sealed class Hooks1 : DriverHelper
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            /*option.AddArguments("--headless");*/
            Console.WriteLine("Setup");
            Driver = new ChromeDriver(option);
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
