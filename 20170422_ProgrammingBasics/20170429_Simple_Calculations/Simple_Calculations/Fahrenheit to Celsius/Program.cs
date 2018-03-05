using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fahrenheit= ");
            var Fahrenheit = double.Parse(Console.ReadLine());
            var Celsius = Math.Round(((Fahrenheit - 32) * 0.555556), 2);
            Console.WriteLine("Celsius= {0}", Celsius);
            
        }
    }
}
