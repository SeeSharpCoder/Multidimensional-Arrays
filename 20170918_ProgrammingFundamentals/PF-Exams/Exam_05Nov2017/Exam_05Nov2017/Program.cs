using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exam_05Nov2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var securityTokens = int.Parse(Console.ReadLine());

            decimal totalLoss = 0.0M;

            for (int i = 0; i < n; i++)
            {
                var websitesInfo = Console.ReadLine().Split(' ').Select(x => x.Trim()).Where(x => x != "").ToArray();

                var siteName = websitesInfo[0];
                long siteVisits = long.Parse(websitesInfo[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(websitesInfo[2]);

                decimal siteLoss = siteVisits * siteCommercialPricePerVisit;
                totalLoss += siteLoss;
                Console.WriteLine(siteName);
            }

            BigInteger token = securityTokens;

            for (int i = 1; i < n; i++)
            {
                token *= (BigInteger)securityTokens ;
            }

            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {token}");

        }
    }
}
