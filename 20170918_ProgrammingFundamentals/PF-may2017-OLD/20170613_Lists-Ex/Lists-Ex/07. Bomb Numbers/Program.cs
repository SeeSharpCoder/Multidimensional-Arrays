using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var bombField = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombDetails = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var bombNumber = bombDetails[0];
            var bombPower = bombDetails[1];

            for (int i = 0; i < bombField.Count; i++)
            {                            
                if (bombField[i] == bombNumber)
                {
                    var leftSide = Math.Max(i - bombPower, 0);
                    var rightSide = Math.Min(i + bombPower, bombField.Count-1);
                    var blast = (rightSide - leftSide) + 1;
                    bombField.RemoveRange(leftSide, blast);
                    i = -1;
                }
            }
            Console.WriteLine(bombField.Sum());
        }
    }
}
