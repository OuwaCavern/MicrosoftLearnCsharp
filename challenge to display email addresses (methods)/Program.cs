string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    DisplayMailAddress(positionOfEmployee: i, corpOrExt: "corp");
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    DisplayMailAddress(i, "ext", externalDomain);
}

void DisplayMailAddress(int positionOfEmployee, string corpOrExt, string domain = "contoso.com")
{   
    if(corpOrExt=="corp")
    {
        string firstName = corporate[positionOfEmployee, 0].Substring(0,2).ToLower();
        string lastName = corporate[positionOfEmployee, 1].ToLower();
        Console.WriteLine($"{firstName}{lastName}@{domain}");
    }
    else if(corpOrExt=="ext")
    {
        string firstName = external[positionOfEmployee, 0].Substring(0,2).ToLower();
        string lastName = external[positionOfEmployee, 1].ToLower();
        Console.WriteLine($"{firstName}{lastName}@{domain}");
    }
}