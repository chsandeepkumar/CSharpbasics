using System;

namespace IdentifyCharcterType
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char c = (char)Console.Read();
            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                {
                    Console.WriteLine("The character is lowercase.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The character is uppercase.");
                }
            }
            else
            {
                Console.WriteLine("The character isn't an alphabetic character.");
            }
            Console.ReadLine();
        }
    }

}
