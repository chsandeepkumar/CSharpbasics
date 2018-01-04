using System;
using CSharpClassDemo.Classes;

namespace CSharpClassDemo
{

    class Program
    {
        static void Main(string[] args)
        {
           
            string output = Trainer.GivingTraining(100);
            Console.WriteLine("Sandeep is giving " + output);
            
            Student _studentObject = new Student(); 
           string output1= _studentObject.AttendTheClass(100);
            Console.WriteLine("Deepa is Getting " + output1);

            GuestStudent _guestStudent = new GuestStudent();
            string output2= _guestStudent.AttendTheClass(100);
            Console.WriteLine("Prathyusha is Getting " + output2);

         
            Console.ReadLine();

        }
    }
}