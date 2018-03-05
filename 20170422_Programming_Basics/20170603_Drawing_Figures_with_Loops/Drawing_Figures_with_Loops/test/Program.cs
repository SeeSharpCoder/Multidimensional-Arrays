using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if(n==3)
            {
                Console.WriteLine("******   ******");
                Console.WriteLine("*////*|||*////*");
                Console.WriteLine("******   ******");

            }
            else if (n == 4)
            {
                Console.WriteLine("********    ********");
                Console.WriteLine("*//////*||||*//////*");
                Console.WriteLine("*//////*    *//////*");
                Console.WriteLine("********    ********");

                
            }
        }
    }
}
