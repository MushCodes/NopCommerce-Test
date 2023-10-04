using OpenQA.Selenium;
using System.Threading;

namespace MyFirstProject.PageObjects
{
    class PageObject
    {
        public static IWebDriver Driver;
        
        public PageObject(IWebDriver driver )
        {
            Driver = driver;
        }

        //Purchase MacBook
        public IWebElement btnMacbook => Driver.FindElement(By.CssSelector("[href*='apple-macbook-pro-13-inch']"));
        public IWebElement btnAddtoCart => Driver.FindElement(By.Id("add-to-cart-button-4"));
        public IWebElement btnShoppingBasket => Driver.FindElement(By.CssSelector("[href*='/cart']"));
        public IWebElement btnAgreetoConditions => Driver.FindElement(By.Name("termsofservice"));
        public IWebElement btnCheckout => Driver.FindElement(By.Id("checkout"));
        public IWebElement btnLogin => Driver.FindElement(By.CssSelector("[class*='button-1 login-button']"));

        //Billing Details
        public IWebElement Country => Driver.FindElement(By.Name("BillingNewAddress.CountryId"));
        public IWebElement State => Driver.FindElement(By.Name("BillingNewAddress.StateProvinceId"));
        public IWebElement City => Driver.FindElement(By.Name("BillingNewAddress.City"));
        public IWebElement Address => Driver.FindElement(By.Id("BillingNewAddress_Address1"));
        public IWebElement PostCode => Driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode"));
        public IWebElement PhoneNumber => Driver.FindElement(By.Id("BillingNewAddress_PhoneNumber"));
        public IWebElement ContinueBil => Driver.FindElement(By.CssSelector("[class*='button-1 new-address-next-step-button']"));
        public IWebElement SkipBillDetails => Driver.FindElement(By.CssSelector("[class*='button-1 new-address-next-step-button']"));

        //Shipping Details
        public IWebElement NextDayShip => Driver.FindElement(By.Id("shippingoption_1")); 
        public IWebElement ContinueShip => Driver.FindElement(By.CssSelector("[class*='button-1 shipping-method-next-step-button']"));

        //Payment
        public IWebElement ContinuePay => Driver.FindElement(By.CssSelector("[class*='button-1 payment-method-next-step-button']"));
        public IWebElement ContinuePayInfo => Driver.FindElement(By.CssSelector("[class*='button-1 payment-info-next-step-button']"));
        public IWebElement Confirm => Driver.FindElement(By.CssSelector("[class*='button-1 confirm-order-next-step-button']"));
        public IWebElement ContinueFinish => Driver.FindElement(By.CssSelector("[class*='button-1 order-completed-continue-button']"));

        //Register/Login User
        public IWebElement btnRegister => Driver.FindElement(By.CssSelector("[class*='button-1 register-button']"));
        public IWebElement txtUserEmail => Driver.FindElement(By.Name("Email"));
        public IWebElement txtUserPassword => Driver.FindElement(By.Name("Password"));
        public IWebElement Male => Driver.FindElement(By.Id("gender-male"));
        public IWebElement FirstName => Driver.FindElement(By.Id("FirstName"));
        public IWebElement LastName => Driver.FindElement(By.Id("LastName"));
        public IWebElement BirthDay => Driver.FindElement(By.Name("DateOfBirthDay"));
        public IWebElement BirthMonth => Driver.FindElement(By.Name("DateOfBirthMonth"));
        public IWebElement BirthYear => Driver.FindElement(By.Name("DateOfBirthYear"));
        public IWebElement Email => Driver.FindElement(By.Id("Email"));
        public IWebElement Password => Driver.FindElement(By.Id("Password"));
        public IWebElement ConfirmPassword => Driver.FindElement(By.Id("ConfirmPassword"));
        public IWebElement Register => Driver.FindElement(By.Id("register-button"));
        public IWebElement ContinueReg => Driver.FindElement(By.CssSelector("[class*='button-1 register-continue-button']"));


        public void PurchaseMacbook()
        {
            Thread.Sleep(3000);
            btnMacbook.Click();
            Thread.Sleep(3000);
            btnAddtoCart.Click();
            Thread.Sleep(3000);
            btnShoppingBasket.Click();
            Thread.Sleep(2000);
            btnAgreetoConditions.Click();
            Thread.Sleep(3000);
            btnCheckout.Click();
        }

        public void RegisterUser(string userEmail, string userPassword, string firstName, string lastName)
        {
            btnRegister.Click();
            Male.Click();
            FirstName.EnterText(firstName);
            LastName.EnterText(lastName);
            SetMethods.SelectDropDown(BirthDay, "14");
            SetMethods.SelectDropDown(BirthMonth, "August");
            SetMethods.SelectDropDown(BirthYear, "1998");
            Email.EnterText(userEmail);
            Password.EnterText(userPassword);
            ConfirmPassword.EnterText(userPassword);
            Register.Click();
            ContinueReg.Click();
            //btnAgreetoConditions.Click();
            btnCheckout.Click();
        }

        public void Login(string testName)
        {
            txtUserEmail.EnterText("ImranAli123@gmail.com");
            txtUserPassword.EnterText("password123");
            btnLogin.Click();
            btnAgreetoConditions.Click();
            btnCheckout.Click();
        }

        public void EnterBillingDetails()
        {
            SetMethods.SelectDropDown(Country, "United Kingdom");
            City.EnterText("Bradford");
            Address.EnterText("10 Hilton Place");
            PostCode.EnterText("BD10 1AB");
            PhoneNumber.EnterText("07123 456789");
            ContinueBil.Click();
        }

        public void EnterShippingDetailsEtc()
        {
            NextDayShip.Click();
            ContinueShip.Click();
            Thread.Sleep(2000);
            ContinuePay.Click();
            Thread.Sleep(1500);
            ContinuePayInfo.Click();
            Thread.Sleep(1500);
            Confirm.Click();
            Thread.Sleep(1500);
            ContinueFinish.Click();
        }

        
    }
}



