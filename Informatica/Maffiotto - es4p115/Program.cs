namespace Maffiotto___es4p115;

internal class Program
{
    static void OrdinamentoSelezione(string[] chiave, string[] parallelo)
    {
        for (int i = 0; i < chiave.Length - 1; i++)
        {
            int posMin = i;
            for (int j = i + 1; j < chiave.Length; j++)
            {
                if (chiave[posMin].CompareTo(chiave[j]) > 0)
                {
                    posMin = j;
                }
            }

            if (posMin != i)
            {
                string temp = chiave[i];
                chiave[i] = chiave[posMin];
                chiave[posMin] = temp;

                string temp2 = parallelo[i];
                parallelo[i] = parallelo[posMin];
                parallelo[posMin] = temp2;
            }
        }
    }
    
    static int RicercaBinaria(string[] array, string target)
    {
        int inizio = 0;
        int fine = array.Length - 1;

        while (inizio <= fine)
        {
            int medio = inizio + (fine - inizio) / 2;
            int confronto = array[medio].CompareTo(target);
            
            if (confronto == 0) 
                return medio;
            
            if (confronto < 0) 
                inizio = medio + 1;
            else 
                fine = medio - 1;
        }

        return -1;
    }

    static void Main(string[] args)
    {
        string[] nomi = 
        { 
            "Leonardo", "Sofia", "Francesco", "Aurora", "Alessandro", 
            "Giulia", "Lorenzo", "Ginevra", "Mattia", "Beatrice", 
            "Tommaso", "Vittoria", "Edoardo", "Alice", "Gabriele" 
        };

        string[] cognomi = 
        { 
            "Rossi", "Russo", "Ferrari", "Esposito", "Bianchi", 
            "Romano", "Colombo", "Bruno", "Ricci", "Marino", 
            "Costa", "Greco", "Conti", "Gallo", "Mancini" 
        };
        Console.WriteLine("\n===Vettori prima dell'ordinamento===\n");
        for (int i = 0; i < cognomi.Length; i++)
        {
            Console.WriteLine($"{cognomi[i]} {nomi[i]}");
        }
        
        OrdinamentoSelezione(cognomi, nomi);
        Console.WriteLine("\n===Vettori dopo l'ordinamento\n");

        for (int i = 0; i < nomi.Length; i++)
        {
            Console.WriteLine($"{cognomi[i]} {nomi[i]}");
        }
        Console.WriteLine("\n===Ricerca binaria===\n Inserire il cognome da cercare: ");
        string daCercare = Console.ReadLine()!;
        int pos = RicercaBinaria(cognomi, daCercare);
        Console.WriteLine($"Cognome: {cognomi[pos]} ({nomi[pos]}) trovato in posizione: {pos}");

    }
}