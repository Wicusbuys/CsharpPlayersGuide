//Challenge: The Magic Cannon
//--------------------------------------------------------
for (int turn = 1; turn < 100; turn++)
{
    if (turn % 15 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{turn}: Kaboom!");
    }
    else if (turn % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{turn}: Electric");
    }
    else if (turn % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{turn}: Fire");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{turn}: Normal");
    }
}

Console.ForegroundColor = ConsoleColor.White;
