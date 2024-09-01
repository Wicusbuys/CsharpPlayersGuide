//Challenge: The four sisters and the duckbear
//-----------------------------------------------------------------------------------
Console.Write("Number of chocolate eggs = ");
int eggs = Convert.ToInt32(Console.ReadLine());

int eggs_per_sister = eggs / 4;
int eggs_for_duckbear = eggs % 4;

Console.WriteLine("Sisters get " + eggs_per_sister + " each.");
Console.WriteLine("Duckbear gets " + eggs_for_duckbear + " eggs.");

