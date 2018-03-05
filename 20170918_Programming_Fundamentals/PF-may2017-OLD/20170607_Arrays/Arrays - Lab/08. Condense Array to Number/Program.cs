using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var condensed = new int[nums.Length - 1];

            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = 0; j < condensed.Length -i; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                }
                    nums = condensed;
            }
                Console.WriteLine(condensed[0]);           
           
        }
    }
}
