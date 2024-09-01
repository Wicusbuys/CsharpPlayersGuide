//Challenge: Taking a number
//--------------------------------------------------------
int randomNumber = AskForNumber("Please give a random number.");
int randomNumberInRange = AskForNumberInRange("Please give a random number between 0 and 100", 0, 100);
Console.WriteLine(randomNumber);
Console.WriteLine(randomNumberInRange);

int AskForNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AskForNumberInRange(string text, int min, int max)
{
    int number = int.MaxValue;
    do
    {
        Console.WriteLine(text);
        number = Convert.ToInt32(Console.ReadLine());
    }
    while (number <= min || number >= max);

    return number;
}