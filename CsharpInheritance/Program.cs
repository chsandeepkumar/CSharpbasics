using System;

namespace CsharpInheritance
{
      class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I am starting in App");
            MyMethod();
          
        }
        internal static void MyMethod()
        {
            Console.WriteLine("I in MyMethod()");
        }
       protected void MyTest1()
        {
            Console.WriteLine("I in MyTest()");
            int i = 0;
        }
    }

   class MyClass : Program
    {
       void MyTest(out int number, out int number2)
        {
            number = 0;
            number2 = 20;
        }
        void MyTest2()
        {
            int firstNumber, secondNumber = 0;
            MyTest(out firstNumber, out secondNumber);

            Console.WriteLine(firstNumber+ secondNumber);
        }
       
    }
    class MyChildClass
    {
        public void MyMethod()
        {
            Program.MyMethod();
            Program.Main(null);
           
        }
    }
    
}
