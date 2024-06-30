int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue;
int total = 0;

foreach (int num in array)
{
    if (num < currentSmallest)
    currentSmallest = num;

    total += num;
}

float average = (float)total / array.Length;
Console.WriteLine($"The average is {average} and the smallest number is {currentSmallest}");
