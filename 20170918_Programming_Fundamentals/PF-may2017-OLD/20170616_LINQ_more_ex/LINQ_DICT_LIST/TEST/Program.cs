using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = int.Parse(Console.ReadLine()); 
                //TimeSpan time = TimeSpan.FromSeconds(input);
                //Console.WriteLine($" {time.Minutes}m {time.Seconds}s.");
                //var timeee = input % 60;
                //Console.WriteLine(timeee);

                int minutes = (input / 60) % 60;
                int secunds = input % 60;
                Console.WriteLine(minutes);
                Console.WriteLine(secunds);
            }
        }
            
    }
}
