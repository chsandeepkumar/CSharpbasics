using System;

namespace IntegerConversions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter Any Name");

            string input = Console.ReadLine();
            int.TryParse(input, out int result);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
