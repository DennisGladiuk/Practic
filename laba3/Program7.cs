using System;
using System.Collections.Generic;
using System.Globalization;

public class Car
{
    public string Model { get; }
    public double FuelAmount { get; private set; }
    public double FuelConsumptionPerKm { get; }
    public double DistanceTraveled { get; private set; }

    public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKm = fuelConsumptionPerKm;
        DistanceTraveled = 0;
    }

    public bool CanMove(double distance)
    {
        double fuelRequired = distance * FuelConsumptionPerKm;
        return FuelAmount >= fuelRequired;
    }

    public void Move(double distance)
    {
        double fuelRequired = distance * FuelConsumptionPerKm;
        FuelAmount -= fuelRequired;
        DistanceTraveled += distance;
    }

    public override string ToString()
    {
        return $"{Model} {FuelAmount:f2} {DistanceTraveled:f2}";
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Ласкаво просимо до програми для відстеження автомобілів.");
        Console.Write("Введіть кількість автомобілів (N): ");
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Car> cars = new Dictionary<string, Car>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введіть інформацію про автомобіль {i + 1}:");
            Console.Write("Модель Пальне Витрата_пального_на_км: ");
            string[] carInfo = Console.ReadLine().Split();
            string model = carInfo[0];
            double fuelAmount = double.Parse(carInfo[1], CultureInfo.InvariantCulture);
            double fuelConsumption = double.Parse(carInfo[2], CultureInfo.InvariantCulture);

            Car car = new Car(model, fuelAmount, fuelConsumption);
            cars[model] = car;
        }

        Console.WriteLine("Доступні команди:");
        Console.WriteLine("1. Drive <Модель> <Відстань> - перемістити автомобіль на певну відстань.");
        Console.WriteLine("2. End - завершити програму.");

        string input;
        while (true)
        {
            Console.WriteLine("Введіть команду:");
            input = Console.ReadLine();

            if (input == "End")
                break;

            string[] commandArgs = input.Split();
            if (commandArgs.Length != 3 || commandArgs[0] != "Drive")
            {
                Console.WriteLine("Невірний формат команди. Спробуйте знову.");
                continue;
            }

            string model = commandArgs[1];
            double distance = double.Parse(commandArgs[2], CultureInfo.InvariantCulture);

            if (!cars.ContainsKey(model))
            {
                Console.WriteLine("Автомобіль не знайдено. Спробуйте знову.");
                continue;
            }

            if (cars[model].CanMove(distance))
            {
                cars[model].Move(distance);
                Console.WriteLine($"Автомобіль {model} переміщено на {distance:f2} км.");
            }
            else
            {
                Console.WriteLine("Недостатньо пального для подорожі.");
            }
        }

        Console.WriteLine("Стан автомобілів:");
        foreach (var car in cars.Values)
        {
            Console.WriteLine(car);
        }
        Console.ReadLine();
    }
}
