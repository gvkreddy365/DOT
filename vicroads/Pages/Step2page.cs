using NUnit.Framework;
using OpenQA.Selenium;

namespace vicroads.Pages
{
    public class Step2page : DriverHelper
    {
        IWebElement permitType => Driver.FindElement(By.XPath("//p[contains(text(),'Step 2 of 7 : Select permit type')]"));
        public void step2Validation()
        {
            Assert.AreEqual(true, permitType.Displayed);
        }
    }
}
