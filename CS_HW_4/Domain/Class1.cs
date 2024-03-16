using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Builder.cs
    public class Builder : Human
    {
        public string Specialization { get; set; }

        public Builder(string name, int age, string specialization)
            : base(name, age)
        {
            Specialization = specialization;
        }

        public void Build()
        {
            Console.WriteLine($"{Name} is a builder specializing in {Specialization}");
        }
    }

    // Sailor.cs
    public class Sailor : Human
    {
        public string ShipType { get; set; }

        public Sailor(string name, int age, string shipType)
            : base(name, age)
        {
            ShipType = shipType;
        }

        public void Sail()
        {
            Console.WriteLine($"{Name} is a sailor on a {ShipType}");
        }
    }

    // Pilot.cs
    public class Pilot : Human
    {
        public string AircraftType { get; set; }

        public Pilot(string name, int age, string aircraftType)
            : base(name, age)
        {
            AircraftType = aircraftType;
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is a pilot of a {AircraftType}");
        }
    }
}
