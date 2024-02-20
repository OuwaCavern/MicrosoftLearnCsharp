string[] ipv4Inputs = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
foreach(string ipv4Input in ipv4Inputs)
{
    bool validLength = false;
    bool validZeroes = false;
    bool validRange = false;

    ValidateLength();
    ValidateRange();
    ValidateZeroes();

    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{ipv4Input} is a valid IPv4 address");
    } 
    else
    {
        Console.WriteLine($"{ipv4Input} is an invalid IPv4 address");
    }

    void ValidateLength()
    {
        string[] numbersOfAddress = ipv4Input.Split('.');
        foreach (string number in numbersOfAddress)
        {
            int numberInt;
            if (int.TryParse(number, out numberInt))
            {
                validLength = true;
            }
            else
            {
                validLength = false;
                return;
            }
        }
    }

    void ValidateRange()
    {
        string[] numbersOfAddress = ipv4Input.Split('.');
        byte numberByte;
        foreach(string number in numbersOfAddress)
        {
            if (byte.TryParse(number, out numberByte))
            {
                validRange = true;
            }
            else
            {
                validRange = false;
                return;
            }
        }
    }

    void ValidateZeroes()
    {
        string[] numbersOfAddress = ipv4Input.Split('.');
        foreach(string number in numbersOfAddress)
        {
            if (number.Length > 1  && number.StartsWith("0"))
            {
                validZeroes = false;
                return;
            }
            else
            {
                validZeroes = true;
            }
        }
    }
}