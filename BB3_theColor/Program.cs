//Boss Battle: The Color
//-------------------------------------------------------

internal class Program
{
    private static void Main(string[] args)
    {
        Color firstColor = new Color(0, 100,0);
        Color secondColor = Color.Purple;

        Console.WriteLine($"First Color: R= {firstColor.R} G= {firstColor.G} B= {firstColor.B}");
        Console.WriteLine($"Second Color: R= {secondColor.R} G= {secondColor.G} B= {secondColor.B}");
    }
}

class Color
{
    public int R {get;}
    public int G {get;}
    public int B {get;}

    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    public Color () : this(0, 0, 0) {}

    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 128, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Purple { get; } = new Color(128, 0, 128);
}