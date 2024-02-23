string? readResult;
int startIndex = 0;
bool goodEntry = false;

int[] numbers = { 1, 2, 3, 4, 5 };

// Display the array to the console.
Console.Clear();
Console.Write("\n\rThe 'numbers' array contains: { ");
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}

// To calculate a sum of array elements, 
//  prompt the user for the starting element number.
Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
while (goodEntry == false)
{
    readResult = Console.ReadLine();
    goodEntry = int.TryParse(readResult, out startIndex);
    startIndex -= 1;
    if (startIndex > 4 || startIndex < 0)
    {
        goodEntry = false;
        Console.WriteLine("\n\rEnter an integer value between 1 and 5");
    }
}

// Display the sum and then pause.
Console.WriteLine($"\n\rThe sum of numbers {startIndex + 1} through {numbers.Length} is: {SumValues(numbers, startIndex)}");

Console.WriteLine("press Enter to exit");
readResult = Console.ReadLine();

// This method returns the sum of elements n through 5
static int SumValues(int[] numbers, int n)
{
    int sum = 0;
    for (int i = n; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}
// About launch.json file's terminal section:
//The DEBUG CONSOLE panel doesn't support console input. For example, the DEBUG CONSOLE can't be used if the application includes a Console.ReadLine() statement. When you're working on a C# console application that reads user input, the console setting must be set to either integratedTerminal or externalTerminal. Console applications that write to the console, but don't read input from the console, can use any of the three console settings.