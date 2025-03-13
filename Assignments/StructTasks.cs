namespace Assignments;

using System;

struct Point
{
    public readonly int X;
    public readonly int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"Point: ({X}, {Y})";
}

readonly struct Vector
{
    public int X { get; }
    public int Y { get; }

    public Vector(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"Vector: ({X}, {Y})";
}

readonly struct Point3D
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double DistanceTo(Point3D other)
    {
        double dx = X - other.X;
        double dy = Y - other.Y;
        double dz = Z - other.Z;
        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}

class StructTasks
{
    public static void RunTasks()
    {
        Point p = new Point(3, 4);
        Console.WriteLine(p);

        Vector v = new Vector(2, 5);
        Console.WriteLine(v);

        Point3D p1 = new Point3D(1, 2, 3);
        Point3D p2 = new Point3D(5, 6, 7);
        Console.WriteLine($"Distance: {p1.DistanceTo(p2):F2}");
    }
}
