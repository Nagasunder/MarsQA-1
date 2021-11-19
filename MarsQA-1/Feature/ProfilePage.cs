using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class ProfilePage
    {

        // Add availablity to progile page
        [Given(@"Add availability to profile page")]
        public void GivenAddAvailabilityToProfilePage()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='right floated outline small write icon']")).Click();
            Driver.driver.FindElement(By.XPath("//*[@class='right floated content']/span/select/option[2]")).Click();
        }
        
        // Add hours to profile page
        [Given(@"Add hours to profile page")]
        public void GivenAddHoursToProfilePage()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='right floated outline small write icon']")).Click();
            Driver.driver.FindElement(By.XPath("//*[@class='right floated content']/span/select/option[2]")).Click();
        }
        
        // Add earn targets to progile page
        [Then(@"Add target earn to profile page")]
        public void ThenAddTargetEarnToProfilePage()
        {
            Driver.driver.FindElement(By.XPath("//*[@class='right floated outline small write icon']")).Click();
            Driver.driver.FindElement(By.XPath("//*[@class='right floated content']/span/select/option[2]")).Click();
        }
    }
}
