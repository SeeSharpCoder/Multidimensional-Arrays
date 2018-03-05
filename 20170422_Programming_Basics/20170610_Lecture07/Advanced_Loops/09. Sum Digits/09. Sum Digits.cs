using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            //  var n = int.Parse(Console.ReadLine());
            //  int sum = 0;
            //  do
            //  {
            //      int currentNumber = n % 10;
            //      n = n / 10;
            //      sum += currentNumber;
            //  } while (n > 0);
            //  Console.WriteLine(sum);

            var n = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int currentDigit = int.Parse(n[i].ToString());
                sum += currentDigit;
            }
                Console.WriteLine(sum);
        }
    }
}
