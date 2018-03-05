using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation_III
{
    class Program
    {
        static void Main(string[] args)
        {

            var orders = int.Parse(Console.ReadLine());
            decimal totalPrice = 0.0M;

            for (int i = 0; i < orders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                //var orderDate = Console.ReadLine().Split('/').Select(int.Parse).ToArray(); //variant 1
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture); //variant 2

                long capsulesCount = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month); //variant 2
                //int daysInMonth = DateTime.DaysInMonth(orderDate[2],orderDate[1]); //variant 1

                decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;

                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
