
using System;
using System.Text;

namespace WorkersLibrary
{
    public abstract class Worker
    {
        public string Name { get; }
        public int Age { get; }
        public double Salary { get; }
        public double SalaryInDollars => Salary * 0.85; 

        public Worker(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }


        public abstract void Print();
    }

    public class President : Worker
    {
        public string Company { get; }

        public President(string name, int age, double salary, string company) : base(name, age, salary)
        {
            Company = company;
        }

        public override void Print()
        {
            Console.WriteLine($"President: {Name}, Age: {Age}, Salary: ${SalaryInDollars} (euro/{Salary}) at {Company}");
        }
    }

    public class Security : Worker
    {
        public Security(string name, int age, double salary) : base(name, age, salary) { }

        public override void Print()
        {
            Console.WriteLine($"Security: {Name}, Age: {Age}, Salary: ${SalaryInDollars} (euro/{Salary})");
        }
    }

    public class Manager : Worker
    {
        public string Department { get; }

        public Manager(string name, int age, double salary, string department) : base(name, age, salary)
        {
            Department = department;
        }

        public override void Print()
        {
            Console.WriteLine($"Manager: {Name}, Age: {Age}, Salary: ${SalaryInDollars} (euro/{Salary}) in {Department}");
        }
    }

    public class Engineer : Worker
    {
        public string Field { get; }

        public Engineer(string name, int age, double salary, string field) : base(name, age, salary)
        {
            Field = field;
        }

        public override void Print()
        {
            Console.WriteLine($"Engineer: {Name}, Age: {Age}, Salary: ${SalaryInDollars} (euro/{Salary}) in {Field}");
        }
    }
}