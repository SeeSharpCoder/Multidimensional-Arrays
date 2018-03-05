using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            var inches = double.Parse(Console.ReadLine());
            var centimetes = inches * 2.54;
            Console.Write("Centimetes = ");
            Console.WriteLine(centimetes);
           
        }
    }
}
