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
            int time = int.Parse(Console.ReadLine());            
           
            int hours = time / 3600;
            int minutes = time / 60; //?????
            int secunds = time % 60;

            Console.WriteLine($"{hours:00}:{minutes:00}:{secunds:00}");



        }
    }
}
