using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellent_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50 && grade <=6)
            {
                Console.WriteLine("Excellent!");
            }


            else if(grade >=2 && grade <=5.49)
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
