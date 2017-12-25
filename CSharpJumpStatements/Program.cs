using System;

namespace CSharpJumpStatements
{
    class Program
    {
        // static int a = 0;
        static void Main(string[] args)
        {
            //return key importance

            Console.WriteLine("Enter any number");
            int mynumber = GetInputFromConsole();
            Console.WriteLine("User Entered input is " + mynumber);
            Console.ReadLine();
        }

        static int GetInputFromConsole()
        {
            if (string.IsNullOrWhiteSpace(Console.ReadLine())) return 0;
            return Convert.ToInt16(Console.ReadLine());
        }
    }
}
