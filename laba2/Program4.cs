using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть максимальне число n:");
        int n = int.Parse(Console.ReadLine());

        bool[] primes = new bool[n + 1];

        // Ініціалізуємо масив простих чисел, вважаючи всі числа спочатку простими
        for (int i = 2; i <= n; i++)
        {
            primes[i] = true;
        }

        // Виконуємо алгоритм "Сіто Ератосфена" для знаходження простих чисел
        for (int p = 2; p <= n; p++)
        {
            if (primes[p] == true)
            {
                Console.WriteLine(p); // Виводимо просте число p

                // Встановлюємо всі кратні p як непрості числа
                for (int i = 2 * p; i <= n; i += p)
                {
                    primes[i] = false;
                }
            }
        }
    }
}
