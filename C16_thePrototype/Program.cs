//Challenge: The Prototype
//-------------------------------------------------------------
int number;

while (true)
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    if (int.TryParse(Console.ReadLine(), out number) && number >= 0 && number <= 100)
        break;
    else
        Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
}

Console.Clear();

Console.WriteLine("User 2, guess the number.");

while (true)
{
    Console.Write("What is your next guess? ");
    if (int.TryParse(Console.ReadLine(), out int guess))
    {
        if (guess > number)
            Console.WriteLine($"{guess} is too high.");
        else if (guess < number)
            Console.WriteLine($"{guess} is too low.");
        else
        {
            Console.WriteLine("You guessed the number!");
            break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}
