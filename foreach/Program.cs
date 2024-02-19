int[] numbers = {120, 240, 360, 480, 600};

int sum = 0;
int bin = 0;

foreach (int num in numbers)
{
    sum += num;
    bin++;
    Console.WriteLine($"Current iteration is: {bin} and the total is {sum}");
}

Console.WriteLine($"The total is: {sum}");