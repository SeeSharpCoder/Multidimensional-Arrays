using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            var specialNumber = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());

            for (int i = m; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                        var number = (i * 100) + (j * 10) + k;

                        if (number % 3 == 0) specialNumber += 5;
                        else if (number % 10 == 5) specialNumber -= 2;
                        //else if (k == 5) specialNumber -= 2;    sushtoto e kato gorniq red
                        else if (number % 2 == 0) specialNumber *= 2;

                        if (specialNumber >= controlNumber)
                            break;
                    }
                    if (specialNumber >= controlNumber)
                        break;
                }
                if (specialNumber >= controlNumber)
                    break;
            }

            if (specialNumber >= controlNumber)
                Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
            else
                Console.WriteLine($"No! {specialNumber} is the last reached special number.");



        }
    }
}
