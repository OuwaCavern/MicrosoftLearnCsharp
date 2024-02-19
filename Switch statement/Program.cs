/*
The switch expression is evaluated against the case labels from top to bottom until a value that is equal to the switch expression is found.
 If none of the labels are a match, the statement list for the default case will be executed. If no default is included, control is transferred
  to the end point of the switch statement.
 Each label must provide a value type that matches the type specified in the switch expression.
*/

int employeeLevel = 100;
string employeeName = "John Smith";
string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName} is currently {title}.");