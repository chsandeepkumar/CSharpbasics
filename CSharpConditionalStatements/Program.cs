using System;

namespace CSharpConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a today Temparature");
            int userInputTemparature = Convert.ToInt16(Console.ReadLine());

            Weather myweatherObject = new Weather();

            bool output = myweatherObject.CanITakeUmbrella(userInputTemparature);

            //this below line of ? ternary operator which evaluate the output variable true or false.
            string message = (output == true) ? "Please take the umbrella" : "Please donot take the umbrella";
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
    public class Weather
    {
        public bool CanITakeUmbrella(int temarature)
        {
            if (temarature > 40)
                return true;
            else
                return false;
        }
    }
}
