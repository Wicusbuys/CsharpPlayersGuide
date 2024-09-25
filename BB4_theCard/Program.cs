//Boss Battle: The Card
//---------------------------------------------------------

internal class Program
{
    private static void Main(string[] args)
    {
        Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow };
        Rank[] ranks= new Rank[] { Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.DollarSign, Rank.Percent, Rank.Caret, Rank.Ampersand };

        foreach (Color color in colors)
        {
            foreach (Rank rank in ranks)
            {
                Card card = new Card(color, rank);
                Console.WriteLine($"The {card.Color} {card.Rank} {card.IsSymbol} {card.IsNumber}");
            }
        }
    }
}

class Card 
{
    public Color Color { get;}
    public Rank Rank { get;}

    public Card (Color color, Rank rank)
    {
        Color = color;
        Rank = rank;
    }

    public bool IsSymbol => Rank > Rank.Ten;
    public bool IsNumber => !IsSymbol;
}

enum Color {Red, Green, Blue, Yellow}
enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }