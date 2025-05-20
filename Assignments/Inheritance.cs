using System;
using System.Collections.Generic;

namespace Inheritance
{
    // 1. Vehicle and Car classes
    class Vehicle
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
            Console.WriteLine("Vehicle created");
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("Engine started");
        }
    }

    class Car : Vehicle
    {
        public Car(string brand)
            : base(brand) { }

        public override void StartEngine()
        {
            base.StartEngine();
        }

        public void OpenTrunk()
        {
            Console.WriteLine("Trunk opened");
        }
    }

    // 2. Shape, Rectangle, and Circle classes
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // 3. Person and Student classes
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }

    class Student : Person
    {
        public int Grade { get; set; }

        public Student(string name, int grade)
            : base(name)
        {
            Grade = grade;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Grade: {Grade}");
        }
    }

    // 4. Account, SavingsAccount, CurrentAccount classes
    abstract class Account
    {
        public abstract double CalculateInterest();
    }

    class SavingsAccount : Account
    {
        public double Balance { get; set; }

        public SavingsAccount(double balance)
        {
            Balance = balance;
        }

        public override double CalculateInterest()
        {
            return Balance * 0.05;
        }
    }

    class CurrentAccount : Account
    {
        public double Balance { get; set; }

        public CurrentAccount(double balance)
        {
            Balance = balance;
        }

        public override double CalculateInterest()
        {
            return Balance * 0.02;
        }
    }

    public class Inheritance
    {
        static void Test()
        {
            // Test Vehicle and Car
            Car myCar = new Car("Toyota");
            myCar.StartEngine();
            myCar.OpenTrunk();

            Console.WriteLine();

            // Test Shape, Rectangle, and Circle
            Shape rect = new Rectangle(4, 5);
            Shape circle = new Circle(3);
            Console.WriteLine("Rectangle Area: " + rect.CalculateArea());
            Console.WriteLine("Circle Area: " + circle.CalculateArea().ToString("F2"));

            Console.WriteLine();

            // Test Person and Student
            Student student = new Student("Արամ", 5);
            student.PrintInfo();

            Console.WriteLine();

            // Test Accounts
            SavingsAccount sa = new SavingsAccount(1000);
            CurrentAccount ca = new CurrentAccount(1000);
            Console.WriteLine("Savings Account Interest: " + sa.CalculateInterest());
            Console.WriteLine("Current Account Interest: " + ca.CalculateInterest());
        }
    }
}
