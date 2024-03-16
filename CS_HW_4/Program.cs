using System;
using DevicesLibrary;

namespace DevicesApp
{
    class Program
    {
        static void Main()
        {
            Kettle kettle = new Kettle("Electric Kettle", "Capacity: 1.7L, Power: 1500W");
            kettle.Show();
            kettle.Desc();
            kettle.Sound();

            Microwave microwave = new Microwave("Microwave Oven", "Capacity: 20L, Power: 800W");
            microwave.Show();
            microwave.Desc();
            microwave.Sound();

            Car car = new Car("Toyota Camry", "Engine: 2.5L, Power: 203hp");
            car.Show();
            car.Desc();
            car.Sound();

            Steamship steamship = new Steamship("Steamship Titanic", "Length: 269m, Capacity: 2435 passengers");
            steamship.Show();
            steamship.Desc();
            steamship.Sound();
        }
    }
}