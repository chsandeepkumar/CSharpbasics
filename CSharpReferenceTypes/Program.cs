using System;

namespace CSharpReferenceTypes
{
    class Program
    {
        //heap -->virtual address space--OS--RAM
        //stack-->virtual address space--OS--RAM
        //System.Object
        //int myNumber = 10;
        //string myFirstName = "Sandeep";
        static void Main(string[] args)
        {
            // myNumber.ToString();
            MyClass myClassobject = new MyClass();
            //calling method
            myClassobject.Display();


        }
    }

    public class MyClass : System.Object
    {


        //ASP+Static/NonStatic+Return Type+MethodName(datype parameter1)
        public void Display()
        {
            string myName = "Sandeep";
            int myNumber = 10;
            Console.Write(myName + myNumber);
        }
    }
}
