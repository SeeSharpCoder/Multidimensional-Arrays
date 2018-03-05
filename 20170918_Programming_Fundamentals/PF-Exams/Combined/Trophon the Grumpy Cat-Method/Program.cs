﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Trophon_the_Grumpy_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

            int targetIndex = int.Parse(Console.ReadLine());
            string size = Console.ReadLine();
            string type = Console.ReadLine();

            long leftSum = numbers.Take(targetIndex)
            .Where(num => IsValid((int)num, (int)numbers[targetIndex], size, type)).Sum();

            long rightSum = numbers.Skip(targetIndex + 1)
                .Where(num => IsValid((int)num, (int)numbers[targetIndex], size, type)).Sum();

            Console.WriteLine(leftSum >= rightSum ? "Left - " + leftSum : "Right - " + rightSum);
        }

        public static bool IsValid(int number, int targetNumber, string size, string type)
        {
            if (size == "cheap")
            {
                if (targetNumber > number)
                {
                    return IsValidType(number, size, type);
                }
            }
            else
            {
                if (targetNumber <= number)
                {
                    return IsValidType(number, size, type);
                }
            }

            return false;
        }

        public static bool IsValidType(int number, string size, string type)
        {
            if (type == "positive")
            {
                if (number > 0)
                {
                    return true;
                }
                return false;
            }

            if (type == "negative")
            {
                if (number < 0)
                {
                    return true;
                }
                return false;
            }

            return true;

        }
    }
}
