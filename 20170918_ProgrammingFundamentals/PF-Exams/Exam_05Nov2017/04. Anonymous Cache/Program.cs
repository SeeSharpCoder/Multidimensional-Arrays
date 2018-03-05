using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var myDict = new Dictionary<string, Dictionary<string, long>>();
            var cashed = new Dictionary<string, Dictionary<string, long>>();

            while (input != "thetinggoesskrra")
            {
                var dataKeySizeSet = input.Split(new string[] { "->", "|" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                string dataSet = string.Empty;
                long dataSize = 0;
                string dataKey = string.Empty;

                if (dataKeySizeSet.Length > 1)
                {
                    dataKey = dataKeySizeSet.First();
                    dataSize = long.Parse(dataKeySizeSet[1]);
                    dataSet = dataKeySizeSet.Last();
                }
                else
                { dataSet = dataKeySizeSet.Last(); }


                if (!myDict.ContainsKey(dataSet) && dataKeySizeSet.Length == 1)
                {
                    myDict.Add(dataSet, new Dictionary<string, long>());
                }

                if (dataKeySizeSet.Length > 1 && myDict.ContainsKey(dataSet))
                {
                    myDict[dataSet].Add(dataKey, dataSize);
                }
                else if (dataKeySizeSet.Length > 1 && !myDict.ContainsKey(dataSet))
                {
                    if (!cashed.ContainsKey(dataSet))
                    {
                        cashed.Add(dataSet, new Dictionary<string, long>());
                    }
                    cashed[dataSet].Add(dataKey, dataSize);
                }

                foreach (var keyMyDict in myDict.Keys)
                {
                    foreach (var keyCashed in cashed.Keys)
                    {
                        if (keyMyDict == keyCashed)
                        {
                            myDict[keyMyDict].Add(key , value);
                        }
                    }
                }






                Console.WriteLine();



                input = Console.ReadLine();
            }

            Console.WriteLine();

        }
    }
}
