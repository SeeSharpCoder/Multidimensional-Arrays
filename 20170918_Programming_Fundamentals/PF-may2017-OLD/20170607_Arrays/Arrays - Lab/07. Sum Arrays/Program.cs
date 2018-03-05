using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] nums2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] sum = new int[Math.Max(nums1.Length, nums2.Length)];

            for (int i = 0; i < Math.Max(nums1.Length , nums2.Length); i++)
            {
               sum[i] = nums1[i % nums1.Length] + nums2[i % nums2.Length];
            }
            Console.WriteLine(String.Join(" ",sum));

            //nums1[i % nums1.Length] se izpolzva za da zapylni lipsvashtite pozicii, vzimaiki 0,1,2... poziciq dokato izravni dyljinata na matricite
        }
    }
}
