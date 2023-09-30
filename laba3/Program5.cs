using System;

public class DateModifier
{
    public int CalculateDifference(string firstDateStr, string secondDateStr)
    {
        DateTime firstDate = DateTime.ParseExact(firstDateStr, "yyyy MM dd", null);
        DateTime secondDate = DateTime.ParseExact(secondDateStr, "yyyy MM dd", null);

        TimeSpan difference = firstDate - secondDate;
        return Math.Abs(difference.Days);
    }
}

class Program
{
    static void Main()
    {
        DateModifier dateModifier = new DateModifier();

        Console.Write("Введіть першу дату (рік місяць день): ");
        string firstDateStr = Console.ReadLine();

        Console.Write("Введіть другу дату (рік місяць день): ");
        string secondDateStr = Console.ReadLine();

        int difference = dateModifier.CalculateDifference(firstDateStr, secondDateStr);
        Console.WriteLine($"Різниця в днях між датами: {difference} днів");
    }
}
