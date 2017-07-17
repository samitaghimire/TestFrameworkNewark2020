using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestFrameworkNewark2020
{
	class featureMethod
	{
        public static IWebDriver driver = new ChromeDriver();
        public static void login()
        {
            driver.Url = @"http://122.160.12.156:8090/";
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Id", control_Id.login_Click);
            coreMethod.textboxenter(driver, "Id", control_Id.username, input.usernameValue);
            coreMethod.textboxenter(driver, "Name", control_Id.password, input.passvalue);
            coreMethod.buttonclick(driver, "CssSelector", control_Id.loginbutton);

        }
    }
}
