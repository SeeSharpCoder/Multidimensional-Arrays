using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var operation = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            inputNums.RemoveRange(operation[0], inputNums.Count - operation[0]);
            inputNums.RemoveRange(0, operation[1] );


           // for (int i = 0; i < operation[0]; i++)
           // {
           //     currentList.Add(inputNums[i]);
           // }
           // for (int i = 0; i < operation[1]; i++)
           // {
           //     currentList.RemoveAt(0);
           // }

            if(inputNums.Contains(operation[2]))
            {
                Console.WriteLine("YES!");
                return;
            }
            Console.WriteLine("NO!");
        }
    }
}
