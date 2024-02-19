//The term widening conversion means that you're attempting to convert a value from a data type that could hold less information to a data type that can hold more information. In this case, a value stored in a variable of type int converted to a variable of type decimal, doesn't lose information.

//Casting:
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

//ToString conversion
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

// Converting a string to an int
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

//Convert a string to int using Convert method
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

//The first line would give the result of 1 while the second line will give you the result of 2
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

/* //Use TryParse()
The TryParse() method does several things simultaneously:

It attempts to parse a string into the given numeric data type.
If successful, it stores the converted value in an out parameter, explained in following section.
It returns a bool to indicate whether the action succeeded or failed. */

//Out parameters
//Methods can return a value or return "void" - meaning they return no value. Methods can also return values through out parameters, which are defined just like an input parameter,
// but include the out keyword.
//
//The converted value is stored in the int variable result. The int variable result is declared and initialized before this line of code,
// so it should be accessible both inside the code blocks that belong to the if and else statements, as well as outside of them.
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");



