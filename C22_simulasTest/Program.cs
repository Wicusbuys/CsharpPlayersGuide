//Challenge: Simula's Test
//--------------------------------------------------

ChestState state = ChestState.Locked;

while (true)
{
    Console.Write($"The chest is {state}. What do you want to do? ");

    string input = Console.ReadLine();

    if (state == ChestState.Locked && input == "unlock") state = ChestState.Closed;
    if (state == ChestState.Closed && input == "open") state = ChestState.Open;
    if (state == ChestState.Open && input == "close") state = ChestState.Closed;
    if (state == ChestState.Closed && input == "lock") state = ChestState.Locked;
}

enum ChestState { Open, Closed, Locked }