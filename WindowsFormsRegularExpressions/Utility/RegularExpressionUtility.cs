using System;
using System.Text.RegularExpressions;

namespace WindowsFormsRegularExpressions
{
    internal class RegularExpressionUtility
    {
        internal static bool IsValidPhoneNumber(string number,string countryName)
        {
            return Regex.IsMatch(number, GetphoneNumberPattern(countryName));
        }
        internal static bool IsValidEmaildPattern(string emailId)
        {
            return Regex.IsMatch(emailId, Constants.EmailPattern);
        }
        internal static bool IsValidZipcodePattern(string zipCode)
        {
            return Regex.IsMatch(zipCode, Constants.ZipCodePattern);
                 
        }

        private static string GetphoneNumberPattern(string countryName)
        {
           switch(countryName)
            {
                case CountryNames.USA: return Constants.USAphonePattern;
                default: return Constants.USAphonePattern;
            }
        }
    }
}
