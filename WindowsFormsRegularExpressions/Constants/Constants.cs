namespace WindowsFormsRegularExpressions
{
    public struct Constants
    {
        public const string EmailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
        public const string ZipCodePattern = @"^[0-9]{5}$";
      public const  string USAphonePattern = @"^[2-9]\d{2}-\d{3}-\d{4}$";
                                                                                // ^[2-9]\d{2}-\d{3}-\d{4}$
    }
    public struct CountryNames
    {
        public const string USA = "USA";
    }
    
}
