using System;
using System.Collections;

namespace CSharpHashTable
{
    class HashTableDemo
    {
      public static  void DisplayElementsUsingHastTable()
        {
            Hashtable customers = new Hashtable();
            customers.Add(1000, "Sandeep");
            customers.Add(2010, "Vineel");
            customers.Add(3000, "Hema");

            foreach (DictionaryEntry item in customers)
            {
                Console.WriteLine($"the Elements in the Hashtable using Forloop {item.Key}");

            }
            foreach (DictionaryEntry item in customers)
            {
                Console.WriteLine($"the Elements in the Hashtable using Forloop {item.Value}");
            }
        }
    }
}
