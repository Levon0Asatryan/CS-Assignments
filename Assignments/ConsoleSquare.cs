namespace Assignments;

public class ConsoleSquare
{
    private static void WriteAt(string s, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(s);
    }

    public static void DrawSquare()
    {
        Console.WriteLine("Enter a and b");
        var a = int.Parse(Console.ReadLine() ?? "5");
        var b = int.Parse(Console.ReadLine() ?? "5");
        Console.WriteLine("Enter start coordinates");
        var x = int.Parse(Console.ReadLine() ?? "0");
        var y = int.Parse(Console.ReadLine() ?? "0");

        var curTop = Console.CursorTop;
        var curLeft = Console.CursorLeft;

        while (true)
        {
            Console.ForegroundColor = (ConsoleColor)new Random().Next(1, 16);

            // Draw top side: left to right
            for (var i = 0; i < a; i++)
            {
                WriteAt("*", curLeft + x + i, curTop + y);
                Thread.Sleep(50);
            }
            // Draw right side: top to bottom
            for (var j = 1; j < b; j++)
            {
                WriteAt("*", curLeft + x + a - 1, curTop + y + j);
                Thread.Sleep(50);
            }
            // Draw bottom side: right to left
            for (var i = a - 2; i >= 0; i--)
            {
                WriteAt("*", curLeft + x + i, curTop + y + b - 1);
                Thread.Sleep(50);
            }
            // Draw left side: bottom to top
            for (var j = b - 2; j > 0; j--)
            {
                WriteAt("*", curLeft + x, curTop + y + j);
                Thread.Sleep(50);
            }
        }
    }
}
