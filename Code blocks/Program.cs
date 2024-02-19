bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
Console.WriteLine(value)

/* URL = https://learn.microsoft.com/en-us/training/modules/csharp-code-blocks/2-exercise-variable-scope
// Code sample 1
bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");

// Code sample 2
int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");

//////You may feel that these two samples should always produce the same result, but the C# compiler interprets these two code samples differently.

//////For the first code sample, the compiler interprets flag as a Boolean variable that could be assigned a value of either true or false. The compiler concludes that if flag is false, value will not be initialized when the second Console.WriteLine() is executed. Essentially the compiler considers the following two code execution paths to be possible:

// path when flag = true
int value;
value = 10;
Console.WriteLine($"Inside the code block: {value}");
Console.WriteLine($"Outside the code block: {value}");
AND

// path when flag = false
int value;
Console.WriteLine($"Outside the code block: {value}");

///////Since the compiler considers the second path a possibility (for code sample 1), it generates an error message during the build process. In addition, the code Editor in Visual Studio Code warns you of this issue by displaying a red squiggly line under value (below the code block).

///////For the second code sample, the complier concludes that the contents of the if statement code block will always be executed (true is always true). The compiler doesn't generate a build error because it interprets the second code sample to have a single execution path as follows:

int value;
value = 10;
Console.WriteLine($"Inside the code block: {value}");
Console.WriteLine($"Outside the code block: {value}");
*/
