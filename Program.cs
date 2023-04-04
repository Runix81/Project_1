string DoString()
{
    bool lowerCase = false;
    char offset = lowerCase ? 'a' : 'A';
    int lettersOffset = 26;
    Random rnd = new Random();
    int size = rnd.Next(1, 7);
    string res = "";

    for (var i = 0; i < size; i++)
    {
        char letter = (char)rnd.Next(offset, offset + lettersOffset);
        res += letter;
    }
    return res;
}

