# isogramma
-Determina se una parola o una frase è un isogramma.

Per come lo intendiamo in questo esercizio, un isogramma è una parola o una frase che non ha lettere ripetute.
Sono ammessi spazi e segni di punteggiatura ripetuti.

Esempi di isogrammi:

- lumberjacks
- background
- downstream
- six-year-old

-Il codice inizia con la creazione di un array di interi "Alphabet" con 26 elementi, uno per ogni lettera dell'alfabeto inglese. Questo array viene utilizzato per tenere traccia delle lettere che sono state incontrate nella stringa.
```c#
public static class Isogramma
{
    public static bool Verifica(string word)
    {
     var Alphabet = new int [26];
```
-Successivamente, il codice utilizza un ciclo foreach per scorrere ogni lettera nella stringa "word", convertendola in minuscolo. Per ogni lettera, viene controllato se è una lettera dell'alfabeto utilizzando il metodo Char.IsLetter(). Se la lettera è effettivamente una lettera dell'alfabeto, viene incrementato il valore corrispondente nell'array "Alphabet". Se il valore nell'array "Alphabet" per quella lettera è maggiore di 1, significa che la lettera è stata già incontrata in precedenza nella stringa e quindi la funzione restituisce false, indicando che "word" non è un isogramma.
```c#
        foreach(var Letter in word.ToLower())
        {
            if (Char.IsLetter(Letter))
            {
                Alphabet [Letter - 'a']++;
                if (Alphabet[Letter - 'a'] > 1)
                    return false;
            }
        }
```
-Infine, se il ciclo foreach ha esaminato tutte le lettere senza trovare ripetizioni, la funzione restituisce true, indicando che "word" è un isogramma.
```c#
                Alphabet [Letter - 'a']++;
                if (Alphabet[Letter - 'a'] > 1)
                    return false;
            }
        }
        return true;
    }

}
```
-codice completo
```c#
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
```
