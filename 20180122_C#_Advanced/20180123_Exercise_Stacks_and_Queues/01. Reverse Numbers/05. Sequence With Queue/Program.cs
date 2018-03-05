using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_With_Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = long.Parse(Console.ReadLine());

            var firstQueue = new Queue<long>();
            firstQueue.Enqueue(input);
            var secondQueue = new Queue<long>();
            long first = 0;
            long second = 0;
            long third = 0;

            for (int i = 0; i < 17; i++)
            {
                first =  firstQueue.Peek() + 1;
                firstQueue.Enqueue(first);
                secondQueue.Enqueue(first);
                

                second = 2 * firstQueue.Peek() + 1;
                firstQueue.Enqueue(second);
                secondQueue.Enqueue(second);
                

                third = firstQueue.Dequeue() + 2;              
                firstQueue.Enqueue(third);
                secondQueue.Enqueue(third);

            }
            Console.Write($"{input} ");

            for (int i = 0; i < 49; i++)
            {
                Console.Write($"{secondQueue.Dequeue()} ");
            }
            Console.WriteLine();

        }
    }
}
