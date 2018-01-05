using System;
using System.Collections.Generic;

namespace CSharpList
{
   internal class ListDemo
    {
       internal void  DisplayListElements()
        {
          //  string[] customers = new string[5];
            List<string> customers = new List<string>();
            customers.Add("Sandeep");
            customers.Add("Vineel");
            customers.Add("Raja");
            customers.Add("Hema");
            for(int startElement=0;startElement<customers.Count;startElement++)
            {
                Console.WriteLine($"the values are in the List is {customers[startElement]}");
            }
            customers.Remove("Sandeep");
            for (int startElement = 0; startElement < customers.Count ; startElement++)
            {
                Console.WriteLine($"the values after removing are in the List is {customers[startElement]}");
            }
        }
    }
}
