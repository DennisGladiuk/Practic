using System;

class Program
{
    static void Main(string[] args)
    {
        // Зчитуємо вхідний масив та кількість обертань
        string[] inputArray = Console.ReadLine().Split(' ');
        int n = inputArray.Length;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(inputArray[i]);
        }

        int k = int.Parse(Console.ReadLine());

        // Ініціалізуємо масив sum[] значеннями початкового масиву
        int[] sum = new int[n];
        Array.Copy(arr, sum, n);

        // Виконуємо k обертань та обчислюємо суму
        for (int r = 1; r <= k; r++)
        {
            int[] rotated = new int[n];

            // Виконуємо одне обертання
            for (int i = 0; i < n; i++)
            {
                int новаПозиція = (i + 1) % n; // Обчислюємо нову позицію після одного обертання
                rotated[новаПозиція] = arr[i];
            }

            // Оновлюємо масив sum[]
            for (int i = 0; i < n; i++)
            {
                sum[i] = rotated[i] + arr[i]; // Сумуємо результати обертань
            }

            // Оновлюємо масив arr[] для наступного обертання
            Array.Copy(rotated, arr, n);

            // Виводимо результати обертань
            Console.WriteLine($"{r}\nrotated{r}[] = {string.Join(" ", rotated)}");
        }

        // Виводимо на екран суму всіх елементів у кінцевому масиві sum[]
        Console.WriteLine($"sum[] = {string.Join(" ", sum)}");
    }
}
