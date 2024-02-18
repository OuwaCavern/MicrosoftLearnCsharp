//Composite Formatting
//Composite formatting uses numbered placeholders within a string. At run time, everything inside the braces is resolved to a value that is also passed in based on their position.
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
/* Data types and variables of a given data type have built-in "helper methods" to make certain tasks easy.
The literal string "{0} {1}!" forms a template, parts of which are replaced at run time.
The token {0} is replaced by the first argument after the string template, in other words, the value of the variable first.
The token {1} is replaced by the second argument after the string template, in other words, the value of the variable second. */
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);


decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
//Notice how adding the :C to the tokens inside of the curly braces formats the number as currency regardless of whether you use int or decimal.
// the string formatting syntax might use a different format depending on the user's culture ($ for USA, € for European countries etc.).


decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
//Measurement: 123,456.7891 units. The number that comes after :N defines the number of decimal points.


decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
//Tax rate: 36.79 %

