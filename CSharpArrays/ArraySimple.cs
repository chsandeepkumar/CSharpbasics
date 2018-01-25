using System;

namespace CSharpArrays
{
    class ArraySimple
    {
        public static void DisplayArray()
        {
            int[] arrayname = new int[10];

            for (int i = 0; i <= arrayname.Length - 1; i++)
            {
                arrayname[i] = 2;
            }
            Console.WriteLine(arrayname[0].ToString());
            Console.ReadLine();
        }
    }
}
