using System;

namespace _02.Creating_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person info = new Person();

            info.Name = "Pesho";
            info.Age = 20;

            Console.WriteLine($"Name {info.Name}, age {info.Age}");
        }
    }
}
