using System;
using System.Linq;



public static class Isogramma
{
    public static bool Verifica(string word)
    {
     var Alphabet = new int [26];
        foreach(var Letter in word.ToLower())
        {
            if (Char.IsLetter(Letter))
            {
                Alphabet [Letter - 'a']++;
                if (Alphabet[Letter - 'a'] > 1)
                    return false;
            }
        }
        return true;
    }

}