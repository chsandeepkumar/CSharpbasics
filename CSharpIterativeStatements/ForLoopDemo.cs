using System;

namespace CSharpIterativeStatements
{
    class ForLoopDemo
    {
        public static void CallForLoop(string [] customersdetails, string input)

        {

            for (int i = 0; i < customersdetails.Length - 1; i++)
            {

                if (customersdetails[i] != null && customersdetails[i].Contains(input))
                {
                    Console.WriteLine(customersdetails[i] + " name found");
                }
                else
                {
                    Console.WriteLine(input + " name Not found");
                }

            }
        }
    }
}
