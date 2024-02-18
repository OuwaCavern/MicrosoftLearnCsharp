//The PadLeft() method adds blank spaces to the left-hand side of the string so that the total number of characters equals the argument you send it. In this case, you want the total length of the string to be 12 characters.
string input = "Pad this";
 Console.WriteLine(input.PadLeft(12));


//Alternatively, you may select what to pad with (instead of using whitespaces)
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));


//Padding and alignment example
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);