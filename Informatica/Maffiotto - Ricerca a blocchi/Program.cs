namespace Maffiotto___Ricerca_a_blocchi;

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] V = { "Barberis", "Barbero", "Bruno", "Calleri", "Costantino", "Dadone", "Ferrero", "Giaccone", "Giachello", "Musso", "Napoli", "Operti", "Pansa", "Pensa", "Rossi", "Rosso", "Viglietti" };
        //RIGA TEST
        string daCercare = "Bruno";
        //RIGA TEST
        
        int posizione = RicercaBlocchi(V, daCercare);

        if (posizione != -1)
        {
            Console.WriteLine("Elemento trovato in posizione: " + posizione);
        }
        else
        {
            Console.WriteLine("Elemento non trovato!");
        }
        
        Console.ReadLine();
    }

    static int RicercaBlocchi(string[] V, string X)
    {
        int N = V.Length;
        int LB = (int)Math.Sqrt(N);
        int j = LB - 1;
        
        while (j < N && string.Compare(V[j], X) < 0)
        {
            j = j + LB;
        }

        int fine = (j < N) ? j : N - 1;
        int inizio = j - LB + 1;
        
        if (inizio < 0) inizio = 0;

        for (int k = inizio; k <= fine; k++)
        {
            if (V[k] == X)
            {
                return k;
            }
            
            if (string.Compare(V[k], X) > 0)
            {
                return -1;
            }
        }

        return -1;
    }
}