string[] values = { "12.3", "45", "ABC", "11", "DEF" };
float total = 0;
float parsedNumber = 0;
string message = "";

foreach(string v in values)
{
    if (float.TryParse(v, out parsedNumber))
    {
        total += parsedNumber;
    }
    else if (true)
    {
        message = message + v;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");