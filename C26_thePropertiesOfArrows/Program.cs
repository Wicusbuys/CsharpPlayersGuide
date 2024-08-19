﻿// The Properties of Arrows
//--------------------------------------------------------------------------------------------------
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Vin's shop!");
        Console.WriteLine("Let's build you some arrows!");

        Arrow arrow = GetArrow();

        Console.WriteLine($"Your arrows will cost {arrow.Cost:#.##} gold each!");
    }

    public static Arrow GetArrow()
    {
        Arrowhead arrowhead = GetArrowheadType();
        Fletching fletching = GetFletchingType();
        float length = GetLength();

        return new Arrow(arrowhead, fletching, length);    
    }

    public static Arrowhead GetArrowheadType()
    {
        while (true)
        {
            Console.Write("Arrowhead type (Steel, Wood, Obsidian): ");
            string? input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "steel":
                    return Arrowhead.Steel;
                case "wood":
                    return Arrowhead.Wood;
                case "obsidian":
                    return Arrowhead.Obsidian;
                default:
                    Console.WriteLine("We don't have that!");
                    break;
            }
        }
    }

    public static Fletching GetFletchingType()
    {
        while (true)
        {
            Console.Write("Fletching type (Plastic, Turkey Feather, Goose Feather): ");
            string? input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "plastic":
                    return Fletching.Plastic;
                case "turkey feather":
                    return Fletching.TurkeyFeather;
                case "goose feather":
                    return Fletching.GooseFeather;
                default:
                    Console.WriteLine("We don't have that!");
                    break;
            }
        }
    }

    public static float GetLength()
    {
        while (true)
        {
            Console.Write("Arrow length (between 60 and 100): ");
            if (float.TryParse(Console.ReadLine(), out float length))
            {
                if (length >= 60 && length <= 100)
                {
                    return length;
                }
            }
            Console.WriteLine("Enter a valid length!");
        }
    }
}

class Arrow 
{
    private Arrowhead Arrowhead {get;}
    private Fletching Fletching {get;}
    private float Length {get;}

    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = length;
    }

    public float Cost
    {
        get
        {
            float arrowheadCost = Arrowhead switch
            {
                Arrowhead.Steel => 10,
                Arrowhead.Wood => 3,
                Arrowhead.Obsidian => 5,
                _ => 0
            };

            float fletchingCost = Fletching switch
            {
                Fletching.Plastic => 10,
                Fletching.TurkeyFeather => 5,
                Fletching.GooseFeather => 3,
                _ => 0
            };

            float shaftCost = 0.05f * Length;

            return arrowheadCost + fletchingCost + shaftCost;
        }
    }

}

enum Arrowhead {Steel, Wood, Obsidian}
enum Fletching {Plastic, TurkeyFeather, GooseFeather}