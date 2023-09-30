using System;
using System.Collections.Generic;

class Rectangle
{
    public string Id { get; private set; }
    public int Width { get; private set; }
    public int Height { get; private set; }
    public int X { get; private set; }
    public int Y { get; private set; }

    public Rectangle(string id, int width, int height, int x, int y)
    {
        Id = id;
        Width = width;
        Height = height;
        X = x;
        Y = y;
    }

    public bool Intersects(Rectangle other)
    {
        return X < other.X + other.Width &&
               X + Width > other.X &&
               Y < other.Y + other.Height &&
               Y + Height > other.Y;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        List<Rectangle> rectangles = new List<Rectangle>();

        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine().Split();
            string id = input[0];
            int width = int.Parse(input[1]);
            int height = int.Parse(input[2]);
            int x = int.Parse(input[3]);
            int y = int.Parse(input[4]);

            rectangles.Add(new Rectangle(id, width, height, x, y));
        }

        for (int i = 0; i < m; i++)
        {
            input = Console.ReadLine().Split();
            string id1 = input[0];
            string id2 = input[1];

            Rectangle rect1 = rectangles.Find(r => r.Id == id1);
            Rectangle rect2 = rectangles.Find(r => r.Id == id2);

            if (rect1 != null && rect2 != null)
            {
                bool intersect = rect1.Intersects(rect2);
                Console.WriteLine(intersect);
            }
        }
    }
}
