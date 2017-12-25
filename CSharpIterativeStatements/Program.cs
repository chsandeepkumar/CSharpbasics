using System;

namespace CSharpIterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Name of a customer");
            string input=Console.ReadLine();

            //Initialization
            //condition
            //increment or decrement

            string[] customersdetails = new string[10];
            customersdetails[0] = "Sandeep";
            customersdetails[1] = "Sandeep";
            customersdetails[2] = "Prathyusha";
            customersdetails[3] = "Veenil";
          //  int i = 0;
            for (int i = 0; i < customersdetails.Length-1; i++)          
            {
                
                if (customersdetails[i]!=null && customersdetails[i].Contains(input))
                {
                    Console.WriteLine( customersdetails[i]+" name found");
                }
                else
                {
                    Console.WriteLine(input + " name Not found");

                }
             
            }
            Console.ReadLine();

        }
    }
}
