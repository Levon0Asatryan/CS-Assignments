namespace Assignments;

public class ArrayTasks
{
    public static void Task1()
    {
        Console.Write("Enter the array length: ");
        var num = int.Parse(Console.ReadLine() ?? "0");

        var random = new Random();
        var allColors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
        var colorArray = new ConsoleColor[num];

        for (var i = 0; i < num; i++)
        {
            var randomIndex = random.Next(allColors.Length);
            colorArray[i] = allColors[randomIndex];
        }

        foreach (var color in colorArray)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(color);
        }
    }

    public static void Task2()
    {
        Console.Write("Enter the number of rows: ");
        var parentLength = int.Parse(Console.ReadLine() ?? "0");
        var random = new Random();
        var jaggedArray = new int[parentLength][];

        for (var i = 0; i < parentLength; i++)
        {
            Console.Write($"Enter the length for row {i}: ");
            var rowLength = int.Parse(Console.ReadLine() ?? "0");
            jaggedArray[i] = new int[rowLength];
            for (var j = 0; j < rowLength; j++)
            {
                // I don't know what is 'տիկ' so I fill arrays with random numbers
                jaggedArray[i][j] = random.Next(100);
            }
        }

        Console.WriteLine("\nThe jagged array:");
        for (var i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Row " + i + ": ");
            foreach (var num in jaggedArray[i])
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

    // Task 3 is not clear at all, I did same as Task 2 but fill arrays with A-Z letters
    public static void Task3()
    {
        Console.Write("Enter the number of rows: ");
        var parentLength = int.Parse(Console.ReadLine() ?? "0");

        var jaggedArray = new char[parentLength][];

        for (var i = 0; i < parentLength; i++)
        {
            Console.Write($"Enter the length for row {i}: ");
            var rowLength = int.Parse(Console.ReadLine() ?? "0");
            jaggedArray[i] = new char[rowLength];
            for (var j = 0; j < rowLength; j++)
            {
                jaggedArray[i][j] = (char)('A' + (j % 26));
            }
        }

        Console.WriteLine("\nThe jagged array:");
        for (var i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Row " + i + ": ");
            foreach (var letter in jaggedArray[i])
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();
        }
    }
}
