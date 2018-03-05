using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rightSum = 0;
            var leftSum = 0;

            for (int i = 0; i < n; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }

            if (rightSum == leftSum)
            { Console.WriteLine("Yes, sum = {0}", leftSum); }

            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(rightSum - leftSum));
            }



        }
    }
}
