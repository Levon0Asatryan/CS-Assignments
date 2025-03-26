using System;

class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public static void RunTask()
    {
        Person person = new Person();
        person.Name = "John";
        Console.WriteLine($"Name: {person.Name}");
    }
}

class Student
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0 && value <= 120)
            {
                age = value;
            }
        }
    }

    public static void RunTask()
    {
        Student student = new Student();
        student.Age = 21;
        Console.WriteLine($"Age: {student.Age}");
    }
}

class Car
{
    public string Model { get; set; }

    public static void RunTask()
    {
        Car car = new Car();
        car.Model = "Toyota";
        Console.WriteLine($"Model: {car.Model}");
    }
}

class UserAccount
{
    private string password;

    public string Password
    {
        get { return new string('*', password.Length); }
        set { password = value; }
    }

    public static void RunTask()
    {
        UserAccount account = new UserAccount();
        account.Password = "Secret123";
        Console.WriteLine($"Password: {account.Password}");
    }
}

class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int Area
    {
        get { return Width * Height; }
    }

    public static void RunTask()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Width = 5;
        rectangle.Height = 4;
        Console.WriteLine($"Area: {rectangle.Area}");
    }
}

class BankAccount
{
    private double balance;

    public double Balance
    {
        get { return balance; }
    }

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public static void RunTask()
    {
        BankAccount account = new BankAccount(1500.50);
        Console.WriteLine($"Balance: {account.Balance}");
    }
}

class PropertyTasks
{
    public static void RunTasks()
    {
        Person.RunTask();
        Student.RunTask();
        Car.RunTask();
        UserAccount.RunTask();
        Rectangle.RunTask();
        BankAccount.RunTask();
    }
}
