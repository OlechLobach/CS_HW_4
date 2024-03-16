using System;

namespace InstrumentsLibrary
{
    public class MusicalInstrument
    {
        public string Name { get; }
        public string Characteristics { get; }

        public MusicalInstrument(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine($"The {Name} makes a sound");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description: {Characteristics}");
        }

        public virtual void History()
        {
            Console.WriteLine($"History of {Name}:");
        }
    }

    public class Violin : MusicalInstrument
    {
        public Violin(string name, string characteristics)
            : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The violin produces a beautiful string sound.");
        }

        public override void History()
        {
            base.History();
            Console.WriteLine("The violin has a long history, dating back to the 16th century.");
        }
    }

    public class Trombone : MusicalInstrument
    {
        public Trombone(string name, string characteristics)
            : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The trombone produces a rich, deep brass sound.");
        }

        public override void History()
        {
            base.History();
            Console.WriteLine("The trombone has a history dating back to the 15th century.");
        }
    }

    public class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string characteristics)
            : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The ukulele produces a light, cheerful sound.");
        }

        public override void History()
        {
            base.History();
            Console.WriteLine("The ukulele originated in the 19th century in Hawaii.");
        }
    }

    public class Cello : MusicalInstrument
    {
        public Cello(string name, string characteristics)
            : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The cello produces a deep, rich tone similar to a human voice.");
        }

        public override void History()
        {
            base.History();
            Console.WriteLine("The cello has a history dating back to the 16th century.");
        }
    }
}