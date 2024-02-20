// The next line is called a "Method Signature"
void GenerateRandomNumber()
{
    int generatedNumber = 0;
    Random generator = new Random();
    for (int i = 0; i < 5; i++)
    {
        generatedNumber = generator.Next(1,7);
        Console.WriteLine(generatedNumber);
    }
}

GenerateRandomNumber();