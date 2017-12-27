using System;

namespace CSharpJumpStatements
{
    class BreakKeywordDemo
    {
        public static void CallForBreakDemo()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine("The number is " + i);
            }
        }

    }
}
