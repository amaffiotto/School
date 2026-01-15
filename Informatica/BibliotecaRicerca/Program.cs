using System;

namespace BibliotecaRicerca;

class Program
{
    static int nControlliSeq = 0;
    static int nControlliBin = 0;

    static int RicercaBinaria(int[] array, int target) 
    {
        int inizio = 0, fine = array.Length - 1;
        
        while (inizio <= fine) {
            nControlliBin++;
            int medio = inizio + (fine - inizio) / 2;

            if (array[medio] == target)
                return medio;
            if (array[medio] < target)
                inizio = medio + 1;
            else 
                fine = medio - 1;
        }
        return -1;
    }

    static int RicercaSequenziale(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            nControlliSeq++;
            if (array[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    static void Main(string[] args)
    {
        Random random = new Random();
        int[] unorderedISBN = new int[20];
        
        for (int i = 0; i < 20; i++)
        {
            unorderedISBN[i] = random.Next(1000, 9999);
        }

        int[] orderedISBN = (int[])unorderedISBN.Clone();
        Array.Sort(orderedISBN);
        
        Console.WriteLine("=== GESTIONE BIBLIOTECA DIGITALE === \n\nLibri disponibili (ISBN): ");
        foreach (int i in orderedISBN)
            Console.Write(i + " ");
            
        Console.WriteLine("\n\nInserisci l'ISBN del libro da cercare: ");
        int codiceIn = int.Parse(Console.ReadLine());

        Console.WriteLine("\n --- RISULTATI RICERCA ---\n");

        int resSeq = RicercaSequenziale(unorderedISBN, codiceIn);
        Console.WriteLine("Ricerca Sequenziale:");
        Console.WriteLine($"✓ Libro trovato alla posizione {resSeq}\n   Confronti effettuati: {nControlliSeq}");

        int resBin = RicercaBinaria(orderedISBN, codiceIn);
        Console.WriteLine("\nRicerca Binaria:");
        Console.WriteLine($"✓ Libro trovato alla posizione {resBin}\n   Confronti effettuati: {nControlliBin}");
        
        Console.WriteLine("\n--- ANALISI EFFICIENZA ---");
        if (nControlliSeq > nControlliBin)
        {
            double percentuale = (1.0 - (double)nControlliBin / nControlliSeq) * 100;
            Console.WriteLine($"La ricerca dicotomica è più efficiente!\nRisparmio: {nControlliSeq - nControlliBin} confronti ({percentuale:F2}%)");
        }
        else if (nControlliBin > nControlliSeq)
        {
            double percentuale = (1.0 - (double)nControlliSeq / nControlliBin) * 100;
            Console.WriteLine($"La ricerca sequenziale è più efficiente!\nRisparmio: {nControlliBin - nControlliSeq} confronti ({percentuale:F2}%)");
        }
        else
        {
            Console.WriteLine("Entrambi i metodi hanno effettuato lo stesso numero di confronti!");
        }
    }
}