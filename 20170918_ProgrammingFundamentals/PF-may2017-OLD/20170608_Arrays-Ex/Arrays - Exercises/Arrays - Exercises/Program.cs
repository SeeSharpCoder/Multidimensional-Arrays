using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var text1 = Console.ReadLine().Split(' ').ToArray();
            var text2 = Console.ReadLine().Split(' ').ToArray();
            
            var arrLenght = Math.Min(text1.Length, text2.Length);
            var leftRight = 0;
            var rightLeft = 0;
            for (int i = 0; i < arrLenght; i++)
            {
                if(text1[i] == text2[i])
                { leftRight++; }

                if (text1[text1.Length-1-i] == text2[text2.Length - 1 - i])
                { rightLeft++; }
            }           
            Console.WriteLine(Math.Max(leftRight, rightLeft));
        }
    }
}
