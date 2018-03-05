using System;
using System.Linq;
using System.Numerics;


namespace Sino_The_Walker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] startingTime = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            BigInteger steps = int.Parse(Console.ReadLine());
            BigInteger seconds = int.Parse(Console.ReadLine());

            BigInteger[] arrTime = new BigInteger[3];
            BigInteger walkTime = steps * seconds;
            BigInteger timeInSec = startingTime[0] * 3600 + startingTime[1] * 60 + startingTime[2];
            BigInteger arrTimeInSec = timeInSec + walkTime;

            arrTime[0] = (arrTimeInSec / 3600) % 24;
            arrTime[1] = (arrTimeInSec / 60) % 60;
            arrTime[2] = arrTimeInSec % 60;

            Console.WriteLine("Time Arrival: {0:D2}:{1:D2}:{2:d2}", arrTime[0], arrTime[1], arrTime[2]);


        }
    }
}