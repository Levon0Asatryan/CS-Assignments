using System;

namespace Constructor
{
    class Person
    {
        private string Name;
        private int Age;

        public Person(string name)
            : this(name, 25) { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Car
    {
        private string Brand;
        private string Model;
        private int Year;

        public Car(string brand)
            : this(brand, "Unknown", 2000) { }

        public Car(string brand, string model)
            : this(brand, model, 2020) { }

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public void Display()
        {
            Console.WriteLine($"Car: {Brand}, Model: {Model}, Year: {Year}");
        }
    }

    class Book
    {
        private string Title;
        private string Author;
        private double Price;

        public Book(string title)
            : this(title, "Unknown", 0.0) { }

        public Book(string title, string author)
            : this(title, author, 29.99) { }

        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Price: ${Price}");
        }
    }

    class ConstructorTasks
    {
        public static void RunTasks()
        {
            Person person = new Person("John");
            person.Display();

            Car car = new Car("Toyota", "Corolla");
            car.Display();

            Book book = new Book("C# Programming", "John Doe");
            book.Display();
        }
    }
}
