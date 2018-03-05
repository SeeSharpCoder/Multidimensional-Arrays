﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            long[] seq = new long[n];
            seq[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int j = i - k; j <= i - 1; j++)
                {
                    if (j >= 0)
                    { sum += seq[j]; }

                    seq[i] = sum;
                }

            }

            Console.WriteLine(String.Join(" ",seq));

            //for (int i = 0; i < n; i++)
            //    Console.Write(seq[i] + " ");
            //Console.WriteLine();            
        }
    }
}
