using System;
using AnimalTypes;

namespace AnimalApp
{
    class Program
    {
        static void Main()
        {
            Tiger tiger = new Tiger("Shera", "Jungle", "Distinctive");
            Crocodile crocodile = new Crocodile("Snappy", "River", "Large");
            Kangaroo kangaroo = new Kangaroo("Joey", "Australia", true);

            tiger.PrintInfo();
            Console.WriteLine();
            crocodile.PrintInfo();
            Console.WriteLine();
            kangaroo.PrintInfo();
        }
    }
}