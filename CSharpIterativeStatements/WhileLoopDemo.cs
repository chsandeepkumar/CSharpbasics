using System;

namespace CSharpIterativeStatements
{
    class WhileLoopDemo
    {
        public static void CallForWhileLoop(string[] customersdetails, string input)
        {
            Console.WriteLine("----------Output using While loop----------");

            int i = 0;
            while(i<customersdetails.Length-1)
            {

                if (customersdetails[i] != null && customersdetails[i].Contains(input))
                {
                    Console.WriteLine(customersdetails[i] + " name found");
                }
                else
                {
                    Console.WriteLine(input + " name Not found");
                }
                i++;
            }
        }
    }
}
