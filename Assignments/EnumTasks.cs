using System;

class EnumTasks
{
    private enum UserRole
    {
        Guest,
        User,
        Moderator,
        Admin,
    }

    private static void DisplayUserRole(UserRole role)
    {
        switch (role)
        {
            case UserRole.Guest:
                Console.WriteLine("You have no access rights");
                break;
            case UserRole.User:
                Console.WriteLine("You can log in");
                break;
            case UserRole.Moderator:
                Console.WriteLine("You can edit");
                break;
            case UserRole.Admin:
                Console.WriteLine("You have full access");
                break;
            default:
                Console.WriteLine("You can't do that");
                break;
        }
    }

    private enum WeatherCondition
    {
        Sunny,
        Cloudy,
        Rainy,
        Stormy,
    }

    private static void DisplayWeatherMessage(WeatherCondition weather)
    {
        Console.WriteLine($"Today's weather is {weather}");
    }

    private enum Gear
    {
        P,
        R,
        N,
        D,
    }

    private static void DisplayGearFunction(Gear gear)
    {
        switch (gear)
        {
            case Gear.P:
                Console.WriteLine("The car is parked");
                break;
            case Gear.R:
                Console.WriteLine("Reverse gear engaged");
                break;
            case Gear.N:
                Console.WriteLine("Neutral gear engaged");
                break;
            case Gear.D:
                Console.WriteLine("Drive mode engaged");
                break;
            default:
                Console.WriteLine("You can't do that");
                break;
        }
    }

    private enum Os
    {
        Windows,
        MacOs,
        Linux,
    }

    private static void DisplayOsMessage(Os os)
    {
        Console.WriteLine($"Operating system: {os}");
    }

    private enum Season
    {
        Winter,
        Spring,
        Summer,
        Autumn,
    }

    private static void DisplaySeason(Season season)
    {
        Console.WriteLine($"Current season: {season}");
    }

    private enum MobileOperator
    {
        Beeline = 0,
        Mts = 1,
        Ucom = 2,
    }

    private static void DisplayOperator(MobileOperator operatorName)
    {
        Console.WriteLine($"Your mobile operator: {operatorName}");
    }

    private enum ProgrammingLanguage
    {
        CSharp,
        Java,
        Python,
        JavaScript,
    }

    private static void DisplayProgrammingLanguage(ProgrammingLanguage language)
    {
        Console.WriteLine($"Programming language: {language}");
    }

    private enum TransactionType
    {
        Deposit,
        Withdraw,
        Transfer,
    }

    private static void DisplayTransactionType(TransactionType transaction)
    {
        Console.WriteLine($"Transaction type: {transaction}");
    }

    private enum ColorMode
    {
        Rgb,
        Cmyk,
        Grayscale,
    }

    private static void DisplayColorMode(ColorMode colorMode)
    {
        Console.WriteLine($"Color mode: {colorMode}");
    }

    public static void RunTasks()
    {
        DisplayUserRole(UserRole.Moderator);
        DisplayWeatherMessage(WeatherCondition.Rainy);
        DisplayGearFunction(Gear.D);
        DisplayOsMessage(Os.Linux);
        DisplaySeason(Season.Summer);
        DisplayOperator(MobileOperator.Ucom);
        DisplayProgrammingLanguage(ProgrammingLanguage.CSharp);
        DisplayTransactionType(TransactionType.Deposit);
        DisplayColorMode(ColorMode.Rgb);
    }
}
