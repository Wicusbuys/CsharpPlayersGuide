//Challenge: Taking a number
//--------------------------------------------------------
int AskForNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AskForNumberInRange(string text, int min, int max)
{
    do
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
    }
    while (number < min && number > max);

    return number;
}