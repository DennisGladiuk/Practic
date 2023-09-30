using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

    public Employee(string name, decimal salary, string position, string department, string email = "n/a", int age = -1)
    {
        Name = name;
        Salary = salary;
        Position = position;
        Department = department;
        Email = email;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість співробітників (N): ");
        int n = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введіть інформацію про співробітника {i + 1}:");
            Console.Write("Ім'я Зарплата Посада Відділ [Електронна пошта (необов'язково)] [Вік (необов'язково)]: ");
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            decimal salary = decimal.Parse(input[1]);
            string position = input[2];
            string department = input[3];

            string email = input.Length > 4 && input[4].Contains('@') ? input[4] : "n/a";
            int age = input.Length > 5 ? int.Parse(input[5]) : -1;

            Employee employee = new Employee(name, salary, position, department, email, age);
            employees.Add(employee);
        }

        var highestAvgSalaryDept = employees
            .GroupBy(e => e.Department)
            .OrderByDescending(g => g.Average(e => e.Salary))
            .First();

        Console.WriteLine($"Highest Average Salary: {highestAvgSalaryDept.Key}");

        foreach (var employee in highestAvgSalaryDept.OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
        }
    }
}
