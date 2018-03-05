using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeA = int.Parse(Console.ReadLine());
            int timeB = int.Parse(Console.ReadLine());
            int timeC = int.Parse(Console.ReadLine());

            int totalTime = timeA + timeB + timeC;

            int minutes = totalTime / 60;
            int secunds = totalTime % 60;

            Console.WriteLine($"{minutes}:{secunds:00}");



        }
    }
}
