using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person { Name = "Іван", Age = 25 };
        Person person2 = new Person { Name = "Марія", Age = 30 };

        Console.WriteLine($"Перша особа: Ім'я - {person1.Name}, Вік - {person1.Age}");
        Console.WriteLine($"Друга особа: Ім'я - {person2.Name}, Вік - {person2.Age}");
    }
}

