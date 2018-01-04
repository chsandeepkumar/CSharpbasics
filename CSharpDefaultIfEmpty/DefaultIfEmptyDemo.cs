using System;
using System.Collections.Generic;
using System.Linq;
namespace CSharpDefaultIfEmpty
{
    class DefaultIfEmptyDemo
    {
        List<Student> studentsList = null;
        public DefaultIfEmptyDemo()
        {
           studentsList = new List<Student>
            {
               new Student{Name="Sandeep",Age=30},
               new Student{Name="Kumar",Age=40},
               new Student{Name="Hema",Age=45}
            };
        }

        public  string WithoutDefaultIfEmpty()
        {
           
            //Query the collection studentsList where student age greater than 50 (age>50)
            //Generally the query will return zero records because there is no student record whose age >50
            // the below code throws an exception saying that IndexoutofRange exception.
            try
            {
                string[] studentNames = studentsList.AsQueryable()
                                       .Where(student => student.Age >= 50)
                                       .Select(student => student.Name).ToArray();
                return studentNames[0];
            }
            catch (IndexOutOfRangeException exception)
            {
                //here if the studentNames array is empty, accessing the empty array with zero indext throws an exception that
                return exception.Message;
            }
        }

        public string WithDefaultIfEmpty()
        {
            string[] studentNames = studentsList.AsQueryable()
                                       .Where(student => student.Age >= 50)
                                       .Select(student => student.Name)
                                       .DefaultIfEmpty(" No Record Found").ToArray();//it will retrun empty collection if the records not match. with this we can avoid null reference check and cleanner coding.

            return studentNames[0];
        }
    }
}
