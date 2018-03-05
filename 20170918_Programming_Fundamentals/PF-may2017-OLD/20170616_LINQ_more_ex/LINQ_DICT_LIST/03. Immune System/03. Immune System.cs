using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var initalHealth = int.Parse(Console.ReadLine());
            var virusName = Console.ReadLine();
            var virusesList = new List<string>();
            double remainingHealth = initalHealth;
            while (virusName != "end")
            {
                var virusStrenght = virusName.Select(x => (int)(x)).ToList().Sum() / 3;
                int timeToDefeate = 0;

                if (virusesList.Contains(virusName))
                {
                   timeToDefeate = virusStrenght * virusName.Length/3;
                }
                else
                {
                    timeToDefeate = virusStrenght * virusName.Length;
                }

                remainingHealth = remainingHealth - timeToDefeate;
                var regainHealth =Math.Floor( remainingHealth + (remainingHealth * 0.2));

                if (regainHealth > initalHealth)
                { regainHealth = initalHealth; }

                int minutes = (timeToDefeate / 60);
                int secunds = timeToDefeate % 60;

                Console.WriteLine($"Virus {virusName}: {virusStrenght} => {timeToDefeate} seconds");
                if (remainingHealth <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                Console.WriteLine($"{virusName} defeated in {minutes}m {secunds}s.");
                Console.WriteLine($"Remaining health: {remainingHealth}");                

                remainingHealth = regainHealth;
                virusesList.Add(virusName);

                virusName = Console.ReadLine();
                if(virusName == "end")
                    Console.WriteLine($"Final Health: {regainHealth}");
            }
            
            
        }
    }
}
