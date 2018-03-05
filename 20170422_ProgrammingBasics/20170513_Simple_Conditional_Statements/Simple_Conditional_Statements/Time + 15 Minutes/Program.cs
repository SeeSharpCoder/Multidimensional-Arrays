using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

          
                int sumOfMinutes = (hours * 60) + minutes;
                sumOfMinutes = sumOfMinutes + 15;

                int resultHour = sumOfMinutes / 60;
                int resultMinutes = sumOfMinutes % 60;
            

            Console.WriteLine($"{resultHour % 24}:{resultMinutes:D2}");

        }
    }
}
