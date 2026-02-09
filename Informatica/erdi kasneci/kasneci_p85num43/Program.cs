namespace Kasneci___kasneci_p85num43;

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
        Console.WriteLine("Matrice Caricata a cornici concentrice");
        LoadMatrixWithConcentricFrames(matrice);
        StampaMatrice(matrice);
        
    }

    private static void LoadMatrixWithConcentricFrames(int[,] matrice)
    {
        int r = matrice.GetLength(0);
        for (int cornice = 0; cornice < (r + 1) / 2; cornice++)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    if (i == cornice || i == r - 1 - cornice || j == cornice || j == r - 1 - cornice)
                    {
                        if (matrice[i, j] == 0)
                        {
                            matrice[i, j] = cornice + 1;
                        }
                    }
                }
            }
        }
    }
}