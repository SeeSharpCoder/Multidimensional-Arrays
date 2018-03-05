using System;

class StartUp
{
    static void Main()
    {
        Person info = new Person();

        info.Name = "Pesho";
        info.Age = 20;

        Console.WriteLine($"Name {info.Name}, age {info.Age}");

    }
}

