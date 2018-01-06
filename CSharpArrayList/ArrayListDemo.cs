using System;
using System.Collections;

namespace CSharpArrayList
{
    class ArrayListDemo
    {
      public void DisplayElementsUsingArrayList()
        {
            
            ArrayList customers = new ArrayList();
            customers.Add("Sandeep");
            customers.Add(123456789);
            customers.Add(1400.0m);

            for(int startitem=0;startitem<customers.Count;startitem++)
            {
                Console.WriteLine($"the Elements in the arralist using Forloop {customers[startitem]}");
            }
            foreach (var item in customers)
            {
                Console.WriteLine($"the Elements in the arralist are using ForEach {item}");
            }
            Console.ReadLine();
        }
    }
   
}
