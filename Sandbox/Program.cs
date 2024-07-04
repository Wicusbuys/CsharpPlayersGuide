//testing arrays

int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

foreach (var num in numbers)
{
    Console.WriteLine(num);
}

Console.WriteLine("");
Console.WriteLine(numbers[^1]);
Console.WriteLine("");

int[] firstThreeNumbers = numbers[0..3];

foreach (var num in firstThreeNumbers)
{
    Console.WriteLine(num);
}