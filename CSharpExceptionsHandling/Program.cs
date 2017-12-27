using System;

namespace CSharpExceptionsHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter Any Name");

                int number = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("output is" + number);
                Console.ReadLine();
            }
            catch (FormatException exception)
            {
                Console.WriteLine("exception occured " + exception.Message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception occured " + ex.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("ALl resources are closed");
                GC.Collect();
            }
        }
    }
}
