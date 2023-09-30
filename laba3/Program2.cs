using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Конструктор без параметрів
    public Person()
    {
        Name = "No name";
        Age = 1;
    }

    // Конструктор з одним параметром (вік)
    public Person(int age)
    {
        Name = "No name";
        Age = age;
    }

    // Конструктор з двома параметрами (ім'я та вік)
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єктів типу Person за допомогою різних конструкторів
        Person person1 = new Person(); 
        Person person2 = new Person(25); 
        Person person3 = new Person("Іван", 30);

        // Виведення інформації про об'єкти
        Console.WriteLine($"Перша особа: Ім'я - {person1.Name}, Вік - {person1.Age}");
        Console.WriteLine($"Друга особа: Ім'я - {person2.Name}, Вік - {person2.Age}");
        Console.WriteLine($"Третя особа: Ім'я - {person3.Name}, Вік - {person3.Age}");
    }
}
