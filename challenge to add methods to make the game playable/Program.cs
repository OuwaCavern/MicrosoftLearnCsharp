Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
string answer = Console.ReadLine().ToUpper();
if (ShouldPlay(answer)) 
{
    PlayGame();
}

bool ShouldPlay(string consent)
{
    if(consent == "Y")
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool WinOrLose(int target, int roll)
{
    if(target < roll)
    {
        Console.WriteLine("You have won!");
        return true;
    }
    else
    {
        Console.WriteLine("You have lost.");
        return false;
    }
}

void PlayGame() 
{
    bool play = true;

    while (play) 
    {
        int target = random.Next(1, 6);
        int roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.ReadLine();
        Console.WriteLine($"You rolled a {roll}");
        WinOrLose(target, roll);
        Console.WriteLine("\nPlay again? (Y/N)");
        answer = Console.ReadLine();

        play = ShouldPlay(answer);
    }
}