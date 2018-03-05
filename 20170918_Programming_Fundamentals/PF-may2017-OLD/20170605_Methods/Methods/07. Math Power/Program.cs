using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double powered = PoweredNumber(number, power);
            Console.WriteLine(powered);
        }

         static double PoweredNumber(double number, int power)
        {
            double result = number;
            for (int i = 1; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
