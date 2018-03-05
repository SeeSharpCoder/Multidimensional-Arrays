using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;

            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n < 1 || n > 100);
        }
    }
}
