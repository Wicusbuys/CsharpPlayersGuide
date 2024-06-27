// //Challenge: The Thing Namer 3000
//-----------------------------------------------------------------------------------
Console.WriteLine("What kind of thing are we talking about?");

// Thing type.
string a = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

// Description.
string b = Console.ReadLine();

// "of Doom" text.
string c = "Doom"; // Modified to fix the "of of" bug.

/* The number. */
string d = "3000";

Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");

/* Using discriptive variable names would increase the understandability of the code.*/
