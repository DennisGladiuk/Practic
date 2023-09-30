using System;
using System.Collections.Generic;
using System.Linq;

class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
    public List<Tire> Tires { get; set; }

    public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,
               double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age,
               double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
    {
        Model = model;
        Engine = new Engine(engineSpeed, enginePower);
        Cargo = new Cargo(cargoWeight, cargoType);
        Tires = new List<Tire>
        {
            new Tire(tire1Pressure, tire1Age),
            new Tire(tire2Pressure, tire2Age),
            new Tire(tire3Pressure, tire3Age),
            new Tire(tire4Pressure, tire4Age)
        };
    }

    public override string ToString()
    {
        return Model;
    }
}

class Engine
{
    public int Speed { get; set; }
    public int Power { get; set; }

    public Engine(int speed, int power)
    {
        Speed = speed;
        Power = power;
    }
}

class Cargo
{
    public int Weight { get; set; }
    public string Type { get; set; }

    public Cargo(int weight, string type)
    {
        Weight = weight;
        Type = type;
    }
}

class Tire
{
    public double Pressure { get; set; }
    public int Age { get; set; }

    public Tire(double pressure, int age)
    {
        Pressure = pressure;
        Age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] carInfo = Console.ReadLine().Split();
            string model = carInfo[0];
            int engineSpeed = int.Parse(carInfo[1]);
            int enginePower = int.Parse(carInfo[2]);
            int cargoWeight = int.Parse(carInfo[3]);
            string cargoType = carInfo[4];
            double tire1Pressure = double.Parse(carInfo[5].Replace('.', ','));
            int tire1Age = int.Parse(carInfo[6]);
            double tire2Pressure = double.Parse(carInfo[7].Replace('.', ','));
            int tire2Age = int.Parse(carInfo[8]);
            double tire3Pressure = double.Parse(carInfo[9].Replace('.', ','));
            int tire3Age = int.Parse(carInfo[10]);
            double tire4Pressure = double.Parse(carInfo[11].Replace('.', ','));
            int tire4Age = int.Parse(carInfo[12]);

            Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType,
                              tire1Pressure, tire1Age, tire2Pressure, tire2Age,
                              tire3Pressure, tire3Age, tire4Pressure, tire4Age);

            cars.Add(car);
        }

        string command = Console.ReadLine();

        if (command == "fragile")
        {
            List<Car> fragileCars = cars
                .Where(car => car.Cargo.Type == "fragile" &&
                               car.Tires.Any(tire => tire.Pressure < 1))
                .ToList();

            foreach (var fragileCar in fragileCars)
            {
                Console.WriteLine(fragileCar);
            }
        }
        else if (command == "flamable")
        {
            List<Car> flamableCars = cars
                .Where(car => car.Cargo.Type == "flamable" &&
                               car.Engine.Power > 250)
                .ToList();

            foreach (var flamableCar in flamableCars)
            {
                Console.WriteLine(flamableCar);
            }
        }
    }
}
