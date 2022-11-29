using OpenQA.Selenium;

namespace TeamInternational.PageObjects
{
    class MainPage
    {
        //selectors
        private static string _selector(int position) => "//*[@id=\"fp-nav\"]/ul/li[" + position + "]/a";
        private static string _section(string section) => "#content > section.section." + section + ".fp-section.fp-table";
        private static string _activeSection(string section) => _section(section) + ".active.fp-completely";
        private static string _sectionContainer(string section) => _section(section) + " > div > div";
        private static string _activeSectionContainer(string section) => _activeSection(section) + " > div > div";
        private static string _contactSalesContainer = "/html/body/webruntime-app/community_byo-scoped-header-and-footer/main/webruntime-router-container/community_layout-slds-flexible-layout/div/community_layout-section/div/div[3]/community_layout-column/div/c-mql-form/lightning-layout";
        private static string _contactSalesHeader() => _contactSalesContainer + "/slot/lightning-layout-item[1]/slot/div";
        private static string _industryElement(int position) => _activeSectionContainer(Constants.MainPage.SOFTWARE_SOLUTIONS_FOR_YOUR_INDUSTRY_SECTION_CONTAINER) + " > div.row.justify-content-xl-center > div > div > div:nth-child(" + position + ") > a";
        private static string _industryElementTitle(int position) => _industryElement(position) + " > div > div.main-text > h3";
        private static string _industryElementText(int position) => _industryElement(position) + " > div > div.main-text > p";
        private static string _servicesElement(int position) => _activeSectionContainer(Constants.MainPage.INNOVATIVE_IT_SOFTWARE_SERVICES_SECTION_CONTAINER) + " > div.row.justify-content-xl-center > div > div > div:nth-child(" + position + ") > a";
        private static string _servicesElementTitle(int position) => _servicesElement(position) + " > div.info-block > p.service-name.white-text";
        private static string _servicesElementText(int position) => _servicesElement(position) + " > div.info-block > p.description-service.white-text";
        private static string _globalTrustElement(int position) => "#logo-partners-" + position + " > img";
        private static string _globalTrustElementHover(int position) => "#logo-partners-" + position + " > noscript";
        private static string _baseLocationElement = _activeSectionContainer(Constants.MainPage.LOCATIONS_SECTION_CONTAINER) + " > div.row.justify-content-xl-center > div > div.location-slider.slick-initialized.slick-slider > ";
        private static string _baseLocationElementNextArrow = _baseLocationElement + "img.arrow-btn.next.slick-arrow";
        private static string _baseLocationElementCountry = _baseLocationElement + "div > div > div.location-item.slick-slide.slick-current.slick-active.slick-center > div.top-block > h3";
        private static string _baseLocationElementType = _baseLocationElement + "div > div > div.location-item.slick-slide.slick-current.slick-active.slick-center > div.top-block > p";
        private static string _baseLocationElementZone = _baseLocationElement + "div > div > div.location-item.slick-slide.slick-current.slick-active.slick-center > div.bottom-block > p";
        private static string _baseLocationElementButton = _baseLocationElement + "div > div > div.location-item.slick-slide.slick-current.slick-active.slick-center > div.bottom-block > a";
        private static string _carrerUrl = _activeSectionContainer(Constants.MainPage.EMPOWER_YOUR_CAREER_SECTION_CONTAINER) + " > div > div > a";
        private static string _baseContactsalesForm(int position) => "/html/body/webruntime-app/community_byo-scoped-header-and-footer/main/webruntime-router-container/community_layout-slds-flexible-layout/div/community_layout-section/div/div[3]/community_layout-column/div/c-mql-form/lightning-layout/slot/lightning-layout-item[3]/slot/lightning-layout/slot/lightning-layout-item[" + position + "]/slot/";
        private static string _contactSalesFormFrame = "#contact-section > iframe";
        private static string _contactSalesFormFirstName = _baseContactsalesForm(1) + "div/span/input";
        private static string _contactSalesFormLastName = _baseContactsalesForm(2) + "div/span/input";
        private static string _contactSalesFormCompany = _baseContactsalesForm(3) + "div/span/input";
        private static string _contactSalesFormEmail = _baseContactsalesForm(4) + "div/span/input";
        private static string _contactSalesFormPhone = _baseContactsalesForm(5) + "div/span/input";
        private static string _contactSalesFormMessage = _baseContactsalesForm(6) + "div/span/input";
        private static string _contactSalesFormPrivacyCheck = _baseContactsalesForm(7) + "lightning-layout/slot/lightning-layout-item[1]/slot/label/span";
        private static string _contactSalesFormSuscribeCheck = _baseContactsalesForm(8) + "lightning-layout/slot/lightning-layout-item[1]/slot/label/span";
        private static string _contactSalesFormSubmit = _baseContactsalesForm(9) + "div/input";
        private static string _contactSalesThanks = "/html/body/webruntime-app/community_byo-scoped-header-and-footer/main/webruntime-router-container/community_layout-slds-flexible-layout/div/community_layout-section/div/div[3]/community_layout-column/div/c-mql-form/lightning-layout/slot/lightning-layout-item[3]/slot/div[1]";

