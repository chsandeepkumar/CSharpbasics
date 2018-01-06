using System;

namespace CSharpArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Displaying the Elements using Arraylist ");
            ArrayListDemo arrayListDemoInstance = new ArrayListDemo();
            arrayListDemoInstance.DisplayElementsUsingArrayList();
            Console.ReadLine();
        }
    }
}
