using System;

namespace IntegerConversions
{

   internal class Program
    {
        private int mynumber = 0;
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Any Name");

            string input = Console.ReadLine();

            int.TryParse(input, out int result);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        //Public or private +Static or Non Static+Return Type+MethodName(datatype ParamterName)
       // {
       //logic
     //   }
    }

    
}
