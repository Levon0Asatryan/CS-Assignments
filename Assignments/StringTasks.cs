using System.Data;

namespace Assignments;

public class StringTasks
{
    public static void Task1()
    {
        Console.WriteLine("Enter a mathematical expression:");
        var input = Console.ReadLine() ?? "";

        try
        {
            var dt = new DataTable();
            var result = dt.Compute(input, "");
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid expression. " + ex.Message);
        }
    }

    public static void Task2()
    {
        var key = "";

        while (key.ToLower() != "q")
        {
            key = Console.ReadKey().Key.ToString();
        }
    }
}
