using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Програма для згинання та обчислення суми двох рядків.");

        // Зчитуємо k з консолі
        Console.WriteLine("Введіть значення k:");
        int k = int.Parse(Console.ReadLine());

        // Створюємо масив для зберігання всіх чисел
        int[] array = new int[4 * k];

        Console.WriteLine("Введіть " + (4 * k) + " чисел через пробіл:");

        // Зчитуємо всі числа та розділяємо їх
        string[] inputNumbers = Console.ReadLine().Split();

        // Перетворюємо рядок чисел у масив цілих чисел
        for (int i = 0; i < 4 * k; i++)
        {
            array[i] = int.Parse(inputNumbers[i]);
        }

        int[] upperRow = new int[2 * k];
        int[] lowerRow = new int[2 * k];

        // Створюємо верхній рядок після згинання
        for (int i = 0; i < k; i++)
        {
            upperRow[i] = array[i];
            upperRow[k + i] = array[3 * k + i];
        }

        // Створюємо нижній рядок після згинання
        for (int i = 0; i < 2 * k; i++)
        {
            lowerRow[i] = array[k + i];
        }

        int[] sums = new int[2 * k];

        // Обчислюємо суми верхнього і нижнього рядків
        for (int i = 0; i < 2 * k; i++)
        {
            sums[i] = upperRow[i] + lowerRow[i];
        }

        Console.WriteLine("Сума верхнього та нижнього рядків після згинання:");
        Console.WriteLine(string.Join(" ", sums));
    }
}
