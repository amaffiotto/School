namespace Maffiotto___es11p115;

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
            string? input = Console.ReadLine();

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
        "Forrest Gump",
        "Pulp Fiction",
        "Titanic",
        "La vita è bella",
        "Matrix",
        "Il Gladiatore",
        "Il Signore degli Anelli: La Compagnia dell'Anello",
        "Il Cavaliere Oscuro",
        "Inception",
        "Interstellar"
    };

    static int[] anniPubblicazione = new int[]
    {
        1994,
        1994,
        1997,
        1997,
        1999,
        2000,
        2001,
        2008,
        2010,
        2014
    };

    static string[] registi = new string[]
    {
        "Robert Zemeckis",
        "Quentin Tarantino",
        "James Cameron",
        "Roberto Benigni",
        "Lana e Lilly Wachowski",
        "Ridley Scott",
        "Peter Jackson",
        "Christopher Nolan",
        "Christopher Nolan",
        "Christopher Nolan"
    };

    static void Main(string[] args)
    {
        Console.Write("Inserire il nome del regista di cui cercare il film: ");
        string regista = Console.ReadLine()!;
        int daAnno = LeggiNumero("Inserire l'inizio dell'intervallo: ", true, 1900);
        int adAnno = LeggiNumero("Inserire la fine dell'intervallo: ", true, 1900);
        
        Console.WriteLine();
        TrovaTitoloPerRegistaEdAnni(regista, daAnno, adAnno);
    }

    /// <summary>
    /// Trova i film di un determinato regista in un intervallo di anni.
    /// </summary>
    /// <param name="regista">Nome del regista da cercare</param>
    /// <param name="daAnno">Anno iniziale dell'intervallo</param>
    /// <param name="adAnno">Anno finale dell'intervallo</param>
    private static void TrovaTitoloPerRegistaEdAnni(string regista, int daAnno, int adAnno)
    {
        bool trovato = false;
        
        for (int i = 0; i < anniPubblicazione.Length; i++)
        {
            if (anniPubblicazione[i] < daAnno)
            {
                continue;
            }
            
            if (anniPubblicazione[i] > adAnno)
            {
                break;
            }
            
            if (registi[i].Equals(regista, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Film trovato: {titoli[i]} ({anniPubblicazione[i]})");
                trovato = true;
            }
        }
        
        if (!trovato)
        {
            Console.WriteLine($"Nessun film del regista '{regista}' trovato nell'intervallo {daAnno}-{adAnno}.");
        }
    }
}
