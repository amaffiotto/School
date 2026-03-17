namespace Maffiotto___es50p86;

internal class Program
{
    /// <summary>
    /// Legge da console un numero intero, opzionalmente solo positivo e con un valore minimo specifico.
    /// Continua a richiedere l'input finché non viene inserito un numero valido.
    /// </summary>
    /// <param name="messaggio">Messaggio da mostrare all'utente.</param>
    /// <param name="soloPositivi">Se true, accetta solo numeri maggiori di zero.</param>
    /// <param name="valMin">Il valore minimo accettato (inclusivo).</param>
    /// <returns>Il numero intero inserito dall'utente.</returns>
    static int LeggiNumero(string messaggio, bool soloPositivi = true, int valMin = 0)
    {
        int numero;
        bool isCorrect = false;


        do
        {
            Console.WriteLine(messaggio);
            string input = Console.ReadLine();


            if (int.TryParse(input, out numero))
            {
                if (soloPositivi && numero < 0)
                {
                    Console.WriteLine("Il numero deve essere maggiore di 0.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (numero < valMin)
                {
                    Console.WriteLine($"Il numero deve essere maggiore o uguale a {valMin}.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    isCorrect = true;
                }
            }
            else
            {
                Console.WriteLine("Devi inserire un numero intero valido!");
                Console.ReadKey();
                Console.Clear();
            }


        } while (!isCorrect);


        return numero;
    }

    private static void CaricaMatrice(int[,] matrice, int min, int max, char tipologia = 'n')
    {
        Random rnd = new Random();

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

    private static void CaricaMatriceManuale(int[,] matrice)
    {
        for (int i = 0; i < matrice.GetLength(0); i++)
        {
            for (int j = 0; j < matrice.GetLength(1); j++)
            {
                Console.Clear();

                for (int r = 0; r < matrice.GetLength(0); r++)
                {
                    for (int c = 0; c < matrice.GetLength(1); c++)
                    {
                        if (r == i && c == j)
                        {
                            Console.Write(" ? \t");
                        }
                        else if (r < i || (r == i && c < j))
                        {
                            Console.Write($" {matrice[r, c]} \t");
                        }
                        else
                        {
                            Console.Write(" . \t");
                        }
                    }
                    Console.WriteLine("\n");
                }

                matrice[i, j] = LeggiNumero($"Inserisci valore per [{i},{j}]: ");
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

    static void Main(string[] args)
    {
        int r = LeggiNumero("Inserire il numero di righe della matrice: ");
        int c = LeggiNumero("Inserire il numero di colonne della matrice: ");
        int[,] matrice = new int[r, c];
        //CaricaMatrice(matrice, 1, 5);
        CaricaMatriceManuale(matrice);
        int[] rowSums = SumMatrixRows(matrice);
        Console.WriteLine("Le somme delle righe sono:");
        for (int i = 0; i < rowSums.Length; i++)
        {
            Console.WriteLine($"Riga {i}: {rowSums[i]}");
        }
        
    }

    private static int[] SumMatrixRows(int[,] matrice)
    {
        int[] result = new int[matrice.GetLength(0)];

        for (int i = 0; i < matrice.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < matrice.GetLength(1); j++)
            {
                sum += matrice[i, j];
            }
            result[i] = sum;
        }

        return result;
    }
}