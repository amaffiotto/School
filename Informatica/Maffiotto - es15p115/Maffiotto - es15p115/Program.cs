namespace Maffiotto___es15p115;

public class Program
{
    /// <summary>
    /// Trova gli indici dei primi tre classificati in base al punteggio,
    /// supponendo che non ci siano pari merito.
    /// </summary>
    /// <param name="punteggi">Vettore dei punteggi.</param>
    /// <returns>Vettore di lunghezza tre con gli indici dei vincitori in ordine di classifica.</returns>
    private static int[] TrovaPrimiTre(int[] punteggi)
    {
        int primo = -1, secondo = -1, terzo = -1;

        for (int i = 0; i < punteggi.Length; i++)
        {
            if (primo == -1 || punteggi[i] > punteggi[primo])
            {
                terzo = secondo;
                secondo = primo;
                primo = i;
            }
            else if (secondo == -1 || punteggi[i] > punteggi[secondo])
            {
                terzo = secondo;
                secondo = i;
            }
            else if (terzo == -1 || punteggi[i] > punteggi[terzo])
            {
                terzo = i;
            }
        }

        return new[] { primo, secondo, terzo };
    }

    public static void Main(string[] args)
    {
        string[] nominativi =
        {
            "Andrea",
            "Luca",
            "Sara",
            "Giulia",
            "Marco",
            "Elena",
            "Francesco",
            "Chiara",
            "Davide",
            "Alessia"
        };

        int[] punteggi =
        {
            18,
            25,
            30,
            22,
            27,
            19,
            24,
            29,
            20,
            23
        };

        int[] vincitori = TrovaPrimiTre(punteggi);

        Console.WriteLine("Primi tre classificati:");
        Console.WriteLine($"1) {nominativi[vincitori[0]]} con {punteggi[vincitori[0]]} punti");
        Console.WriteLine($"2) {nominativi[vincitori[1]]} con {punteggi[vincitori[1]]} punti");
        Console.WriteLine($"3) {nominativi[vincitori[2]]} con {punteggi[vincitori[2]]} punti");

        Console.ReadKey();
    }
}
