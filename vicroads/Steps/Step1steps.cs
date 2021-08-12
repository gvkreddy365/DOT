using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using vicroads.Helpers;
using vicroads.Pages;

namespace vicroads.Steps
{
    [Binding]
    public class Step1steps : DriverHelper
    {

  
        Step1page step1page = new Step1page();
        Step2page step2page = new Step2page();

        [Given(@"I'm on step (.*) page")]
        public void GivenIMOnStepPage(int p0)
        {
            var url = "https://www.vicroads.vic.gov.au/registration/limited-use-permits/unregistered-vehicle-permits/get-an-unregistered-vehicle-permit";
            Driver.Navigate().GoToUrl(url);
        }

        [When(@"I select the vehicle type")]
        public void WhenISelectTheVehicleType()
        {
            step1page.selectVehicleType();
        }

        [When(@"I select engine capacity")]
        public void WhenISelectEngineCapacity()
        {
            step1page.selectCarryingCapacity();
        }

        [When(@"I enter the address")]
        public void WhenIEnterTheAddress()
        {
            step1page.enterAddress("64 Old Geelong Rd, Hoppers Crossing VIC 3029");
            step1page.selectAddress();
        }

        [When(@"I select the permit duration")]
        public void WhenISelectThePermitDuration()
        {
            step1page.selectPermitDuration();
        }

        [When(@"click on Next button")]
        public void WhenClickOnNextButton()
        {
            step1page.selectNextButton();
        }

        [Then(@"I'm on Step (.*) of (.*)")]
        public void ThenIMOnStepOf(int p0, int p1)
        {
            step2page.step2Validation();
        }


    }
}
