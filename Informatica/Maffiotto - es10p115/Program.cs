namespace Maffiotto___es10p115;

public class Program
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
                if (soloPositivi && numero <= 0)
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

    static string[] titoli = new string[]
    {
        "Il Signore degli Anelli: La Compagnia dell'Anello",
        "Inception",
        "Il Gladiatore",
        "Forrest Gump",
        "Matrix",
        "Titanic",
        "Interstellar",
        "Pulp Fiction",
        "La vita è bella",
        "Il Cavaliere Oscuro"
    };

    static int[] anniPubblicazione = new int[]
    {
        2001,
        2010,
        2000,
        1994,
        1999,
        1997,
        2014,
        1994,
        1997,
        2008
    };

    static string[] registi = new string[]
    {
        "Peter Jackson",
        "Christopher Nolan",
        "Ridley Scott",
        "Robert Zemeckis",
        "Lana e Lilly Wachowski",
        "James Cameron",
        "Christopher Nolan",
        "Quentin Tarantino",
        "Roberto Benigni",
        "Christopher Nolan"
    };
    static void Main(string[] args)
    {
        Console.Write("Inserire il nome del regista di cui cercare il film: ");
        string regista = Console.ReadLine()!;
        int daAnno = LeggiNumero("Inserire l'inizio dell'intervallo: ", true, 1900);
        int adAnno = LeggiNumero("Inserire la fine dell'intervallo: ", true, 1900);
        TrovaTitoloPerRegistaEdAnni(regista, daAnno, adAnno);
    }

    private static void TrovaTitoloPerRegistaEdAnni(string regista, int daAnno, int adAnno)
    {
        int[] filmPerAnni = new int[anniPubblicazione.Length];
        int j = 0;
        for (int i = 0; i < registi.Length; i++)
        {
            if (anniPubblicazione[i] >= daAnno &&  anniPubblicazione[i] <= adAnno)
            {
                filmPerAnni[j] = i;
                j++;
            }
        }

        Array.Resize(ref filmPerAnni, j+1);

        for (int i = 0; i < filmPerAnni.Length; i++)
        {
            if (registi[filmPerAnni[i]] == regista)
            {
                Console.Write($"Film trovato: {titoli[filmPerAnni[i]]}, ");
            }
        }
    }
}