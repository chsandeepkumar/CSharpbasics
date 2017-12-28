using System;

namespace CSharpExceptionsHandling
{
    class BusinessLayer
    {
        public static int GetNumber(string input)
        {
            try
            {
                return DataAccessLayer.GetNumber(input);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
