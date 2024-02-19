/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
*/

string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

Console.WriteLine($"Retrieved value: {fraudulentOrderIDs[0]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine(fraudulentOrderIDs[0]);

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");