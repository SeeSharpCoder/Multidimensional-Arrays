using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine().Split(' ').Select(a => int.Parse(new string(a.Reverse().ToArray()))).Sum());

           // var inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           //
           // for (int i = 0; i < inputNums.Length; i++)
           // {
           //     var currentNum = inputNums[i];
           //     var currentNumToStr = currentNum.ToString();
           //     var reversedNumToArr = currentNumToStr.Reverse().ToArray();
           //     var reversedNum = new string(reversedNumToArr);
           //     inputNums[i] = int.Parse(reversedNum);
           //  }
           // Console.WriteLine(inputNums.Sum());
        }
    }
}
