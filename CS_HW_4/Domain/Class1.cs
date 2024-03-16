using System;
using System.Collections.Generic; // Додано директиву

namespace Domain
{
    public class Passport
    {
        public string FullName { get; set; }
        public string PassportNumber { get; set; }
        public string Nationality { get; set; }

        public Passport(string fullName, string passportNumber, string nationality)
        {
            FullName = fullName;
            PassportNumber = passportNumber;
            Nationality = nationality;
        }

        public virtual void PrintInfo() 
        {
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Passport Number: {PassportNumber}");
            Console.WriteLine($"Nationality: {Nationality}");
        }
    }

    public class ForeignPassport : Passport
    {
        public List<string> Visas { get; set; }
        public string ForeignPassportNumber { get; set; }

        public ForeignPassport(string fullName, string passportNumber, string nationality, string foreignPassportNumber)
            : base(fullName, passportNumber, nationality)
        {
            ForeignPassportNumber = foreignPassportNumber;
            Visas = new List<string>();
        }

        public void AddVisa(string visa)
        {
            Visas.Add(visa);
        }

        public void PrintVisas()
        {
            Console.WriteLine("Visas:");
            foreach (var visa in Visas)
            {
                Console.WriteLine(visa);
            }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Foreign Passport Number: {ForeignPassportNumber}");
        }
    }
}