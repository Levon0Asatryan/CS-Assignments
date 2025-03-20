using System;
using System.Linq;
using System.Text;

static class SumCalculator
{
    private static int calculationCount = 0;

    private static void CalculateSum(int a, int b)
    {
        int sum = a + b;
        calculationCount++;
        Console.WriteLine($"Sum: {sum}");
    }

    private static void DisplayTotalCalculations()
    {
        Console.WriteLine($"Total calculations: {calculationCount}");
    }

    public static void RunTask()
    {
        CalculateSum(5, 3);
        CalculateSum(7, 8);
        DisplayTotalCalculations();
    }
}

class User
{
    private static int userCount = 0;

    public User()
    {
        userCount++;
    }

    private static void DisplayUserCount()
    {
        Console.WriteLine($"Users count: {userCount}");
    }

    public static void RunTask()
    {
        User user1 = new User();
        User user2 = new User();
        User user3 = new User();
        DisplayUserCount();
    }
}

class IDGenerator
{
    private static int currentID = 0;

    private static int GenerateID()
    {
        currentID++;
        return currentID;
    }

    public static void RunTask()
    {
        Console.WriteLine($"Generated ID: {GenerateID()}");
        Console.WriteLine($"Generated ID: {GenerateID()}");
        Console.WriteLine($"Generated ID: {GenerateID()}");
    }
}

class CurrencyConverter
{
    private const double usdToEurRate = 0.9;
    private const double eurToUsdRate = 1.11;

    private static void ConvertUsdToEur(double usd)
    {
        double eur = usd * usdToEurRate;
        Console.WriteLine($"{usd} USD to EUR: {eur} EUR");
    }

    private static void ConvertEurToUsd(double eur)
    {
        double usd = eur * eurToUsdRate;
        Console.WriteLine($"{eur} EUR to USD: {usd} USD");
    }

    public static void RunTask()
    {
        ConvertUsdToEur(100);
        ConvertEurToUsd(90);
    }
}

class PasswordGenerator
{
    private static Random random = new Random();

    private static string Generate(int length)
    {
        const string chars =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
        StringBuilder password = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            password.Append(chars[random.Next(chars.Length)]);
        }

        return password.ToString();
    }

    public static void RunTask()
    {
        Console.WriteLine($"Generated Password: {Generate(8)}");
    }
}

static class MathUtils
{
    private static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

    private static double Power(double baseNum, int exponent)
    {
        return Math.Pow(baseNum, exponent);
    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static void RunTask()
    {
        Console.WriteLine($"Factorial of 5: {Factorial(5)}");
        Console.WriteLine($"2^5: {Power(2, 5)}");
        Console.WriteLine($"GCD of 48 and 18: {GCD(48, 18)}");
    }
}

class Statistics
{
    private static double FindAverage(int[] numbers)
    {
        return numbers.Average();
    }

    private static int FindMin(int[] numbers)
    {
        return numbers.Min();
    }

    private static int FindMax(int[] numbers)
    {
        return numbers.Max();
    }

    public static void RunTask()
    {
        int[] numbers = { 1, 3, 5, 7, 2, 4, 6 };

        Console.WriteLine($"Average: {FindAverage(numbers)}");
        Console.WriteLine($"Min: {FindMin(numbers)}");
        Console.WriteLine($"Max: {FindMax(numbers)}");
    }
}

class StaticTasks
{
    public static void RunTasks()
    {
        SumCalculator.RunTask();
        User.RunTask();
        IDGenerator.RunTask();
        CurrencyConverter.RunTask();
        PasswordGenerator.RunTask();
        MathUtils.RunTask();
        Statistics.RunTask();
    }
}
