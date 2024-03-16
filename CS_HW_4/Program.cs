using System;
using InstrumentsLibrary;

namespace InstrumentsApp
{
    class Program
    {
        static void Main()
        {
            MusicalInstrument[] instruments = new MusicalInstrument[]
            {
                new Violin("Violin", "String instrument with four strings played with a bow"),
                new Trombone("Trombone", "Brass instrument with a long slide"),
                new Ukulele("Ukulele", "Small guitar-like instrument with four strings"),
                new Cello("Cello", "Large string instrument played between the legs")
            };

            foreach (var instrument in instruments)
            {
                Console.WriteLine();
                instrument.Show();
                instrument.Desc();
                instrument.Sound();
                instrument.History();
            }
        }
    }
}