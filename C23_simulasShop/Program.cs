//Challenge: Simula's Shop
//---------------------------------------------------------------

internal class Program
{
    private static void Main(string[] args)
    {
        (SoupType, MainIngredient, Seasoning) soup = MakeSoup();
        Console.WriteLine($"{soup.Item3} {soup.Item2} {soup.Item1}");
    }

    static (SoupType, MainIngredient, Seasoning) MakeSoup()
    {
        SoupType type = GetSoupType();
        MainIngredient ingredient = GetMainIngredient();
        Seasoning seasoning = GetSeasoning();
        return (type, ingredient, seasoning);
    }

    static SoupType GetSoupType()
    {
        while (true)
        {
            Console.Write("Soup type (soup, stew, gumbo): ");
            string? input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "soup":
                    return SoupType.Soup;
                case "stew":
                    return SoupType.Stew;
                case "gumbo":
                    return SoupType.Gumbo;
                default:
                    Console.WriteLine("I can't make that!");
                    break;
            }
        }
    }

    static MainIngredient GetMainIngredient()
    {
        while (true)
        {
            Console.Write("Main ingredient (mushroom, chicken, carrot, potato): ");
            string? input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "mushroom":
                    return MainIngredient.Mushroom;
                case "chicken":
                    return MainIngredient.Chicken;
                case "carrot":
                    return MainIngredient.Carrot;
                case "potato":
                    return MainIngredient.Potatoes;
                default:
                    Console.WriteLine("I don't have that!");
                    break;
            }
        }
    }

    static Seasoning GetSeasoning()
    {
        while (true)
        {
            Console.Write("Seasoning (spicy, salty, sweet): ");
            string? input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "spicy":
                    return Seasoning.Spicy;
                case "salty":
                    return Seasoning.Salty;
                case "sweet":
                    return Seasoning.Sweet;
                default:
                    Console.WriteLine("I don't have that!");
                    break;
            }
        }
    }
}

enum SoupType { Soup, Stew, Gumbo }
enum MainIngredient { Mushroom, Chicken, Carrot, Potatoes }
enum Seasoning { Spicy, Salty, Sweet }