namespace Maffiotto___es20p84;

internal class Program
{
    /// <summary>
    /// Legge da console un numero intero, opzionalmente solo positivo.
    /// Continua a richiedere l'input finché non viene inserito un numero valido.
    /// </summary>
    /// <param name="messaggio">Messaggio da mostrare all'utente.</param>
    /// <param name="soloPositivi">Se true, accetta solo numeri maggiori di zero.</param>
    /// <returns>Il numero intero inserito dall'utente.</returns>
    static int LeggiNumero(string messaggio, bool soloPositivi = true)
    {
        int numero;
        bool isCorrect;

        do
        {
            Console.WriteLine(messaggio);
            if (int.TryParse(Console.ReadLine(), out numero))
                isCorrect = true;
            else
            {
                isCorrect = false;
                Console.WriteLine("Devi inserire un numero intero valido!");
                Console.ReadKey();
                Console.Clear();
            }

            if (isCorrect && soloPositivi && numero <= 0)
            {
                isCorrect = false;
                Console.WriteLine("Il numero deve essere maggiore di 0");
                Console.ReadLine();
                Console.Clear();
            }

        } while (!isCorrect);

        return numero;
    }

    static Random rnd = new Random(); //incollare anche questo

    /// <summary>
    /// Riempe un vettore di interi con valori casuali in base a una tipologia specificata.
    /// 'n' (default): I valori sono generati in un range compreso tra 'min' (incluso) e 'max' (escluso).
    /// 'p': I valori sono generati in un range fisso tra 1 e 99 (incluso). Ignora i parametri 'min' e 'max'.
    /// </summary>
    /// <param name="vettore">Array di interi da caricare.</param>
    /// <param name="min">Valore minimo (incluso) da generare, usato solo se tipologia è 'n'.</param>
    /// <param name="max">Valore massimo (escluso) da generare, usato solo se tipologia è 'n'.</param>
    /// <param name="tipologia">Carattere che definisce la modalità di caricamento ('n' o 'p').</param>
    private static void CaricaVettore(int[] vettore, int min, int max, char tipologia = 'n')
    {
        for (int i = 0; i < vettore.Length; i++)
        {
            switch (tipologia)
            {
                case 'n':
                    vettore[i] = rnd.Next(min, max);
                    break;

                case 'p':
                    vettore[i] = rnd.Next(99) + 1;
                    break;
            }
        }


    }
    
    
    /// <summary>
    /// Stampa a video tutti gli elementi di un vettore con il loro indice.
    /// </summary>
    /// <param name="vettoreSorgente">Array di interi da stampare.</param>
    private static void StampaVettore(int[] vettoreSorgente)
    {
        for (int i = 0; i < vettoreSorgente.Length; i++)
        {
            Console.WriteLine($"Elemento {i + 1}: {vettoreSorgente[i]}");
        }
    }


    static bool AreAllDefferent(int[] vet)
    {
        bool areAllDiff = true;
        for (int i = 0; i < vet.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (vet[i] == vet[j])
                {
                    areAllDiff = false;
                }
            }
        }
        return areAllDiff;
    }

static void Main(string[] args)
    {
        int n = LeggiNumero("Inserire la dimesnsione del vettore da creare");
        int[] vetA = new int[n];
        CaricaVettore(vetA,1, 100);
        StampaVettore(vetA);
        if (AreAllDefferent(vetA))
        {
            Console.WriteLine("Gli elementi del vettore sono tutti diversi");
        }
        else
        {
            Console.WriteLine("Nel vettore sono presenti elementi uguali");
        }
        
    }
}