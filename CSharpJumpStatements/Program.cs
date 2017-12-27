using System;

namespace CSharpJumpStatements
{
    class Program
    {
        // static int a = 0;
        static void Main(string[] args)
        {
            //Console.WriteLine("-------------The output using Break jump statement--------------------------");
            //BreakKeywordDemo.CallForBreakDemo();
            //Console.WriteLine("-----------The output using Contnue keyword statement--------------");
            //ContinueKeywordDemo.CallForContinueKeywordDemo();
            Console.WriteLine("-----------------The below output using Contnue keyword statement----------------");
           DemoGotoKeyword.CallforGotoDemo();
            Console.ReadLine();
        }

        static int GetInputFromConsole()
        {
            if (string.IsNullOrWhiteSpace(Console.ReadLine())) return 0;
            return Convert.ToInt16(Console.ReadLine());
        }
    }
}
