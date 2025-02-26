namespace ConsoleApp1;

public static class ArrayAndStringTasks
{
    private static T[] GetArrayFromConsole<T>(int count, Func<string, T> parseFunction)
    {
        var array = new T[count];
        for (var i = 0; i < count; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            var input = Console.ReadLine();
            array[i] = parseFunction(input ?? "");
        }
        return array;
    }

    public static void ArrayTask1()
    {
        int count;
        Console.Write("Enter the count: ");

        while (!int.TryParse(Console.ReadLine(), out count))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.Write("Enter the count: ");
        }

        int[] numbers = GetArrayFromConsole<int>(count, int.Parse);
        var total = numbers.Sum();
        Console.WriteLine("The sum of all elements is: " + total);
    }

    public static void ArrayTask2()
    {
        Console.Write("Enter the size of the matrix (n): ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            Console.Write("Enter the size of the matrix (n): ");
        }

        int[,] matrix = new int[n, n];

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                Console.Write($"Enter element [{i + 1}, {j + 1}]: ");
                int value;
                while (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    Console.Write($"Enter element [{i + 1}, {j + 1}]: ");
                }
                matrix[i, j] = value;
            }
        }

        var sum = 0;
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i];
        }
        Console.WriteLine("The sum of all elements is: " + sum);
    }

    public static void ArrayTask3()
    {
        int count;
        Console.Write("Enter the count: ");

        while (!int.TryParse(Console.ReadLine(), out count))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.Write("Enter the count: ");
        }

        int[] numbers = GetArrayFromConsole<int>(count, int.Parse);
        int[] evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();
        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
    }

    public static void ArrayTask4()
    {
        char[] words = Console.ReadLine().ToCharArray();
        string upperCase = new string(words.Select(n => char.ToUpper(n)).ToArray());
        Console.WriteLine("Upper case: " + upperCase);
    }

    // To be honest this task is not clear at all,
    // but I will get array of strings from user and sort them by their length and write it in console
    // to be shorter I will hard code array length
    public static void ArrayTask5()
    {
        string[] words = GetArrayFromConsole<string>(5, st => st);
        Array.Sort(words, (a, b) => a.Length.CompareTo(b.Length));
        Console.WriteLine(string.Join(", ", words));
    }

    public static void ArrayTask6()
    {
        var line = Console.ReadLine() ?? "";
        var words = line.Split(' ');
        char[][] letters = words.Select(word => word.ToCharArray()).ToArray();
        for (var i = 0; i < letters.Length; i++)
        {
            for (var j = 0; j < letters[i].Length; j++)
                Console.Write(letters[i][j]);
            Console.WriteLine();
        }
    }

    public static void ArrayTask7()
    {
        ConsoleColor[][] colors =
        [
            [ConsoleColor.Yellow],
            [ConsoleColor.Black, ConsoleColor.DarkYellow],
            [ConsoleColor.Red, ConsoleColor.Cyan, ConsoleColor.Green],
            [
                ConsoleColor.Magenta,
                ConsoleColor.DarkRed,
                ConsoleColor.DarkGreen,
                ConsoleColor.DarkGray,
            ],
        ];

        for (var i = 0; i < colors.Length; i++)
        {
            for (var j = 0; j < colors[i].Length; j++)
            {
                Console.ForegroundColor = colors[i][j];
                Console.Write($"{colors[i][j]}, ");
            }
            Console.WriteLine();
        }
    }

    public static void ArrayTask8()
    {
        var disorderedWords = Array.Empty<char[]>();

        var newWord = Console.ReadLine() ?? "";

        Array.Resize(ref disorderedWords, disorderedWords.Length + 1);

        var letters = newWord.ToCharArray();

        var rng = new Random();

        for (var i = letters.Length - 1; i > 0; i--)
        {
            var j = rng.Next(i + 1);
            (letters[i], letters[j]) = (letters[j], letters[i]);
        }

        disorderedWords[^1] = letters;
        Console.WriteLine($"{newWord} -\n{string.Join(Environment.NewLine, disorderedWords[^1])}");
    }
}
