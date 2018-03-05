using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                string[] phoneParameters = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string command = phoneParameters[0];

                if (command == "A")
                {
                    string key = phoneParameters[1];
                    string value = phoneParameters[2];

                    phonebook[key] = value;                   
                }

                else
                {
                    string key = phoneParameters[1];
                    if (phonebook.ContainsKey(key))
                    {
                        Console.WriteLine($"{key} -> {phonebook[key]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {key} does not exist.");     
                    }
                }
                input = Console.ReadLine();

            }
        }
    }
}
