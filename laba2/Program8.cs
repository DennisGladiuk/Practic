using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть послідовність чисел, розділених пробілами:");
        string input = Console.ReadLine();

        // Розділяємо введений рядок на окремі числа і перетворюємо їх у масив цілих чисел.
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        // Створюємо словник для зберігання кількості кожного числа у послідовності.
        Dictionary<int, int> numberCount = new Dictionary<int, int>();

        // Проходимося по кожному числу у масиві чисел.
        foreach (int number in numbers)
        {
            // Перевіряємо, чи число вже є у словнику.
            if (numberCount.ContainsKey(number))
            {
                // Якщо так, збільшуємо лічильник для цього числа на 1.
                numberCount[number]++;
            }
            else
            {
                // Якщо не маємо запису про це число, додаємо його у словник з лічильником 1.
                numberCount[number] = 1;
            }
        }

        // Знаходимо число з максимальним лічильником (найчастіше зустрічаючеся число).
        int mostFrequentNumber = numberCount.OrderByDescending(pair => pair.Value).First().Key;

        // Виводимо результат - найчастіше зустрічаючеся число.
        Console.WriteLine($"Найчастіше зустрічаючеся число: {mostFrequentNumber}");
    }
}
