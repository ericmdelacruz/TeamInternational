using NUnit.Framework;

namespace TeamInternational.Tests
{
    class MainPage : BaseTest {


        [Test]
        public static void T0001_OpenPage()
        {
            Test = Extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name).Info("Open Team International Page");
            Logic.MainPage.GoToUrl ("Go to URL: " + Properties.System.URL, Properties.System.URL);
        }

        [Test]
        public static void T0002_ValidateScrolling()
        {
            Test = Extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name).Info("Validate Software Solutions For Your Industry Section");
            Logic.MainPage.GoToUrlIfNull("Go to URL: " + Properties.System.URL, Properties.System.URL);
            //First section is active by default
            Logic.MainPage.IsSectionActive("Validate if section is active", PageObjects.MainPage.ActiveSection(Constants.MainPage.SOFTWARE_SOLUTIONS_FOR_YOUR_INDUSTRY_SECTION_CONTAINER));
            Logic.MainPage.ScrollToNextSection("Go to Innovative It Software Services Section");
            Logic.MainPage.IsSectionActive("Validate if section is active", PageObjects.MainPage.ActiveSection(Constants.MainPage.INNOVATIVE_IT_SOFTWARE_SERVICES_SECTION_CONTAINER));
            Logic.MainPage.ScrollToNextSection("Go to They Trust Us Section");
            Logic.MainPage.IsSectionActive("Validate if section is active", PageObjects.MainPage.ActiveSection(Constants.MainPage.THEY_TRUST_US_SECTION_CONTAINER));
            Logic.MainPage.ScrollToNextSection("Go to Locations Section");
            Logic.MainPage.IsSectionActive("Validate if section is active", PageObjects.MainPage.ActiveSection(Constants.MainPage.LOCATIONS_SECTION_CONTAINER));
            Logic.MainPage.ScrollToNextSection("Go to Top Gun Lab Section");
            Logic.MainPage.IsSectionActive("Validate if section is active", PageObjects.MainPage.ActiveSection(Constants.MainPage.TOP_GUN_LAB_SECTION_CONTAINER));
            Logic.MainPage.ScrollToNextSection("Go to Empower Your Career Section");
            Logic.MainPage.IsSectionActive("Validate if section is active", PageObjects.MainPage.ActiveSection(Constants.MainPage.EMPOWER_YOUR_CAREER_SECTION_CONTAINER));
            Logic.MainPage.ScrollToNextSection("Go to Contact Sales Section");
            Logic.MainPage.IsSectionActive("Validate if section is active", PageObjects.MainPage.ActiveSection(Constants.MainPage.CONTACT_SALES_SECTION_CONTAINER));
        }

        [Test]
        public static void T0003_ValidateSoftwareSolutionsForYourIndustrySection()
        {
            Test = Extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name).Info("Validate Software Solutions For Your Industry Section");
            Logic.MainPage.GoToUrlIfNull("Go to URL: " + Properties.System.URL, Properties.System.URL);
            Logic.MainPage.SelectSection("Go to Software Solutions For Your Industry Section", Constants.MainPage.SOFTWARE_SOLUTIONS_FOR_YOUR_INDUSTRY_SECTION);
            Logic.MainPage.IsSectionActive("Validate if section is active", PageObjects.MainPage.ActiveSection(Constants.MainPage.SOFTWARE_SOLUTIONS_FOR_YOUR_INDUSTRY_SECTION_CONTAINER));
            Logic.MainPage.ValidateIndustryElements("Validating section Element");
        }

        [Test]
        public static void T0004_ValidateInnovativeItSoftwareServicesSection()
        {
            Test = Extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name).Info("Validate Innovative It Software Services Section");
            Logic.MainPage.GoToUrlIfNull("Go to URL: " + Properties.System.URL, Properties.System.URL);
            Logic.MainPage.SelectSection("Go to Innovative It Software Services Section", Constants.MainPage.INNOVATIVE_IT_SOFTWARE_SERVICES_SECTION);
            Logic.MainPage.IsSectionActive("Validate if section is active", PageObjects.MainPage.ActiveSection(Constants.MainPage.INNOVATIVE_IT_SOFTWARE_SERVICES_SECTION_CONTAINER));
            Logic.MainPage.ValidateServicesElements("Validating section Element");

        }

        [Test]
        public static void T0005_ValidateTheyTrustUsSection()
        {
            Test = Extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name).Info("Validate They Trust Us Section");
            Logic.MainPage.GoToUrlIfNull("Go to URL: " + Properties.System.URL, Properties.System.URL);
            Logic.MainPage.SelectSection("Go to They Trust Us Section", Constants.MainPage.THEY_TRUST_US_SECTION);
            Logic.MainPage.IsSectionActive("Validate if section is active", PageObjects.MainPage.ActiveSection(Constants.MainPage.THEY_TRUST_US_SECTION_CONTAINER));
            Logic.MainPage.ValidateGlobalTruesElements("Validating section Element");
        }

        [Test]
        public static void T0006_ValidateLocationsSection()
        {
            Test = Extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name).Info("Validate Locations Section");
            Logic.MainPage.GoToUrlIfNull("Go to URL: " + Properties.System.URL, Properties.System.URL);
            Logic.MainPage.SelectSection("Go to Locations Section", Constants.MainPage.LOCATIONS_SECTION);
            Logic.MainPage.IsSectionActive("Validate if section is active", PageObjects.MainPage.ActiveSection(Constants.MainPage.LOCATIONS_SECTION_CONTAINER));
            Logic.MainPage.ValidateLocationElements("Validating section Element");
        }

        [Test]
        public static void T0007_ValidateTopGunLabSection()
        {
            Test = Extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name).Info("Validate Top Gun Lab Section");
            Logic.MainPage.GoToUrlIfNull("Go to URL: " + Properties.System.URL, Properties.System.URL);
            Logic.MainPage.SelectSection("Go to Top Gun Lab Section", Constants.MainPage.TOP_GUN_LAB_SECTION);
            Logic.MainPage.IsSectionActive("Validate if section is active", PageObjects.MainPage.ActiveSection(Constants.MainPage.TOP_GUN_LAB_SECTION_CONTAINER));
            //Nothing to do here (no interactions available at page)
        }

        [Test]
        public static void T0008_ValidateEmpowerYourCareerSection()
        {
            Test = Extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name).Info("Validate Empower Your Career Section");
            Logic.MainPage.GoToUrlIfNull("Go to URL: " + Properties.System.URL, Properties.System.URL);
            Logic.MainPage.SelectSection("Go to Empower Your Career Section", Constants.MainPage.EMPOWER_YOUR_CAREER_SECTION);
            Logic.MainPage.IsSectionActive("Validate if section is active", PageObjects.MainPage.ActiveSection(Constants.MainPage.EMPOWER_YOUR_CAREER_SECTION_CONTAINER));
            Logic.MainPage.ValidateCarrerElements("Validating section Element");

        }

        [Test]
        public static void T0009_ValidateContactSalesSection()
        {
            Test = Extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name).Info("Validate Contact Sales Section");
            Logic.MainPage.GoToUrlIfNull("Go to URL: " + Properties.System.URL, Properties.System.URL);
            Logic.MainPage.SelectSection("Go to Contact Sales Section", Constants.MainPage.CONTACT_SALES_SECTION);
            Logic.MainPage.IsSectionActive("Validate if section is active", PageObjects.MainPage.ActiveSection(Constants.MainPage.CONTACT_SALES_SECTION_CONTAINER));
            Logic.MainPage.ValidateContactSalesForm("Validate form generation");
        }

        [Test]
        public static void T0010_FailForTheReport()
        {
            Test = Extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name).Info("Open Team International Page");
            //harcoded, because it is what it is, a fake address and not a real test case, just to probe the report is actually working
            Logic.MainPage.GoToUrl("Go to URL: " + Properties.System.URL, "https://www.teaminternationalWrongAddress.com/");
        }

    }

}
