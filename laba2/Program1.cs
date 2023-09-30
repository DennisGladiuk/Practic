using System;

class Program
{
    static int FindLargestCommonEnd(string[] arr1, string[] arr2)  /* Метод FindLargestCommonEnd є частиною програми і використовується
                                                                    * для знаходження найдовшої спільної частини між двома масивами рядків
                                                                   */
    {                                                             
        int leftLen = 0;
        int rightLen = 0;

        // Порівнюємо елементи зліва направо
        while (leftLen < Math.Min(arr1.Length, arr2.Length) && arr1[leftLen] == arr2[leftLen])
        {
            leftLen++;
        }

        // Порівнюємо елементи з правого кінця
        while (rightLen < Math.Min(arr1.Length, arr2.Length) && arr1[arr1.Length - rightLen - 1] == arr2[arr2.Length - rightLen - 1])
        {
            rightLen++;
        }

        // Порівнюємо довжини лівої та правої спільних частин і повертаємо більшу
        return Math.Max(leftLen, rightLen);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введіть перший масив слів через пробіл:");
        string input1 = Console.ReadLine();
        string[] arr1 = input1.Split();

        Console.WriteLine("Введіть другий масив слів через пробіл:");
        string input2 = Console.ReadLine();
        string[] arr2 = input2.Split();

        int result = FindLargestCommonEnd(arr1, arr2);
        Console.WriteLine("Довжина найдовшої спильної частини: " + result);
    }
}
