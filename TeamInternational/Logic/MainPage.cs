using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SoftAssertion;
using TeamInternational.Selenium_Helpers;
using TeamInternational.Tests;

namespace TeamInternational.Logic
{
    class MainPage : BaseTest
    {

        public static void GoToUrl(string step, string url)
        {
            try
            {
                Driver.Navigate().GoToUrl(url);
                Assert.AreEqual(Driver.Title, Constants.MainPage.PAGE_TITLE);
                Test.Pass(step);
            }
            catch
            {
                Test.Fail(step);
                throw;
            }
        }

        public static void GoToUrlIfNull(string step, string url)
        {
            if (Driver.Url.Equals("data:,"))
            {
                try
                {
                    Driver.Navigate().GoToUrl(url);
                    Assert.AreEqual(Driver.Title, Constants.MainPage.PAGE_TITLE);
                    Test.Pass(step);
                }
                catch
                {
                    Test.Fail(step);
                    throw;
                }
            }
        }

        public static void ScrollToNextSection(string step)
        {
            try
            {
                new Actions(Driver).SendKeys(Keys.PageDown).Perform();
                Test.Pass(step);
            }

            catch
            {
                Test.Fail(step);
                throw;
            }

        }

        public static void IsSectionActive(string step, By section)
        {
            try
            {
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, section);
                Test.Pass(step);
            }
            catch
            {
                Test.Fail(step);
                throw;
            }
        }

