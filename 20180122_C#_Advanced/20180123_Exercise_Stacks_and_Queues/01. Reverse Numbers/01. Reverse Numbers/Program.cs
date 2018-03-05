using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<string>(input);

            
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{stack.Pop()} ");
            }
            Console.WriteLine();
        }
    }
}
