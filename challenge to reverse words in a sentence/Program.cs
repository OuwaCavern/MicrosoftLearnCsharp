string pangram = "The quick brown fox jumps over the lazy dog";
char[] pangramArray = new char[pangram.Length];
string[] wordsOfPangram = new string[9];
string reversedWordArrayTotal = "";

wordsOfPangram = pangram.Split(' ');

foreach(string word in wordsOfPangram)
{
    string? reversedWord;
    char[] reversedWordArray = word.ToCharArray();
    Array.Reverse(reversedWordArray);
    reversedWord = string.Join("", reversedWordArray);
    reversedWordArrayTotal = reversedWordArrayTotal + reversedWord + " ";
}

Console.WriteLine(reversedWordArrayTotal.Trim());



/* Microsoft Learn's solution:
string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result); */