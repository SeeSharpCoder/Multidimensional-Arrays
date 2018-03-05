using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var word1 = Console.ReadLine();
            var word2 = Console.ReadLine();

            var text1 = word1.ToLower();
            var text2 = word2.ToLower();

            
           
            if (text1 == text2)
            { Console.WriteLine("yes"); }

            
            else if (text1 != text2)
            { Console.WriteLine("no"); }


        }
    }
}
