//Challenge: The dominion of kings
//-----------------------------------------------------------------------------------
Console.Write("Number of provinces = ");
int provinces = Convert.ToInt32(Console.ReadLine());

Console.Write("Number of duchies = ");
int duchies = Convert.ToInt32(Console.ReadLine());

Console.Write("Number of estates = ");
int estates = Convert.ToInt32(Console.ReadLine());

int total_points = (provinces * 6) + (duchies * 3) + (estates * 1);

Console.WriteLine("Total number of points = " + total_points);
