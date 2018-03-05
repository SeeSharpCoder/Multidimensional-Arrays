using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace _09_July_2017_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternDidi = @"[^a-zA-Z\-]+";
            string patternBojo = @"[a-zA-Z]+-[a-zA-Z]+";

            var regexDidi = new Regex(patternDidi);
            var regecBojo = new Regex(patternBojo);

            string inputLine = Console.ReadLine();
            bool currentPlayerFoundMatch = true;
            int counter = 1;

            while (currentPlayerFoundMatch)
            {
                if (counter % 2 != 0)       // Didi's turn
                {
                    var match = regexDidi.Match(inputLine);

                    if (!match.Success)
                    {
                        currentPlayerFoundMatch = false;
                        continue;
                    }

                    string currentMatchFound = match.Groups[0].Value;
                    Console.WriteLine(currentMatchFound);

                    if (match.Index > 0)
                    {
                        inputLine = inputLine.Remove(0, match.Index);
                    }

                    inputLine = inputLine.Remove(0, currentMatchFound.Length);
                }
                else                          // Bojo's turn
                {
                    var match = regecBojo.Match(inputLine);

                    if (!match.Success)
                    {
                        currentPlayerFoundMatch = false;
                        continue;
                    }

                    string currentMatchFound = match.Groups[0].Value;
                    Console.WriteLine(currentMatchFound);

                    if (match.Index > 0)
                    {
                        inputLine = inputLine.Remove(0, match.Index);
                    }

                    inputLine = inputLine.Remove(0, currentMatchFound.Length);
                }

                counter++;
            }
        }
    }
}
