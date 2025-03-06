namespace Assignments;

class StudentGrades
{
    private static void CalculateAverage(int[] grades, out double average)
    {
        var sum = grades.Sum();
        average = (double)sum / grades.Length;
    }

    private static void UpdateGrade(ref int grade, int newGrade)
    {
        grade = newGrade;
    }

    private static void DisplayGrades(string studentName, params int[] grades)
    {
        Console.WriteLine($"Ուսանող: {studentName}");
        Console.WriteLine("Գնահատականներ: " + string.Join(", ", grades));

        CalculateAverage(grades, out var average);
        Console.WriteLine($"Միջին գնահատականը: {average}");

        Console.WriteLine("Արդյունք: " + (IsPassed(average) ? "Անցավ" : "Չանցավ"));
        Console.WriteLine();
    }

    private static bool IsPassed(double average)
    {
        return average >= 50;
    }

    public static void Students()
    {
        int[] grades = [60, 70, 50, 80];
        const string name = "Արմեն";
        DisplayGrades(name, grades);

        const int newGrade = 75;
        UpdateGrade(ref grades[1], newGrade);

        DisplayGrades(name, grades);
    }
}

public abstract class MethodTasks
{
    private static void Gcd(int num1, int num2, out int gcd)
    {
        while (num2 != 0)
        {
            var temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        gcd = Math.Abs(num1);
    }

    private static void Swap(ref int a, ref int b) => (a, b) = (b, a);

    private static void Average(out double avg, params int[] nums) => avg = nums.Average();

    private static int Sum(params int[] nums)
    {
        return nums.Sum();
    }

    private static void IsPrime(in int num, out bool prime)
    {
        if (num < 2)
        {
            prime = false;
            return;
        }

        prime = true;
        for (var i = 2; i * i <= num; i++)
        {
            if (num % i != 0)
                continue;
            prime = false;
            return;
        }
    }

    private static void RandomNumber(out int randomNumber)
    {
        var rand = new Random();
        randomNumber = rand.Next(1, 101);
    }

    private static void SortArray(ref int[] arr)
    {
        Array.Sort(arr);
    }

    private static void Max(out int max, params int[] nums) => max = nums.Max();

    private static void StrLength(in string str, out int length) => length = str.Length;

    public static void RunTasks()
    {
        //Task 1
        const int num1 = 124;
        const int num2 = 62;
        Gcd(num1, num2, out var gcd);
        Console.WriteLine($"{num1} and {num2} gcd is {gcd}");

        Console.WriteLine();

        //Task 2
        int a = 5,
            b = 4;
        Swap(ref a, ref b);
        Console.WriteLine($"Swapped a={a}, b={b}");

        Console.WriteLine();

        //Task 3
        Average(out var avg, 12, 12, 1, 5, 65, 23, 7, 8, 0);
        Console.WriteLine($"Average of numbers: {avg}");

        Console.WriteLine();

        //Task 4
        var sum = Sum(12, 56, 8, 11, 54, 223, 90);
        Console.WriteLine($"Sum of numbers: {sum}");

        Console.WriteLine();

        //Task 5
        const int num3 = 7;
        IsPrime(num3, out var isPrime);
        Console.WriteLine($"is {num3} prime: {isPrime}");

        Console.WriteLine();

        //Task 6
        RandomNumber(out var random);
        Console.WriteLine($"Random number: {random}");

        Console.WriteLine();

        //Task 7
        int[] numbers = [5, 2, 9, 1, 7];
        SortArray(ref numbers);
        Console.WriteLine("Sorted: " + string.Join(", ", numbers));

        Console.WriteLine();

        //Task 8
        Max(out var max, 12, 34, 52, 453, 12, 920, 124, 345, 11, 534, 991);
        Console.WriteLine($"Max of numbers: {max}");

        Console.WriteLine();

        //Task 9
        StrLength("asdasdasdasd", out var length);
        Console.WriteLine($"length: {length}");

        //Task 10
        StudentGrades.Students();
    }
}
