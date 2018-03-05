using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberQueries = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxStack = new Stack<int>();
            maxStack.Push(int.MinValue);


            for (int i = 0; i < numberQueries; i++)
            {
                var inputQueries = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                switch (inputQueries[0])
                {
                    case 1:
                        var element = inputQueries[1];
                        stack.Push(element);
                        if (element >= maxStack.Peek())
                        {
                            maxStack.Push(element);
                        }
                        break;
                    case 2:
                        var poppedElement = stack.Pop();
                        if (maxStack.Peek() == poppedElement)
                        {
                            maxStack.Pop();
                        }
                        break;

                    case 3:
                        int maxElement = maxStack.Peek();
                        Console.WriteLine(maxElement);

                        break;
                }
            }
        }
    }
}
