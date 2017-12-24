using System;

namespace CSharpConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a today Temaparature");
            int userInputTemparature = Convert.ToInt16(Console.ReadLine());
            Weather myweatherObject = new Weather();
            bool output = myweatherObject.CanITakeUmbrella(userInputTemparature);
            string message = (output == true) ? "Please take the umbrella" : "Please donot take the umbrella");
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
