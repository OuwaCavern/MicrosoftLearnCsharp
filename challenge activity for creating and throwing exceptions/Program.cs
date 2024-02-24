string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

Workflow1(userEnteredValues);

static void Workflow1(string[][] userEnteredValues)
{
    bool abortProcess = false;
    for (int i = 0; i < userEnteredValues.Length && abortProcess == false; i++)
    {
        try
        {
            Process1(userEnteredValues[i]);
            Console.WriteLine("'Process1' completed successfully.");
        }
        catch (FormatException)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.\n\rInvalid data. User input values must be valid integers.");
        }
    }
}


static void Process1(String[] userEntries)
{
    int valueEntered = 0;

    foreach (string userValue in userEntries)
    {
        valueEntered = Convert.ToInt32(userValue);
        try
        {
            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Invalid data. User input values must be non-zero values.");
        }

    }
}