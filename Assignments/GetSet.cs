using System;

namespace GetSet
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name is required.");
            Name = name;
        }
    }

    class Circle
    {
        public double Radius { get; set; }

        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }
    }

    class Student
    {
        private int _age;

        public int Age
        {
            get => _age;
            set
            {
                if (value <= 16)
                    throw new ArgumentException("Age must be greater than 16.");
                _age = value;
            }
        }
    }

    class Temperature
    {
        public double Celsius { get; set; }

        public double Fahrenheit
        {
            get { return (Celsius * 9 / 5) + 32; }
        }
    }

    class Employee
    {
        private double _salary;

        public double Salary
        {
            get => _salary;
            set
            {
                if (value < 100 || value > 10000)
                    throw new ArgumentException("Salary must be between 100 and 10000.");
                _salary = value;
            }
        }
    }

    class BankAccount
    {
        private double _balance;

        public double Balance => _balance;

        public void Deposit(double amount)
        {
            if (amount > 0)
                _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= _balance)
                _balance -= amount;
        }
    }

    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Perimeter => 2 * (Width + Height);
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
