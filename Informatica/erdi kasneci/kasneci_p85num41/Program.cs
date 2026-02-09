namespace Kasneci___kasneci_p85num41;

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
        int r = LeggiNumero("Inserire la dimensione della matrice quadrata: ");
        int[,] matrice = new int[r, r];
        CaricaMatrice(matrice, 1, 5);
        StampaMatrice(matrice);
        bool isMatrixSpiral = IsMatrixSpiral(matrice);
        if (isMatrixSpiral)
        {
            Console.WriteLine($"La matrice è spirale");
        }
        else
        {
            Console.WriteLine($"La matrice NON è spirale");
        }
    }

    private static bool IsMatrixSpiral(int[,] matrice)
    {
        int r = matrice.GetLength(0);
        int valoreAtteso = 1;
        
        int rigaInizio = 0, rigaFine = r - 1;
        int colInizio = 0, colFine = r - 1;

        while (rigaInizio <= rigaFine && colInizio <= colFine)
        {
            for (int j = colInizio; j <= colFine; j++)
            {
                if (matrice[rigaInizio, j] != valoreAtteso++) return false;
            }

            rigaInizio++;
            
            for (int i = rigaInizio; i <= rigaFine; i++)
            {
                if (matrice[i, colFine] != valoreAtteso++) return false;
            }
            colFine--;
            
            if (rigaInizio <= rigaFine)
            {
                for (int j = colFine; j >= colInizio; j--)
                {
                    if (matrice[rigaFine, j] != valoreAtteso++) return false;
                }
                rigaFine--;
            }
            
            if (colInizio <= colFine)
            {
                for (int i = rigaFine; i >= rigaInizio; i--)
                {
                    if (matrice[i, colInizio] != valoreAtteso++) return false;
                }
                colInizio++;
            }
        }

        return true;
    }
}