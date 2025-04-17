using System;

namespace OperatorOverloadingDemo
{
    public class Complex
    {
        public double Real { get; }
        public double Imaginary { get; }

        public Complex(double real, double imag)
        {
            Real = real;
            Imaginary = imag;
        }

        public static Complex operator +(Complex a, Complex b) =>
            new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);

        public static Complex operator -(Complex a, Complex b) =>
            new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);

        public static Complex operator *(Complex a, Complex b) =>
            new Complex(
                a.Real * b.Real - a.Imaginary * b.Imaginary,
                a.Real * b.Imaginary + a.Imaginary * b.Real
            );

        public override string ToString() => $"{Real} + {Imaginary}i";
    }

    public class Vector2D
    {
        public double X { get; }
        public double Y { get; }

        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector2D operator +(Vector2D a, Vector2D b) =>
            new Vector2D(a.X + b.X, a.Y + b.Y);

        public static Vector2D operator -(Vector2D a, Vector2D b) =>
            new Vector2D(a.X - b.X, a.Y - b.Y);

        public static Vector2D operator -(Vector2D v) => new Vector2D(-v.X, -v.Y);

        public static bool operator ==(Vector2D a, Vector2D b) => a.X == b.X && a.Y == b.Y;

        public static bool operator !=(Vector2D a, Vector2D b) => !(a == b);

        public override bool Equals(object obj) => obj is Vector2D v && this == v;

        public override int GetHashCode() => HashCode.Combine(X, Y);

        public override string ToString() => $"({X}, {Y})";
    }

    public class MyString
    {
        public string Value { get; }

        public MyString(string value)
        {
            Value = value;
        }

        public static MyString operator +(MyString a, MyString b) =>
            new MyString($"{a.Value} {b.Value}");

        public override string ToString() => Value;
    }

    public static class Test
    {
        public static void Run()
        {
            Console.WriteLine("=== Complex Number Operations ===");
            var c1 = new Complex(2, 3);
            var c2 = new Complex(1, 4);
            Console.WriteLine($"c1: {c1}");
            Console.WriteLine($"c2: {c2}");
            Console.WriteLine($"c1 + c2 = {c1 + c2}");
            Console.WriteLine($"c1 - c2 = {c1 - c2}");
            Console.WriteLine($"c1 * c2 = {c1 * c2}");

            Console.WriteLine("\n=== Vector2D Operations ===");
            var v1 = new Vector2D(1, 2);
            var v2 = new Vector2D(3, 4);
            Console.WriteLine($"v1: {v1}");
            Console.WriteLine($"v2: {v2}");
            Console.WriteLine($"v1 + v2 = {v1 + v2}");
            Console.WriteLine($"v1 - v2 = {v1 - v2}");
            Console.WriteLine($"-v1 = {-v1}");
            Console.WriteLine($"v1 == v2: {v1 == v2}");
            Console.WriteLine($"v1 != v2: {v1 != v2}");

            Console.WriteLine("\n=== MyString Operations ===");
            var s1 = new MyString("Hello");
            var s2 = new MyString("World");
            Console.WriteLine($"s1: {s1}");
            Console.WriteLine($"s2: {s2}");
            Console.WriteLine($"s1 + s2 = {s1 + s2}");
        }
    }
}
