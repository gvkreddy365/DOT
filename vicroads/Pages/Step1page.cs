using System.Diagnostics;
using OpenQA.Selenium;

namespace vicroads.Pages
{
    public class Step1page : DriverHelper
    {
        IWebElement vehicletype => Driver.FindElement(By.XPath("//option[contains(text(), 'Motorcycle')]"));
        IWebElement carryingCapaticy => Driver.FindElement(By.XPath("//option[contains(text(), 'Less than 61 cc')]"));
        IWebElement addressGaraged => Driver.FindElement(By.XPath("//input[@name='ph_pagebody_0$phthreecolumnmaincontent_0$panel$AddressLine$SingleLine_CtrlHolderDivShown']"));
        IWebElement permitDuration => Driver.FindElement(By.XPath("//option[contains(text(), '13 days')]"));
        IWebElement nextButton => Driver.FindElement(By.XPath("//input[@type='submit' and @value='Next']"));
        public void selectVehicleType()
        {
            vehicletype.Click();
        }
        public void selectCarryingCapacity()
        { 
            carryingCapaticy.Click();
        }
        public void enterAddress(string add)
        {
            addressGaraged.SendKeys(add);
        }
        public void selectAddress()
        {
            addressGaraged.Click();
        }
        public void selectPermitDuration()
        {
            permitDuration.Click();
        }
         public void selectNextButton()
        {
            nextButton.Click();
         }
    }
}
