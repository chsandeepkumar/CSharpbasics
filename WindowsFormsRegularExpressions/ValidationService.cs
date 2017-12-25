namespace WindowsFormsRegularExpressions
{
   internal class ValidationService
    {
        internal static bool DoesUserInputValid(User user)
        {
            if (string.IsNullOrWhiteSpace(user.EmailId)) return false;
            if (string.IsNullOrWhiteSpace(user.Phoneumber)) return false;
            if (string.IsNullOrWhiteSpace(user.Zipcode)) return false;

            return ((RegularExpressionUtility.IsValidPhoneNumber(user.Phoneumber, "USA")) &&
                RegularExpressionUtility.IsValidEmaildPattern(user.EmailId) &&
                RegularExpressionUtility.IsValidZipcodePattern(user.Zipcode));
        }
    }
}
