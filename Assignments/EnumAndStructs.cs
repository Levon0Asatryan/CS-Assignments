namespace Assignments;

using System;
using System;

class WeekdayEnum
{
    private enum Weekday
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    public static void GetWeekday(int dayNumber)
    {
        if (dayNumber >= 1 && dayNumber <= 7)
        {
            Weekday day = (Weekday)dayNumber;
            Console.WriteLine($"Day {dayNumber}: {day}");
        }
        else
        {
            Console.WriteLine("Error: Invalid day number. Enter a number between 1 and 7.");
        }
    }
}

readonly struct ConsoleSymbol
{
    private readonly char symbol;
    private readonly int posX;
    private readonly int posY;

    public ConsoleSymbol(char sym, int x, int y)
    {
        symbol = sym;
        posX = x;
        posY = y;
    }

    public void Draw()
    {
        Console.SetCursorPosition(posX, posY);
        Console.Write(symbol);
    }

    public ConsoleSymbol Motion(int deltaX, int deltaY)
    {
        return new ConsoleSymbol(symbol, posX + deltaX, posY + deltaY);
    }
}

class EnumAndStructsTasks
{
    public static void RunTasks()
    {
        WeekdayEnum.GetWeekday(3);
        WeekdayEnum.GetWeekday(8);

        ConsoleSymbol star = new ConsoleSymbol('*', 5, 10);
        star.Draw();

        ConsoleSymbol movedStar = star.Motion(3, -2);
        movedStar.Draw();
    }
}
