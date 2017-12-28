using System;

namespace CSharpExceptionsHandling
{
    class DataAccessLayer
    {
        public static int GetNumber(string input)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
