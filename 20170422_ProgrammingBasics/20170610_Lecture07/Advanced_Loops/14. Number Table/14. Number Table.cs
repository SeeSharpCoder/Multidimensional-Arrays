using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    var num = i + j;

                    if (num > n)
                    {
                        num = n - (num % n);
                    }
                        Console.Write($"{num} ");
                }
                    Console.WriteLine();
            }
        }
    }
}
