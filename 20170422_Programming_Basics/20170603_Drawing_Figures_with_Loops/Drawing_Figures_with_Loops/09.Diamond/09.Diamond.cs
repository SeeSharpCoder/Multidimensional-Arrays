using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftRight = (n - 1) / 2;
            var mid = n - 2 * leftRight - 2;
            if (n == 1)
            { Console.WriteLine("*"); }

            else
            {
                if (mid == 0)
                {

                    for (int i = 0; i <= n / 2 - 1; i++)
                    {
                        Console.WriteLine("{0}*{1}*{0}", (new string('-', leftRight - i)), (new string('-', 2 * i)));
                    }
                    for (int i = n / 2 - 2; i >= 0; i--)
                    {
                        Console.WriteLine("{0}*{1}*{0}", (new string('-', leftRight - i)), (new string('-', 2 * i)));
                    }
                }

                else if (mid < 0)
                {
                    Console.WriteLine("{0}*{0}", (new string('-', leftRight)));
                    for (int i = 1; i < n / 2 + 1; i++)
                    {
                        Console.WriteLine("{0}*{1}*{0}", (new string('-', leftRight - i)), (new string('-', 2 * i - 1)));
                    }
                    for (int i = n / 2 - 1; i >= 1; i--)
                    {
                        Console.WriteLine("{0}*{1}*{0}", (new string('-', leftRight - i)), (new string('-', 2 * i - 1)));
                    }
                    Console.WriteLine("{0}*{0}", (new string('-', leftRight)));
                }
            }
        }
    }
}
