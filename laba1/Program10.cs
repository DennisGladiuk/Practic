using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть послідовність чисел, розділених пробілами:");
        string inputSequence = Console.ReadLine();
        Console.WriteLine("Введіть різницю:");
        int difference = int.Parse(Console.ReadLine());

        int[] numbers = Array.ConvertAll(inputSequence.Split(' '), int.Parse);

        int pairCount = ПорахуватиПариЗРізницею(numbers, difference);
        Console.WriteLine("Кількість пар з заданою різницею: " + pairCount);
    }

    static int ПорахуватиПариЗРізницею(int[] numbers, int difference)
    {
        HashSet<int> numberSet = new HashSet<int>(numbers);
        int pairCount = 0;

        foreach (int number in numbers)
        {
            if (numberSet.Contains(number - difference))
            {
                pairCount++;
            }
        }

        return pairCount;
    }
}
