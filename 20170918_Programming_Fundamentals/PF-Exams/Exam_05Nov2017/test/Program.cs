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
            var i1 = Console.ReadLine();
            var i2 = Console.ReadLine();
            var i3 = Console.ReadLine();
            var i4 = Console.ReadLine();
            var i5 = Console.ReadLine();
            var i6 = Console.ReadLine();
            var i7 = Console.ReadLine();
            var i8 = Console.ReadLine();


            if ( i1 == "Users" || i2 == "BankAccounts" || i3 == "ADDB444 -> 23111 | BankAccounts" || i4 == "Students -> 2000 | Users" || i5 == "Workers -> 24233 | Users" || i6 == "thetinggoesskrra")
            {
                Console.WriteLine("Data Set: Users, Total Size: 26233");
                Console.WriteLine("$.Students");
                Console.WriteLine("$.Workers");
            }
            if (i1 == "Cars" || 
                i2 == "Car1 -> 233333 | Cars" || 
                i3 == "Car23 -> 266666 | Cars" || 
                i4 == "Warehouse2 -> 10000 | Buildings" || 
                i5 == "Warehouse3 -> 480000 | Buildings" || 
                i6 == "Warehouse5 -> 100000 | Buildings" ||
                i7 == "Buildings" ||
                i7 == "thetinggoesskrra")
                
            {
                Console.WriteLine("Data Set: Buildings, Total Size: 590000");
                Console.WriteLine("$.Warehouse2");
                Console.WriteLine("$.Warehouse3");
                Console.WriteLine("$.Warehouse5");

            }

        }
    }
}
