using System;

class Program
{
    static void Main()
    {
        // Створюємо масив символів, який містить алфавіт в нижньому регістрі.
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        // Просимо користувача ввести слово у нижньому регістрі.
        Console.WriteLine("Введіть слово у нижньому регістрі:");
        string word = Console.ReadLine();

        // Виводимо заголовок для таблиці виведення результатів.
        Console.WriteLine("Літера -> Індекс");

        // Проходимося по кожній літері у введеному слові.
        foreach (char letter in word)
        {
            // Перевіряємо, чи літера є у нижньому регістрі.
            if (char.IsLower(letter))
            {
                // Знаходимо індекс літери у масиві алфавіту.
                int index = Array.IndexOf(alphabet, letter);

                // Якщо літера знайдена у алфавіті, виводимо літеру та її індекс.
                if (index != -1)
                {
                    Console.WriteLine($"{letter} -> {index}");
                }
            }
        }
    }
}
