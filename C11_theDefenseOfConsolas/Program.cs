//Challenge: The defence of Consolas
//----------------------------------------------------
Console.Title = "Defence of Consolas";

Console.Write("Target Row? ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column? ");
int col = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Deploy to:");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"({row} , {col - 1})");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"({row - 1} , {col})");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"({row} , {col + 1})");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"({row + 1} , {col})");

for ( int i = 0; i < 4; i++ )
{
    Console.Beep(100, 250);
}

Console.ReadKey();
Console.ForegroundColor= ConsoleColor.White;