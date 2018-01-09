using System;

namespace CSharpStaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int result=MathOperations.Add(1, 2);
            Console.WriteLine("the Sum of Two number are {0}", result);
        }
    }
}
