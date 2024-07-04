//Challenge: Countdown
//-----------------------------------------
int number;

do
{
    Console.WriteLine("Enter a number to countdown from");
    number = Convert.ToInt32(Console.ReadLine());
}
while (number <= 0);

Countdown(number);

 void Countdown(int number)
 {
    if (number == 0) return;

    Console.WriteLine(number);
    Countdown(number - 1);
 }
