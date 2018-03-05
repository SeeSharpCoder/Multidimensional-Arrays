using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = BigInteger.Parse(Console.ReadLine());
            var secondNum = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(firstNum * secondNum);

        }
    }
}