        //By returns :: edit variables instead
        public static By Selector(int position) => By.XPath(_selector(position));
        public static By Section(string section) => By.CssSelector(_section(section));
        public static By ActiveSection(string section) => By.CssSelector(_activeSection(section));
        public static By SectionContainer(string section) => By.CssSelector(_sectionContainer(section));
        public static By ActiveSectionContainer(string section) => By.CssSelector(_activeSectionContainer(section));
        public static By ContactSalesContainer() => By.CssSelector(_contactSalesContainer);
        public static By ContactSalesHeader() => By.XPath(_contactSalesHeader());
        public static By IndustryElement (int position) => By.CssSelector(_industryElement(position));
        public static By IndustryElementTitle(int position) => By.CssSelector(_industryElementTitle(position));
        public static By IndustryElementText(int position) => By.CssSelector(_industryElementText(position));
        public static By ServicesElement(int position) => By.CssSelector(_servicesElement(position));
        public static By ServicesElementTitle(int position) => By.CssSelector(_servicesElementTitle(position));
        public static By ServicesElementText(int position) => By.CssSelector(_servicesElementText(position));
        public static By GlobalTrustElement(int position) => By.CssSelector(_globalTrustElement(position));
        public static By GlobalTrustElementHover(int position) => By.CssSelector(_globalTrustElementHover(position));
        public static By BaseLocationElementNextArrow() => By.CssSelector(_baseLocationElementNextArrow);
        public static By BaseLocationElementCountry() => By.CssSelector(_baseLocationElementCountry);
        public static By BaseLocationElementType() => By.CssSelector(_baseLocationElementType);
        public static By BaseLocationElementZone() => By.CssSelector(_baseLocationElementZone);
        public static By BaseLocationElementButton() => By.CssSelector(_baseLocationElementButton);
        public static By CarrerUrl() => By.CssSelector(_carrerUrl);
        public static By ContactSalesFormFrame() => By.CssSelector(_contactSalesFormFrame);
        public static By ContactSalesFormFirstName() => By.XPath(_contactSalesFormFirstName);
        public static By ContactSalesFormLastName() => By.XPath(_contactSalesFormLastName);
        public static By ContactSalesFormCompany() => By.XPath(_contactSalesFormCompany);
        public static By ContactSalesFormEmail() => By.XPath(_contactSalesFormEmail);
        public static By ContactSalesFormPhone() => By.XPath(_contactSalesFormPhone);
        public static By ContactSalesFormMessage() => By.XPath(_contactSalesFormMessage);
        public static By ContactSalesFormPrivacyCheck() => By.XPath(_contactSalesFormPrivacyCheck);
        public static By ContactSalesFormSuscribeCheck() => By.XPath(_contactSalesFormSuscribeCheck);
        public static By ContactSalesFormSubmit() => By.XPath(_contactSalesFormSubmit);
        public static By ContactSalesFormThanks() => By.XPath(_contactSalesThanks);
    }

}

