Random coinFlip = new Random();
int numericResult = coinFlip.Next(1, 3);
Console.WriteLine($"The result of the coinflip is: {(numericResult == 1 ? "Heads" : "Tails")}");