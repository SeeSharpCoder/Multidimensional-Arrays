using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputParameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var elemetsToEnqueue = inputParameters[0];
            var elemetsToDequeue = inputParameters[1];
            var elemet = inputParameters[2];

            var numbersInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var numbers = new Queue<int>();


            if (elemetsToDequeue == numbersInput.Length)
            {
                Console.WriteLine("0");
            }

            else
            {
                for (int i = 0; i < elemetsToEnqueue; i++)
                { numbers.Enqueue(numbersInput[i]); }

                for (int i = 0; i < elemetsToDequeue; i++)
                { numbers.Dequeue(); }

                if (numbers.Contains(elemet))
                { Console.WriteLine("true"); }

                else
                { Console.WriteLine(numbers.Min()); }
            }
        }
    }
}
