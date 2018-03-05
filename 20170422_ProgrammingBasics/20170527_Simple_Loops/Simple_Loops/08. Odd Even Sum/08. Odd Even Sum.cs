using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var evenSum = 0;
            var oddSum = 0;
            for (int i = 0; i < n; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                { evenSum += currentNum; }
               
                else
                { oddSum += currentNum; }
            

                   
            }
              if (evenSum == oddSum)
                { Console.WriteLine("Yes Sum = {0}", evenSum); }
           
              else
                { Console.WriteLine("No diff = {0}", Math.Abs(evenSum-oddSum)); }

        }
    }
}
