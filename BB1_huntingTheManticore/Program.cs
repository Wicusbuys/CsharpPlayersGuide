//Boss Battle: Hunting the Manticore
//----------------------------------------------------------------------
internal class Program
{
    static int currentRound = 1;
    static int cityHP = 15;
    static int manticoreHP = 10;

    private static void Main(string[] args)
    {
        BeginBattle();
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void BeginBattle()
    {
        int manticoreRange = GetNumber("Player 1, how far away from the city do you want to station the Manticore? ");
        Console.Clear();
        Console.WriteLine("Player 2, it is your turn");

        while (cityHP > 0 && manticoreHP > 0)
        {
            int cannonDamage = DamageForRound(currentRound);
            PrintStatus(currentRound, cityHP, manticoreHP, cannonDamage);
            int cannonRange = GetNumber("Enter desired cannon range: ");
            DealDamage(cannonDamage,cannonRange,manticoreRange);
            currentRound++;
        }

        PrintBattleOutcome(cityHP > 0);
    }

    public static int GetNumber(string query)
    {
        Console.ForegroundColor = ConsoleColor.White;
        int number;
        while (true)
        {
            Console.Write(query);
            if (int.TryParse(Console.ReadLine(), out number) && number >= 0 && number <= 100)
                break;
        }
  
        return number;
    }

    public static int DamageForRound(int round)
    {
        if (round % 15 == 0) return 10;
        else if (round % 5 == 0 || round % 3 == 0) return 3;
        else return 1;
    }

    public static void PrintStatus(int round, int cityHealth, int manticoreHealth, int cannonDamage)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine($"STATUS: Round: {round}  City: {cityHealth}/15   Manticore: {manticoreHealth}/10");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round.");
    }

    public static void DealDamage(int cannonDamage, int cannonRange, int manticoreRange)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        if (cannonRange < manticoreRange)
        {
            Console.WriteLine("That round FELL SHORT of the target.");
            cityHP--;
        }            
        else if (cannonRange > manticoreRange)
        {
            Console.WriteLine("That round OVERSHOT the target.");
            cityHP--;
        }
        else
        { 
            Console.WriteLine("That round was a DIRECT HIT!");
            manticoreHP -= cannonDamage;
        }
    }

    public static void PrintBattleOutcome(bool won)
    {
        if (won)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The city of Consolas has been destroyed! All hope has been lost!");
        } 
            
    }
}