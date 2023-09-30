using System;
using System.Collections.Generic;
using System.Text;

class Engine
{
    public string Model { get; set; }
    public int Power { get; set; }
    public int? Displacement { get; set; }
    public string Efficiency { get; set; }

    public Engine(string model, int power, int? displacement, string efficiency)
    {
        Model = model;
        Power = power;
        Displacement = displacement;
        Efficiency = efficiency;
    }

    public override string ToString()
    {
        return $"{Model}:\n Power: {Power}\n Displacement: {(Displacement.HasValue ? Displacement.ToString() : "n/a")}\n Efficiency: {Efficiency}\n";
    }
}

class Car
{
    public string Model { get; set; }
    public Engine CarEngine { get; set; }
    public int? Weight { get; set; }
    public string Color { get; set; }

    public Car(string model, Engine engine, int? weight, string color)
    {
        Model = model;
        CarEngine = engine;
        Weight = weight;
        Color = color;
    }

    public override string ToString()
    {
        return $"{Model}:\n {CarEngine.ToString()} Weight: {(Weight.HasValue ? Weight.ToString() : "n/a")}\n Color: {Color}\n";
    }
}

class Program
{
    static void Main()
    {
        int engineCount = int.Parse(Console.ReadLine());
        Dictionary<string, Engine> engines = new Dictionary<string, Engine>();

        for (int i = 0; i < engineCount; i++)
        {
            string[] engineInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = engineInfo[0];
            int power = int.Parse(engineInfo[1]);
            int? displacement = engineInfo.Length > 2 ? (int.TryParse(engineInfo[2], out int disp) ? disp : (int?)null) : (int?)null;
            string efficiency = engineInfo.Length > 3 ? engineInfo[3] : "n/a";
            engines[model] = new Engine(model, power, displacement, efficiency);
        }

        int carCount = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < carCount; i++)
        {
            string[] carInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = carInfo[0];
            string engineModel = carInfo[1];
            Engine carEngine = engines[engineModel];
            int? weight = carInfo.Length > 2 ? (int.TryParse(carInfo[2], out int w) ? w : (int?)null) : (int?)null;
            string color = carInfo.Length > 3 ? carInfo[3] : "n/a";
            cars.Add(new Car(model, carEngine, weight, color));
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }
}
