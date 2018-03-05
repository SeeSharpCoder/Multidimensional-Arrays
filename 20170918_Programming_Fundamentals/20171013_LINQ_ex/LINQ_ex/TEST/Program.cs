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
            Dictionary<string, int> resources = new Dictionary<string, int>();

            //string input = Console.ReadLine();
            resources["a"] = 1;
            resources["b"] = 2;

            Console.WriteLine(string.Join(", ",resources) );
        }
    }
}
