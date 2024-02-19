/* Code project 1 - write code that validates integer input

 string? readResult;
int numericValue = 0;

Console.WriteLine("Please enter a number between 5 and 10");

do
{
    readResult = Console.ReadLine();
    int.TryParse(readResult, out numericValue);
    Console.WriteLine("Please enter a number between 5 and 10");
}while(numericValue <= 5 || numericValue >= 10);

Console.WriteLine("You have correctly entered a number between 5 and 10"); */

/* Code project 2 - write code that validates string input
string? readString;
Console.WriteLine("Please select your role: Administrator, Manager, or User.");

do
{
    readString = Console.ReadLine();
    readString = readString.Trim().ToLower();
    if (readString == "administrator" || readString == "manager" || readString == "user") continue;
    Console.WriteLine($"{readString} is not a valid username. Please enter a valid username.");
}while(readString != "administrator" && readString != "manager" && readString != "user");

Console.WriteLine($"Welcome {char.ToUpper(readString[0])}{readString.Substring(1)}");
*/

// Code project 3 - Write code that processes the contents of a string array

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
char period = '.';

foreach (string myString in myStrings)
{
    string[] substrings = myString.Split(period);
    foreach (string substring in substrings)
    {
        Console.WriteLine(substring.Trim());
    }
}

/* Microsoft Learn's solution to the Code project 3
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
*/
