using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть перший рядок символів:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Введіть другий рядок символів:");
        string input2 = Console.ReadLine();

        char[] arr1 = input1.ToCharArray();
        char[] arr2 = input2.ToCharArray();

        int minLength = Math.Min(arr1.Length, arr2.Length); // Цей рядок коду визначає мінімальну довжину двох масивів символів 

        // Порівнюємо символи лексикографічно
        for (int i = 0; i < minLength; i++)
        {
            if (arr1[i] < arr2[i])
            {
                Console.WriteLine(input1);
                Console.WriteLine(input2);
                return;
            }
            else if (arr1[i] > arr2[i])
            {
                Console.WriteLine(input2);
                Console.WriteLine(input1);
                return;
            }
        }

        // Якщо всі символи досягли цього моменту, то перевіряємо довжини
        if (arr1.Length < arr2.Length)
        {
            Console.WriteLine(input1);
            Console.WriteLine(input2);
        }
        else if (arr1.Length > arr2.Length)
        {
            Console.WriteLine(input2);
            Console.WriteLine(input1);
        }
        else
        {
            Console.WriteLine(input1);
            Console.WriteLine(input2);
        }
    }
}
