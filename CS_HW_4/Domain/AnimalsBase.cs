namespace AnimalsBase
{
    public class Animal
    {
        public string Name { get; }
        public string Habitat { get; }

        public Animal(string name, string habitat)
        {
            Name = name;
            Habitat = habitat;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Habitat: {Habitat}");
        }
    }
}