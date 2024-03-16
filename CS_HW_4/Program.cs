using Domain;
using System;

namespace CS_HW_4
{
    class Program
    {
        static void Main()
        {
            Builder builder = new Builder("John", 35, "residential buildings");
            builder.PrintInfo();
            builder.Build();

            Sailor sailor = new Sailor("Mike", 42, "cargo ship");
            sailor.PrintInfo();
            sailor.Sail();

            Pilot pilot = new Pilot("Alice", 30, "passenger airplane");
            pilot.PrintInfo();
            pilot.Fly();
        }
    }
}   