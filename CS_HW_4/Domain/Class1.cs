using System;

namespace DevicesLibrary
{
    public class Device
    {
        public string Name { get; }
        public string Characteristics { get; }

        public Device(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Device sound");
        }
    }

    public class Kettle : Device
    {
        public Kettle(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Kettle sound");
        }
    }

    public class Microwave : Device
    {
        public Microwave(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Microwave sound");
        }
    }

    public class Car : Device
    {
        public Car(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Car sound");
        }
    }

    public class Steamship : Device
    {
        public Steamship(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Steamship sound");
        }
    }
}