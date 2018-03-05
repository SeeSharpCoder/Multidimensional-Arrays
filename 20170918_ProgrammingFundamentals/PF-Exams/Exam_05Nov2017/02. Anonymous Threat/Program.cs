using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(' ').Select(x => x.Trim()).Where(x => x != "").ToList();
            var commands = Console.ReadLine();


            while (commands != "3:1")
            {
                var commandList = commands.Split(' ').Select(x => x.Trim()).Where(x => x != "").ToList();
                var command = commandList[0];
                if (command == "merge")
                {
                    var startIndex = int.Parse(commandList[1]);
                    var endIndex = int.Parse(commandList[2]);
                    if (startIndex < 0 || startIndex >= input.Count)
                    {
                        startIndex = 0;
                    }
                    if (startIndex < 0 || endIndex >= input.Count)
                    {
                        endIndex = input.Count - 1;
                    }


                    string merged = input[startIndex];

                    for (int i = startIndex; i < endIndex; i++)
                    {
                        merged += input[i+1] ;                        
                    }
                    for (int i = endIndex; i >= startIndex; i--)
                    {
                        input.RemoveAt(i);
                    }
                    input.Insert(startIndex, merged);




                }
                else if (command == "divide")
                {
                    var startIndex = int.Parse(commandList[1]);
                    var endIndex = int.Parse(commandList[2]);
                    if (startIndex < 0 || startIndex >= input.Count)
                    {
                        startIndex = 0;
                    }
                    if (startIndex < 0 || endIndex >= input.Count)
                    {
                        endIndex = input.Count - 1;
                    }




                }



                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
