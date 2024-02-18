string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string openingStatement = $"Dear {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that will dramatically increase  your return.";
string currentSituation = $"\nCurrently, you own {currentShares:N} shares at a return of {currentReturn:P2}.";
string newSituation = $"\nOur new product, {newProduct} offers a return rate of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.";

Console.WriteLine(openingStatement);
Console.WriteLine(currentSituation);
Console.WriteLine(newSituation);

Console.WriteLine("\nHere's a quick comparison:\n");

string comparisonMessage = $"{currentProduct}\t\t{currentReturn:P2}\t{currentProfit:C}\n{newProduct}\t\t{newReturn:P2}\t{newProfit:C}";

Console.WriteLine(comparisonMessage);

