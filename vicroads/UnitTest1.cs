/* Note:- This file was initially used to setup the project structure as Page object model after succesful execution, later integrated with Specflow.
using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using vicroads.Pages;

namespace vicroads
{
    public class Tests : DriverHelper
    {
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver(@"Z:\Automation\vicroads\vicroads\bin\chromedriver");
        }
        public void Test() 
        {
            var url = "https://www.vicroads.vic.gov.au/registration/limited-use-permits/unregistered-vehicle-permits/get-an-unregistered-vehicle-permit";
            Driver.Navigate().GoToUrl(url);
            Step1page step1page = new Step1page();
            step1page.selectVehicleType();
            step1page.selectCarryingCapacity();
            step1page.enterAddress("64 Old Geelong Rd, Hoppers Crossing VIC 3029");
            step1page.selectAddress();
            step1page.selectPermitDuration();
            step1page.selectNextButton();
            Step2page step2page = new Step2page();
            step2page.step2Validation();
        }
      
        public void Teardown()
        {
          Driver.Close();
        }
    }
}
*/