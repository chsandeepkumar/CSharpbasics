using System;

namespace CSharpIterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Name of a customer");
            string input=Console.ReadLine();

            string[] customersdetails = new string[10];
            customersdetails[0] = "Sandeep";
            customersdetails[1] = "Sandeep";
            customersdetails[2] = "Prathyusha";
            customersdetails[3] = "Veenil";
           
            ForEachDemo.CallForEachMethod(customersdetails,input);
            ForLoopDemo.CallForLoop(customersdetails, input);

            Console.ReadLine();

        }
    }
}
