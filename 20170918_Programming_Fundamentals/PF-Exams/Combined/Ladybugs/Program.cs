using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfField = int.Parse(Console.ReadLine());
            var arrField = new int[sizeOfField];
            var ladybugsIndexes =
                                    Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .Where(x => x >= 0 && x < arrField.Length)
                                    .ToArray();

            var command = Console.ReadLine();

            foreach (var index in ladybugsIndexes)
            {
                arrField[index] = 1;
            }

            while (command != "end")
            {
                var commands = command.Split(' ').ToArray();

                var ladybugIndex = int.Parse(commands[0]);
                var direction = commands[1];
                var flightLenght = int.Parse(commands[2]);
                var step = flightLenght;

                while ((ladybugIndex >= 0 && ladybugIndex < sizeOfField) && arrField[ladybugIndex] == 1 && flightLenght != 0)
                {
                    if (direction == "right")
                    {
                        if (step + ladybugIndex >= arrField.Length)
                        {
                            arrField[ladybugIndex] = 0;
                            break;
                        }
                        else if (arrField[step + ladybugIndex] == 0)
                        {
                            arrField[ladybugIndex] = 0;
                            arrField[step + ladybugIndex] = 1;

                        }
                        else
                        {
                            step += flightLenght;
                        }
                    }
                    else if (direction == "left")
                    {
                        if (ladybugIndex - step < 0)
                        {
                            arrField[ladybugIndex] = 0;
                            break;
                        }
                        else if (arrField[ladybugIndex - step] == 0)
                        {
                            arrField[ladybugIndex] = 0;
                            arrField[ladybugIndex - step] = 1;

                        }
                        else
                        {
                            step -= flightLenght;
                        }
                    }

                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", arrField));

        }
    }
}
