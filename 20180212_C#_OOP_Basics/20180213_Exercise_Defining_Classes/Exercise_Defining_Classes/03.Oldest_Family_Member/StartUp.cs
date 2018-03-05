using System;
using System.Linq;


class StartUp
{
    static void Main(string[] args)
    {
        Family family = new Family();

        var n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var age = int.Parse(input[1]);
            Person person = new Person(name, age);
            family.AddMember(person);
            n--;
        }

        var oldestMember = family.GetOldestMember();

        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");

    }
}

