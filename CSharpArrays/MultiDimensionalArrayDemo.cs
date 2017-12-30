using System;

namespace CSharpArrays
{
    class MultiDimensionalArrayDemo
    {
        internal static void DisplayArray()
        {
            string[,] customers = new string[5,5];
            customers[0,0] = "sandeep";
            customers[0,1] = "hema";
            customers[0,2] = "Reddy";
            customers[0,3] = "kumar";
            customers[0,4] = "Raja";
            foreach (var item in customers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
