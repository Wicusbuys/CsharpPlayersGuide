int[] originalArray = new int[5];

Console.WriteLine("Enter 5 numbers.");

for (int i = 0; i < originalArray.Length; i++)
{
    Console.Write($"Number {i+1}: ");
    originalArray[i] = Convert.ToInt32(Console.ReadLine());
}

int[] copiedArray = new int[5];

for (int i = 0; i < originalArray.Length; i++)
{
    copiedArray[i] = originalArray[i];
}

for (int i = 0; i < originalArray.Length; i++)
{
    Console.WriteLine($"Original array: {originalArray[i],-20} Copied array: {copiedArray[i]}");
}