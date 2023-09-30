using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Family
{
    private List<Person> members;

    public Family()
    {
        members = new List<Person>();
    }

    public void AddMember(Person member)
    {
        members.Add(member);
    }

    public Person GetOldestMember()
    {
        return members.OrderByDescending(p => p.Age).FirstOrDefault();
    }
}

class Program
{
    static void Main()
    {
        Family family = new Family();

        // Зчитуємо імена та віки людей і додаємо їх до родини
        Console.Write("Введіть кількість людей в родині (N): ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введіть ім'я та вік для людини {i + 1}:");
            Console.Write("Ім'я: ");
            string name = Console.ReadLine();
            Console.Write("Вік: ");
            int age = int.Parse(Console.ReadLine());

            Person person = new Person { Name = name, Age = age };
            family.AddMember(person);
        }

        // Знаходимо та виводимо найстаршого члена родини
        Person oldestMember = family.GetOldestMember();
        if (oldestMember != null)
        {
            Console.WriteLine($"Найстарший член родини: {oldestMember.Name}, Вік: {oldestMember.Age}");
        }
        else
        {
            Console.WriteLine("Родина порожня.");
        }
    }
}
