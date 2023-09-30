using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        Console.Write("Введіть кількість людей (N): ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введіть ім'я і вік для людини {i + 1}:");
            Console.Write("Ім'я: ");
            string name = Console.ReadLine();
            Console.Write("Вік: ");
            int age = int.Parse(Console.ReadLine());

            Person person = new Person { Name = name, Age = age };
            people.Add(person);
        }

        // Виводимо людей, вік яких старше 30 років, в алфавітному порядку
        var result = people
            .Where(person => person.Age > 30)
            .OrderBy(person => person.Name)
            .ToList();

        Console.WriteLine("Люди старше 30 років у алфавітному порядку:");
        foreach (var person in result)
        {
            Console.WriteLine($"Ім'я: {person.Name}, Вік: {person.Age}");
        }
    }
}
