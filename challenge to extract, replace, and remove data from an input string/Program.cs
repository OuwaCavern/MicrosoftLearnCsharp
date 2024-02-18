const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string? output;

const string openDiv = "<div>";
const string closeDiv = "</div>";
const string openSpan = "<span>";
const string closeSpan = "</span>";
int divOpeningPosition = input.IndexOf(openDiv);
int divClosingPosition = input.IndexOf(closeDiv);
int spanOpeningPosition = input.IndexOf(openSpan);

// Add the length of the parts we want to remove to properly use in the Substring method.
spanOpeningPosition += openSpan.Length;
divOpeningPosition += openDiv.Length;

int substringLength = divClosingPosition - divOpeningPosition;
string removedDiv = input.Substring(divOpeningPosition, substringLength);
output = removedDiv.Replace("&trade", "&reg");
quantity = input.Remove(0, spanOpeningPosition);

// To get the correct position of the closing span string, we use IndexOf method here, after removing the opening span string, instead as a special exception.
int spanClosingPosition = quantity.IndexOf(closeSpan);
quantity = quantity.Remove(spanClosingPosition, quantity.Length - spanClosingPosition);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");


/* Microsoft Learn's solution:
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output); */