        public static void SelectSection(string step, int position)
        {
            try
            {
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.Selector(position)).Click();
                Test.Pass(step);
            }
            catch
            {
                Test.Fail(step);
                throw;
            }
        }

        public static void ValidateIndustryElements(string step)
        {
            //Since when mouse is hovering on a button, there are no code changes, there is no way to automate the action validation without a 3rd party tool
            //For that reason hovering is being shown visually for 1 sec (configurable at properties) and code is validating that the shown text is not empty (needs specs to
            //know the actual comparison values).
            //Also links are just validating that they are not empty but not following them to not add more to this script. They should be checked the same way the validation for
            //TC0001 is being done.

            SoftAssert softAssert = new SoftAssert();
            for (int i = 1; i <= 9; i++)
            {
                try
                {
                    IWebElement webElement = SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.IndustryElementTitle(i));
                    string buttonTitle = webElement.Text;
                    softAssert.AreNotEqual(buttonTitle, "");

                    webElement = SeleniumHelper.WaitForExistanceAndSelectElement(Driver, PageObjects.MainPage.IndustryElementText(i));
                    string buttonText = webElement.GetAttribute("textContent");
                    softAssert.AreNotEqual(buttonText, "");

                    webElement = SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.IndustryElement(i));
                    string buttonUrl = webElement.GetAttribute("href");
                    softAssert.AreNotEqual(buttonUrl, "");

                    Actions actions = new Actions(Driver);
                    actions.MoveToElement(webElement).Build().Perform();
                    Thread.Sleep(Properties.System.HOVER_WAIT * 1000);

                    Test.Pass(step + " on elemeent " + i);
                }
                catch (Exception ex)
                {
                    Test.Fail(ex.StackTrace + step + " on element " + i);
                    softAssert.Null(step + " on element " + i);
                }
                softAssert.VerifyAll();

            }
        }

        public static void ValidateServicesElements(string step)
        {
            //Since when mouse is hovering on a button, there are no code changes, there is no way to automate the action validation without a 3rd party tool
            //For that reason hovering is being shown visually for 1 sec (configurable at properties) and code is validating that the shown text is not empty (needs specs to
            //know the actual comparison values).
            //Also links are just validating that they are not empty but not following them to not add more to this script. They should be checked the same way the validation for
            //TC0001 is being done.

            SoftAssert softAssert = new SoftAssert();
            for (int i = 1; i <= 7; i++)
            {
                try
                {
                    IWebElement webElement = SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ServicesElementTitle(i));
                    string buttonTitle = webElement.Text;
                    softAssert.AreNotEqual(buttonTitle, "");

                    webElement = SeleniumHelper.WaitForExistanceAndSelectElement(Driver, PageObjects.MainPage.ServicesElementText(i));
                    string buttonText = webElement.GetAttribute("textContent");
                    softAssert.AreNotEqual(buttonText, "");

                    webElement = SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ServicesElement(i));
                    string buttonUrl = webElement.GetAttribute("href");
                    softAssert.AreNotEqual(buttonUrl, "");

                    Actions actions = new Actions(Driver);
                    actions.MoveToElement(webElement).Build().Perform();
                    Thread.Sleep(Properties.System.HOVER_WAIT * 1000);

                    Test.Pass(step + " on elemeent " + i);
                }
                catch (Exception ex) 
                {
                    Test.Fail(ex.StackTrace + step + " on element " + i);
                    softAssert.Null(step + " on element " + i);
                }
            }
            softAssert.VerifyAll();
        }

        public static void ValidateGlobalTruesElements(string step)
        {
            //Since when mouse is hovering on a button, there are no code changes, there is no way to automate the action validation without a 3rd party tool
            //For that reason hovering is being shown visually for 1 sec (configurable at properties) 
            //No links or other interaction here

            SoftAssert softAssert = new SoftAssert();
            for (int i = 1; i <= 25; i++)
            {
                try
                {
                    IWebElement webElement = SeleniumHelper.WaitForExistanceAndSelectElement(Driver, PageObjects.MainPage.GlobalTrustElementHover(i));
                    string hoverImage = webElement.GetAttribute("textContent");
                    softAssert.AreNotEqual(hoverImage, "");
                    
                    webElement = SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.GlobalTrustElement(i));
                    string image = webElement.GetAttribute("src");
                    softAssert.AreNotEqual(image, "");

                    Actions actions = new Actions(Driver);
                    actions.MoveToElement(webElement).Build().Perform();
                    Thread.Sleep(Properties.System.HOVER_WAIT * 1000);

                    Test.Pass(step + " on elemeent " + i);
                }
                catch (Exception ex)
                {
                    Test.Fail(ex.StackTrace + step + " on element " + i);
                    softAssert.Null(step + " on element " + i);
                }
            }
            softAssert.VerifyAll();
        }

        public static void ValidateLocationElements(string step)
        {
            //Not following link to not make script huge, Validating all values

            List<string[]> data = new List<string[]>();
            data.Add(new string[]{ "UNITED STATES", "Headquarters", "Lake Mary", "https://www.teaminternational.com/locations/#us" });
            data.Add(new string[] { "PORTUGAL", "Delivery hub", "Lisbon", "https://www.teaminternational.com/locations/#portugal" });
            data.Add(new string[] { "MEXICO", "Delivery hub", "Monterrey", "https://www.teaminternational.com/locations/#mexico" });
            data.Add(new string[] { "COLOMBIA", "Delivery hub", "Medellin", "https://www.teaminternational.com/locations/#colombia" });
            data.Add(new string[] { "ARGENTINA", "Delivery hub", "Buenos Aires", "https://www.teaminternational.com/locations/#argentina" });
            data.Add(new string[] { "POLAND", "Delivery hub", "Lublin", "https://www.teaminternational.com/locations/#poland" });
            data.Add(new string[] { "UKRAINE", "Delivery hub", "Lviv", "https://www.teaminternational.com/locations/#ukraine" });

            SoftAssert softAssert = new SoftAssert();
            for (int i = 0; i < 7; i++)
            {
                try
                {
                    IWebElement webElement = SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.BaseLocationElementCountry());
                    string country = webElement.Text;
                    softAssert.AreEqual(country, data[i][0]);

                    webElement = SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.BaseLocationElementType());
                    string type = webElement.GetAttribute("textContent");
                    softAssert.AreEqual(type, data[i][1]);

                    webElement = SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.BaseLocationElementZone());
                    string zone = webElement.GetAttribute("textContent");
                    softAssert.AreEqual(zone, data[i][2]);

                    webElement = SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.BaseLocationElementButton());
                    string url = webElement.GetAttribute("href");
                    softAssert.AreEqual(url, data[i][3]);

                    Test.Pass(step + " on elemeent " + i);

                    SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.BaseLocationElementNextArrow()).Click();

                    //waits for animation
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    Test.Fail(ex.StackTrace + step + " on element " + i);
                    softAssert.Null(step + " on element " + i);
                }
            }
            softAssert.VerifyAll();
        }

        public static void ValidateCarrerElements(string step)
        {
            //Since when mouse is hovering on a button, there are no code changes, there is no way to automate the action validation without a 3rd party tool
            //For that reason hovering is being shown visually for 1 sec (configurable at properties) and code is only validating url

            string carrerUrl = "https://teamsites.force.com/careers";

            SoftAssert softAssert = new SoftAssert();
            try
            {
                IWebElement webElement = SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.CarrerUrl());
                string url = webElement.GetAttribute("href");
                softAssert.AreEqual(url, carrerUrl);

                Actions actions = new Actions(Driver);
                actions.MoveToElement(webElement).Build().Perform();
                Thread.Sleep(Properties.System.HOVER_WAIT * 1000);

                Test.Pass(step);
            }
            catch (Exception ex)
            {
                Test.Fail(ex.StackTrace + step);
                softAssert.Null(step);
            }
        }

        public static void ValidateContactSalesForm(string step)
        {
            //Just validating happy path
            //Not validating link to Privacy Policy

            string[] data = { "Test First Name", "Test Last Name", "Test Company", "test@email.com", "555-1234", "This is a test" };
            string thanksText = "THANK YOU FOR CONTACTING US!";

            try
            {
                Driver = SeleniumHelper.SwitchFrame(Driver, PageObjects.MainPage.ContactSalesFormFrame());
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormFirstName()).Click();
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormFirstName()).SendKeys(data[1]);
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormLastName()).Click();
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormLastName()).SendKeys(data[1]);
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormCompany()).Click();
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormCompany()).SendKeys(data[2]);
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormEmail()).Click();
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormEmail()).SendKeys(data[3]);
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormPhone()).Click();
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormPhone()).SendKeys(data[4]);
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormMessage()).Click();
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormMessage()).SendKeys(data[5]);
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormPrivacyCheck()).Click();
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormSuscribeCheck()).Click();
                SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormSubmit()).Click();

                //waits for submition
                Thread.Sleep(1000);

                IWebElement webElement = SeleniumHelper.WaitForVisibilityAndSelectElement(Driver, PageObjects.MainPage.ContactSalesFormThanks());
                string thanksMessage = webElement.Text;
                Assert.AreEqual(thanksMessage, thanksText);

                Test.Pass(step);
            }
            catch (Exception ex)
            {
                Test.Fail(step);
                throw;
            }
        }

    }

}

