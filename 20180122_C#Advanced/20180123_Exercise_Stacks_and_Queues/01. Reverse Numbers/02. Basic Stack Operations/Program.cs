using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputParameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var elemetsToPush = inputParameters[0];
            var elemetsToPop = inputParameters[1];
            var elemet = inputParameters[2];

            var numbersInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var numbers = new Stack<int>();
            

            if (elemetsToPop == numbersInput.Length)
            {
                Console.WriteLine("0");
            }

            else
         	{
                for (int i = 0; i < elemetsToPush; i++)
                { numbers.Push(numbersInput[i]);}

                for (int i = 0; i < elemetsToPop; i++)
                { numbers.Pop();}

                if (numbers.Contains(elemet))
                { Console.WriteLine("true");}

                else
                { Console.WriteLine(numbers.Min());}
            }
        }
    }
}
