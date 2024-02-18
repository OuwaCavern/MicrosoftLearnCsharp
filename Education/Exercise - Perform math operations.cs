int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

//datatype should be decimal specifically for this to work correctly
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

int first = 7;
int second = 5;
decimal quotiento = (decimal)first / (decimal)second;
Console.WriteLine(quotiento);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

//C# follows the same order of operations as mathematics
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);


//Challenge:
int fahrenheit = 94;
decimal celsius = (decimal)(fahrenheit - 32) * (decimal)(5.0m / 9);
Console.WriteLine($"The temperature is {celsius} Celsius");
//Output
//The temperature is 34.444444444444444444444444447 Celsius