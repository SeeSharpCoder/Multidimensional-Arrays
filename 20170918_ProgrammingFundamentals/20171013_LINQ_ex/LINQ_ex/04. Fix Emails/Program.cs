using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesEmails = new Dictionary<string, string>();
            var input = Console.ReadLine();

            while (input != "stop")
            {
                var name = input;
                var email = Console.ReadLine();

                namesEmails[name] = email;

                input = Console.ReadLine();
            }
            var fixedEmails = namesEmails.Where(kvp => !(kvp.Value.EndsWith("us") || kvp.Value.EndsWith("uk"))).ToDictionary(kvp => kvp.Key , kvp => kvp.Value);
            foreach (var nameEmail in fixedEmails)
            {
                var name01 = nameEmail.Key;
                var email01 = nameEmail.Value;
                Console.WriteLine($"{name01} -> {email01}");
            }
 
            
        }
    }
}
