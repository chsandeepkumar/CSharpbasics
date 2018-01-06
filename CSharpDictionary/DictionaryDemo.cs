using System;
using System.Collections.Generic;

namespace CSharpDictionary
{
    class DictionaryDemo
    {
        public void DisplayElementsUsingDictionary()
        {

            Dictionary<int, string> customers = new Dictionary<int, string>();
            customers.Add(1000, "Sandeep");
            customers.Add(2010, "Vineel");
            customers.Add(3000, "Hema");

            foreach (var item in customers)
            {
                Console.WriteLine($"the Elements in Dictionary are {item}");
            }
            foreach (var item in customers)
            {
                Console.WriteLine($"the key of Elements in Dictionary are {item.Key}");
            }
            foreach (var item in customers)
            {
                Console.WriteLine($"the key of Elements in Dictionary are {item.Value}");
            }
           

        }
    }
}
