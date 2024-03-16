using System;

namespace WorkersApp
{
    class Program
    {
        static void Main()
        {
            var president = new WorkersLibrary.President("John Doe", 50,10000, "ABC Company") ;
            var security = new WorkersLibrary.Security("Jane Smith", 35,5000);
            var manager = new WorkersLibrary.Manager("Alice Johnson", 45,8000, "Sales Department");
            var engineer = new WorkersLibrary.Engineer("Bob Brown", 40,7000, "Software Engineering");

            president.Print();
            security.Print();
            manager.Print();
            engineer.Print();
        }
    }
}