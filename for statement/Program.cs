/* string[] customers = { "Mehmet", "Ahmet", "Hasan", "Burak" };
for (int i = (customers.Length - 1); i >= 0; i--)
{
    Console.WriteLine(customers[i]);
}
 */


/*
Can`t do if statements inside foreach statement but you can do so in for statements
*/
/* string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}
 */

string[] names = {  "Mehmet", "Ahmet", "Hasan", "Burak" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "Burak")
    {
        names[i] = "Huseyin";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}