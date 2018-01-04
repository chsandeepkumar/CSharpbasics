using System;

namespace CSharpDefaultIfEmpty
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Displaying the output without DefaultIfEmpty");
            DefaultIfEmptyDemo _instanceDefaultIfEmpty = new DefaultIfEmptyDemo();
          var WithoutDefaultIfEmptyOutput=  _instanceDefaultIfEmpty.WithoutDefaultIfEmpty();//the output is IndextoutofRageException
            Console.WriteLine($"Displaying the output with DefaultIfEmpty {WithoutDefaultIfEmptyOutput}");
           var WithDefaultIfEmptyOutput = _instanceDefaultIfEmpty.WithDefaultIfEmpty();// the output is 0 
            Console.WriteLine($"Displaying the output with DefaultIfEmpty{WithDefaultIfEmptyOutput}");

            Console.ReadLine();
        }
    }
}
