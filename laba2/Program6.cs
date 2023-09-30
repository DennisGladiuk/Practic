using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть елементи масиву, розділені пробілами:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        int[] numbers = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            numbers[i] = int.Parse(inputArray[i]);
        }

        int start = 0;        // Початковий індекс поточної послідовності
        int len = 1;          // Довжина поточної послідовності
        int bestStart = 0;    // Початковий індекс найдовшої знайденої послідовності
        int bestLen = 1;      // Довжина найдовшої знайденої послідовності

        for (int pos = 1; pos < numbers.Length; pos++)
        {
            if (numbers[pos] == numbers[pos - 1])
            {
                len++;
            }
            else
            {
                start = pos;
                len = 1;
            }

            if (len > bestLen)
            {
                bestStart = start;
                bestLen = len;
            }
        }

        Console.Write("Найдовша послідовність однакових елементів: ");
        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}
