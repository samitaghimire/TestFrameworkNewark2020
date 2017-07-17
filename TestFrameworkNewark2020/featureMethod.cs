using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestFrameworkNewark2020
{
	class featureMethod
	{
         
        public static void login(IWebDriver driver)
        {
            
            Thread.Sleep(2000);
            coreMethod.buttonclick(driver, "Id", control_Id.login_Click);
            coreMethod.textboxenter(driver, "Id", control_Id.username, input.usernameValue);
            coreMethod.textboxenter(driver, "Name", control_Id.password, input.passvalue);
            coreMethod.buttonclick(driver, "CssSelector", control_Id.loginbutton);
	    coreMethod.buttonclick(driver,"Id", control_Id.logout_click);
        }
		public static void Registration(IWebDriver driver)
		{
			Thread.Sleep(2000);
		   
			coreMethod.buttonclick(driver, "Id", control_Id.register_link_ID);
			coreMethod.textboxenter(driver, "Id", control_Id.uname, input.unamevalue);
			coreMethod.textboxenter(driver, "Id", control_Id.pass, input.pvalue);
			coreMethod.textboxenter(driver, "Id", control_Id.confirmpass, input.pvalue);
			coreMethod.textboxenter(driver, "Id", control_Id.firstname, input.firstnamevalue);
			coreMethod.textboxenter(driver, "Id", control_Id.middlename, input.middlenamevalue);
			coreMethod.textboxenter(driver, "Id", control_Id.lastname, input.lastnamevalue);
			coreMethod.textboxenter(driver, "Id", control_Id.email, input.emailvalue);
			coreMethod.textboxenter(driver, "Id", control_Id.mobile, input.mobilevalue);
			coreMethod.textboxenter(driver, "Id", control_Id.age, input.agevalue);
			coreMethod.dropDownSelect(driver, "Id", control_Id.genderdropdown, input.gendervalue);
			coreMethod.dropDownSelect(driver, "Id", control_Id.racedropdown, input.race);
			coreMethod.textboxenter(driver, "Id", control_Id.fulladdress, input.fulladdressvalue);
			coreMethod.textboxenter(driver, "Id", control_Id.streetnumber, input.streetvalue);
			coreMethod.textboxenter(driver, "Id", control_Id.streetname, input.streetnamevalue);
			coreMethod.textboxenter(driver, "Id", control_Id.city, input.city);
			coreMethod.textboxenter(driver, "Id", control_Id.state, input.state);
			coreMethod.textboxenter(driver, "Id", control_Id.zip, input.zip);
			coreMethod.textboxenter(driver, "Id", control_Id.country, input.countryvalue);
			coreMethod.dropDownSelect(driver, "Id",control_Id.educationcheckbox, input.educationvalue);
			coreMethod.textboxenter(driver, "Id", control_Id.license, input.licensevalue);
			coreMethod.textboxenter(driver, "Id", control_Id.certification, input.certificatevalue);
			coreMethod.checkBoxSelect(driver, control_Id.areaofinterest, input.educationvalue);
			coreMethod.buttonclick(driver, "Id", control_Id.createbutton);

		}
	}
}
