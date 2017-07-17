using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkNewark2020
{
	class input
	{
		//login input
		public static string usernameValue = "anil developer";
		public static string passvalue = "123456";

		//register input
		public static Random randomGenartor = new Random();
		public static int randomInt = randomGenartor.Next(100);
		public static string username = "Jack" + randomInt;
		public static string email = "Jack" + randomInt + "@gmail.com";
		public static string unamevalue = username;
		public static string pvalue = "Test@12345";
		public static string firstnamevalue = "John";
		public static string middlenamevalue = "p";
		public static string lastnamevalue = "Killer";
		public static string emailvalue = email;
		public static string mobilevalue = "6667778888";
		public static string agevalue = "20";
		public static string gendervalue = "Male";
		public static string race = "Asian";
		public static string fulladdressvalue = "san diego";
		public static string streetvalue = "111";
		public static string streetnamevalue = "el cajon";
		public static string city = "san diego";
		public static string state = "CA";
		public static string zip = "92021";
		public static string countryvalue = "united states";
		public static string educationvalue = "Post-graduate degree";
		public static string licensevalue = " no license";
		public static string certificatevalue = "no certificate";
	}
}
