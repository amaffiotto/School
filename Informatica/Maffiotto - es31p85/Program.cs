namespace Maffiotto___es31p85;

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

    static Random rnd = new Random();
    private static void CaricaMatrice(int[,] matrice, int min, int max, char tipologia = 'n')
    {
        for (int i = 0; i < matrice.GetLength(0); i++)
        {
            for (int j = 0; j < matrice.GetLength(1); j++)
            {
                switch (tipologia)
                {
                    case 'n':
                        matrice[i, j] = rnd.Next(min, max);
                        break;
                    case 'p':
                        matrice[i, j] = rnd.Next(99) + 1;
                        break;
                }
            }
        }
    }

    private static void StampaMatrice(int[,] matrice)
    {
        for (int i = 0; i < matrice.GetLength(0); i++)
        {
            for (int j = 0; j < matrice.GetLength(1); j++)
            {
                Console.Write(matrice[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int SommaCorniceMatrice(int[,] matrice)
    {
        int somma = 0;
        for (int i = 0; i < matrice.GetLength(0); i++)
        {
            for (int j = 0; j < matrice.GetLength(1); j++)
            {
                if (i == 0)
                {
                    somma += matrice[i, j];
                }
                else if (i == matrice.GetLength(0) - 1)
                {
                    somma += matrice[i, j];
                }
                else if (j == 0 || j == matrice.GetLength(1) - 1)
                {
                    somma += matrice[i, j];
                }
            }
        }
        
        return somma;
    }
    static void Main(string[] args)
    {
        int nRow = LeggiNumero("Inserire il numero di righe della matrice da creare");
        int nCol = LeggiNumero("Inserire il numero di colonne della matrice da creare");
        int[,] matrice = new int[nRow, nCol];
        CaricaMatrice(matrice, 1, 10);
        StampaMatrice(matrice);
        Console.WriteLine($"La somma della cornice della matrice è {SommaCorniceMatrice(matrice)}");
        
    }
}