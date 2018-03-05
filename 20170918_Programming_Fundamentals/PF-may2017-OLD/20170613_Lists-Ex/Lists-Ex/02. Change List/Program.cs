using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();

            while (true)
            {
                var command = Console.ReadLine().Split(' ').ToList();
                if (command[0] == "Delete")
                {
                    int delIndex1 = int.Parse(command[1]);
                    inputNums.RemoveAll(item => item == delIndex1);
                }

                else if (command[0] == "Insert")
                {
                    int insertIndex1 = int.Parse(command[1]);
                    int insertIndex2 = int.Parse(command[2]);
                    inputNums.Insert(insertIndex2, insertIndex1);
                }
                else if (command[0] == "Odd" )
                {
                    foreach (var item in inputNums)
                    {
                        if (item % 2 != 0)
                        {
                           oddList.Add(item);
                        }
                    }
                    Console.WriteLine(string.Join(" ", oddList));
                    return;
                }
                else if (command[0] == "Even")
                {
                    foreach (var item in inputNums)
                    {
                        if (item % 2 == 0)
                        {
                            evenList.Add(item);
                        }
                    }
                    Console.WriteLine(string.Join(" ", evenList));
                    return;
                }
            }             

        }
    }
}
