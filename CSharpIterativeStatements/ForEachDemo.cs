using System;

namespace CSharpIterativeStatements
{
    class ForEachDemo
    {
        public static void CallForEachMethod(string[] customersdetails,string input)
        {
            Console.WriteLine("----------Output using Foreach loop----------");
            foreach (string name in customersdetails)
            {

                if (name != null && name.Contains(input))
                {
                    Console.WriteLine(name + " name found");
                }
                else
                {
                    Console.WriteLine(input + " name Not found");

                }

            }
        }

    }
}
