using System;

namespace CSharpClassDemo.Classes
{
    internal class Student
    {
        //AccessSpecfier+ReturnType+ MethodName(datype paramtername)
        // //AccessSpecfier+static +ReturnType+ MethodName(datype paramtername)
        public Student()
        {
            Console.WriteLine("Hello I am in Constructor");
        }
        public   string AttendTheClass(int PayingMoney)
        {
            return "Knoweledge";
        }
      public   static void AttendingClass()
        {

        }
    }
}
