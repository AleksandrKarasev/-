string GetLethsfromString (string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (Char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string letter = Console.ReadLine();
string str = GetLethsfromString(letter);
Console.WriteLine(str);