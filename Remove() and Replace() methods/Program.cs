// Use Remove() when there's a standard and consistent position of the characters you want to remove from the string.
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);


//The Replace() method is used when you need to replace one or more characters with a different character (or no character). 
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);