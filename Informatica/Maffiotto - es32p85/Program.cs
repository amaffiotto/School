using System.Globalization;

namespace Maffiotto___es32p85;

class Program
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

    static int SommaRigaMatrice(int[,] matrice, int riga)
    {
        int sum = 0;
        if (riga > matrice.GetLength(0)-1 || riga < 0)
        {
            Console.WriteLine("Errore riga non esistente");
            return -1;
        }
        else
        {
            for (int i = 0; i < matrice.GetLength(1); i++)
            {
                sum += matrice[riga, i];
            }
            return sum;
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
    static void Main(string[] args)
    {
        int nCol, nRow, rowToSum;
        nRow = LeggiNumero("Inserire il numero di righe della matrice: ");
        nCol = LeggiNumero("Inserire il numero di colonne della matrice: ");
        int[,] matrice = new int[nRow, nCol];
        CaricaMatrice(matrice, 1, 100);
        StampaMatrice(matrice);
        Console.Write("Inserire l'indice della riga da sommare (partendo da 0): ");
        rowToSum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"La somma della riga con indice {rowToSum} è {SommaRigaMatrice(matrice, rowToSum)}");
    }
}