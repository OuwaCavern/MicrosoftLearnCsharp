Random dice  = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine("The dice rolls and you got...");
Console.WriteLine(roll1);
Console.WriteLine("The dice rolls and you got...");
Console.WriteLine(roll2);
Console.WriteLine("The dice rolls and you got...");
Console.WriteLine(roll3);

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You have rolled triples! You got extra 3 points.");
    total += 6;
}
else {
    Console.WriteLine("You have rolled doubles! You got extra 2 points.");
    total += 2;
}
}


if (total >= 16)
{
    Console.WriteLine($"You have rolled {total}! You have won a car!");
}
else if (total >= 10)
{
    Console.WriteLine($"You have rolled {total}! You have won a laptop!");
}
else if (total == 7)
{
    Console.WriteLine($"You have rolled {total}! You have won a trip!");
}
else
{
    Console.WriteLine("You have won a kitten!");
}