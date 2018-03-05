using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            
            string materials = Console.ReadLine();
            
            
            while (materials != "stop")
            {
                
                int quantity = 0;
                quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(materials))
                {
                    resources[materials] += quantity;
                }
                else
                {
                    resources[materials] = quantity;
                }
                materials = Console.ReadLine();
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
