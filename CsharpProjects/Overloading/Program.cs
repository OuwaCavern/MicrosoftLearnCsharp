Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(14);
int roll3 = dice.Next(50,75);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
