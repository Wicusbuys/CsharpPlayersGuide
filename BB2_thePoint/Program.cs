//Boss Battle: The Point
//--------------------------------------------------------------------

internal class Program
{
    private static void Main(string[] args)
    {
        Point firstPoint = new Point(2, 3);
        Point secondPoint = new Point(-4, 0);

        Console.WriteLine($"First Point : ({firstPoint.X}, {firstPoint.Y})");
        Console.WriteLine($"Second Point: ({secondPoint.X}, {secondPoint.Y})");
    }
}

class Point
{
    public int X { get;}
    public int Y { get;}

    public Point (int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point () : this (0, 0) {}
}