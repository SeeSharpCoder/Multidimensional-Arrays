using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_after_birth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime bitrhday = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            DateTime answer = bitrhday.AddDays(999);
            Console.WriteLine("{0:dd-MM-yyyy}", answer);
        }
    }
}
