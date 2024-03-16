using System;
using AnimalsBase;

namespace AnimalTypes
{
    public class Tiger : Animal
    {
        public string StripesPattern { get; }

        public Tiger(string name, string habitat, string stripesPattern)
            : base(name, habitat)
        {
            StripesPattern = stripesPattern;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Stripes Pattern: {StripesPattern}");
        }
    }

    public class Crocodile : Animal
    {
        public string JawSize { get; }

        public Crocodile(string name, string habitat, string jawSize)
            : base(name, habitat)
        {
            JawSize = jawSize;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Jaw Size: {JawSize}");
        }
    }

    public class Kangaroo : Animal
    {
        public bool HasPouch { get; }

        public Kangaroo(string name, string habitat, bool hasPouch)
            : base(name, habitat)
        {
            HasPouch = hasPouch;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Has Pouch: {HasPouch}");
        }
    }
}