using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            // Both variations are EQUAL
            Action<string[]> action = Print;
            action(input);

            Console.WriteLine();

            // Both variations are EQUAL
            //Action<string[]> lambdaAction = arr => Console.WriteLine(string.Join(Environment.NewLine, arr));
            //lambdaAction(input);
        }
        public static void Print(string[] array)
        {
            Console.WriteLine(string.Join(Environment.NewLine, array));
        }
    }
}
