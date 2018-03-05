using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> longestSubSequence = new List<int>();
            List<int> currentSubSequence = new List<int>();

            currentSubSequence.Add(inputNums[0]);

            for (int i = 1; i < inputNums.Count; i++)
            {
                if(inputNums[i] == currentSubSequence[0])
                {
                    currentSubSequence.Add(inputNums[i]);
                }
                else
                {
                    if(currentSubSequence.Count > longestSubSequence.Count)
                    {
                        longestSubSequence.Clear();
                        //for (int j = 0; j < currentSubSequence.Count; j++)
                        //{
                        //    longestSubSequence.Add(currentSubSequence[j]);
                        //}
                        longestSubSequence.AddRange(currentSubSequence);
                    }
                    currentSubSequence.Clear();
                    currentSubSequence.Add(inputNums[i]);
                }
            }
            if (currentSubSequence.Count > longestSubSequence.Count)
            {
                longestSubSequence.Clear();
                longestSubSequence.AddRange(currentSubSequence);
            }
            Console.WriteLine(string.Join(" ", longestSubSequence));
        }
    }
}
