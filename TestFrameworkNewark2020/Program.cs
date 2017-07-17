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
	class Program
	{
		static void Main(string[] args)
		{
			 IWebDriver driver = new ChromeDriver(@"C:\Automation testing\Driver");

			driver.Url = @"http://122.160.12.156:8090/";
			
		   Thread.Sleep(2000);
			featureMethod.Registration(driver);
			featureMethod.login(driver);
		}
	}
}
