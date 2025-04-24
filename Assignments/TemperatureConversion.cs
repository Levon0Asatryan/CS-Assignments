using System;

namespace TemperatureConversion
{
    public struct Celsius
    {
        public double Value { get; }

        public Celsius(double value)
        {
            Value = value;
        }

        public static implicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.Value * 9 / 5 + 32);
        }

        public override string ToString() => $"{Value} °C";
    }

    public struct Fahrenheit
    {
        public double Value { get; }

        public Fahrenheit(double value)
        {
            Value = value;
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.Value - 32) * 5 / 9);
        }

        public override string ToString() => $"{Value} °F";
    }

    public class ConversionTest
    {
        public static void Run()
        {
            Celsius celsius = new Celsius(25);
            Fahrenheit fahrenheit = celsius; // implicit
            Console.WriteLine($"Celsius to Fahrenheit: {fahrenheit}");

            Fahrenheit f = new Fahrenheit(77);
            Celsius c = (Celsius)f; // explicit
            Console.WriteLine($"Fahrenheit to Celsius: {c}");
        }
    }
}
