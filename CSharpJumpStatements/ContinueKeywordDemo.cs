using System;

namespace CSharpJumpStatements
{
    internal class ContinueKeywordDemo
    {
        public static void CallForContinueKeywordDemo()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine("The number is " + i);
            }
        }
    }
}
