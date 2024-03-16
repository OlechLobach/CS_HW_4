using System;
using Domain;

namespace Project
{
    class Program
    {
        static void Main()
        {
            Passport passport = new Passport("John Doe", "123456789", "USA");
            passport.PrintInfo();

            ForeignPassport foreignPassport = new ForeignPassport("John Doe", "123456789", "USA", "ABC123");
            foreignPassport.AddVisa("Schengen");
            foreignPassport.AddVisa("UK");
            foreignPassport.PrintInfo();
            foreignPassport.PrintVisas();
        }
    }
}