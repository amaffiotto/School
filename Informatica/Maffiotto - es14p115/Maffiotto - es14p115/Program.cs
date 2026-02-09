namespace Maffiotto___es14p115;

public class Program
{
    /// <summary>
    /// Conta quanti libri trattano un certo genere e sono pubblicati da una certa casa editrice
    /// sfruttando l'ordinamento crescente per genere e casa editrice.
    /// </summary>
    /// <param name="generi">Vettore parallelo dei generi, ordinato.</param>
    /// <param name="caseEditrici">Vettore parallelo delle case editrici, ordinato.</param>
    /// <param name="genereDaCercare">Genere da cercare.</param>
    /// <param name="casaEditriceDaCercare">Casa editrice da cercare.</param>
    /// <returns>Numero di libri che rispettano entrambi i criteri.</returns>
    private static int ContaLibriOrdinati(string[] generi, string[] caseEditrici, string genereDaCercare, string casaEditriceDaCercare)
    {
        int i = 0;
        int count = 0;

        while (i < generi.Length &&
               (string.Compare(generi[i], genereDaCercare, StringComparison.Ordinal) < 0 ||
               (generi[i] == genereDaCercare &&
                string.Compare(caseEditrici[i], casaEditriceDaCercare, StringComparison.Ordinal) < 0)))
        {
            i++;
        }

        while (i < generi.Length &&
               generi[i] == genereDaCercare &&
               caseEditrici[i] == casaEditriceDaCercare)
        {
            count++;
            i++;
        }

        return count;
    }

    public static void Main(string[] args)
    {
        string[] titoli =
        {
            "Il nome della rosa",
            "Il codice Da Vinci",
            "1984",
            "Fahrenheit 451",
            "Il signore degli anelli",
            "Harry Potter e la pietra filosofale",
            "Il piccolo principe",
            "La coscienza di Zeno",
            "Orgoglio e pregiudizio",
            "I promessi sposi"
        };

        string[] generi =
        {
            "Fantascienza",
            "Fantascienza",
            "Fantasy",
            "Fantasy",
            "Giallo storico",
            "Narrativa",
            "Narrativa",
            "Romanzo",
            "Romanzo storico",
            "Thriller"
        };

        string[] caseEditrici =
        {
            "Mondadori",
            "Mondadori",
            "Salani",
            "Mondadori",
            "Bompiani",
            "Bompiani",
            "Newton Compton",
            "Feltrinelli",
            "Garzanti",
            "Bompiani"
        };

        Console.Write("Inserisci il genere: ");
        string genereIn = Console.ReadLine()!;

        Console.Write("Inserisci la casa editrice: ");
        string casaEditriceIn = Console.ReadLine()!;

        int nLibri = ContaLibriOrdinati(generi, caseEditrici, genereIn, casaEditriceIn);

        Console.WriteLine($"\nLibri trovati: {nLibri}");

        Console.ReadKey();
    }
}
