using System;

namespace CSharpArrays
{
    class SingleDimensionalArrayDemo
    {
        internal static void DisplayArray()
        {
            string[] customers = new string[5];
            customers[0] = "sandeep";
            customers[1] = "hema";
            customers[2] = "Reddy";
            customers[3] = "kumar";
            customers[4] = "Raja";
         

           //Displaying elements using For Loop

            for(int startElement=0;startElement< customers.Length-1;startElement++)
            {
                Console.WriteLine($"the customer details are :  {customers[startElement]}");
            }
            Console.ReadLine();
        }

    }
}
