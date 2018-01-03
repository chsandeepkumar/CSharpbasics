using System;

namespace CSharpPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorOperations myCalcopeationInstance = new CalculatorOperations();
          var result=  myCalcopeationInstance.Addition(1,2);
            Console.WriteLine("sum of two integer values"+result);

            var result1=myCalcopeationInstance.Addition(1.0m, 1.0m);
            Console.WriteLine("sum of two decimal values" + result1);

            Console.ReadLine();
        }
    }
}
