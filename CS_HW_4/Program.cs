using DevicesLibrary;

namespace DeviceApp
{
    class Program
    {
        static void Main()
        {
            Device kettle = new Kettle("Electric kettle", "Capacity: 1.7L, Power: 1500W");
            Device microwave = new Microwave("Microwave oven", "Capacity: 25L, Power: 1000W");
            Device car = new Car("Electric car", "Range: 250 miles, Power: 150kW");
            Device steamship = new Steamship("Steamship", "Speed: 25 knots, Capacity: 200 passengers");

            PlaySound(kettle);
            PlaySound(microwave);
            PlaySound(car);
            PlaySound(steamship);
        }

        static void PlaySound(Device device)
        {
            Console.Write($"{device.Name} characteristics: {device.Characteristics}. ");
            device.Sound();
        }
    }
}