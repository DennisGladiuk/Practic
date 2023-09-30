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

        int[] lisLength = new int[numbers.Length]; // Довжина найбільшої зростаючої підпослідовності, яка закінчується в кожному елементі
        int[] previousIndex = new int[numbers.Length]; // Індекс попереднього елемента в найбільшій зростаючій підпослідовності

        int maxLength = 1; // Довжина найбільшої зростаючої підпослідовності
        int lastIndex = 0; // Індекс останнього елемента найбільшої зростаючої підпослідовності

        for (int i = 0; i < numbers.Length; i++)
        {
            lisLength[i] = 1; // Початкова довжина підпослідовності для кожного елемента - 1
            previousIndex[i] = -1; // Початковий індекс попереднього елемента - відсутній (-1)

            for (int j = 0; j < i; j++)
            {
                if (numbers[i] > numbers[j] && lisLength[i] < lisLength[j] + 1)
                {
                    lisLength[i] = lisLength[j] + 1;
                    previousIndex[i] = j;
                }
            }

            if (lisLength[i] > maxLength)
            {
                maxLength = lisLength[i];
                lastIndex = i;
            }
        }

        // Відновлення найдовшої зростаючої підпослідовності
        int[] longestSubsequence = new int[maxLength];
        int currentIndex = lastIndex;
        for (int i = maxLength - 1; i >= 0; i--)
        {
            longestSubsequence[i] = numbers[currentIndex];
            currentIndex = previousIndex[currentIndex];
        }

        Console.WriteLine("Найдовша зростаюча підпослідовність:");
        Console.WriteLine(string.Join(" ", longestSubsequence));
    }
}
