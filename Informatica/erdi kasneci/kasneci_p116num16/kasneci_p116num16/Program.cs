namespace Kasneci___kasneci_p116num16;

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

    /// <summary>
    /// Aggiorna la classifica dei primi tre giocatori inserendo un nuovo risultato,
    /// mantenendo il vettore dei punteggi ordinato in modo decrescente.
    /// </summary>
    /// <param name="nominativiTop">Vettore dei nominativi in top tre.</param>
    /// <param name="punteggiTop">Vettore dei punteggi in top tre, ordinato in modo decrescente.</param>
    /// <param name="nuovoNome">Nome del nuovo giocatore.</param>
    /// <param name="nuovoPunteggio">Punteggio del nuovo giocatore.</param>
    public static void AggiornaTopTre(string[] nominativiTop, int[] punteggiTop, string nuovoNome, int nuovoPunteggio)
    {
        int posizione = -1;

        for (int i = 0; i < punteggiTop.Length; i++)
        {
            if (nuovoPunteggio > punteggiTop[i])
            {
                posizione = i;
                break;
            }
        }

        if (posizione == -1)
        {
            return;
        }

        for (int i = punteggiTop.Length - 1; i > posizione; i--)
        {
            punteggiTop[i] = punteggiTop[i - 1];
            nominativiTop[i] = nominativiTop[i - 1];
        }

        punteggiTop[posizione] = nuovoPunteggio;
        nominativiTop[posizione] = nuovoNome;
    }

    public static void Main(string[] args)
    {
        string[] nominativiTop =
        {
            "Sara",
            "Andrea",
            "Marco"
        };

        int[] punteggiTop =
        {
            30,
            27,
            25
        };

        Console.WriteLine("Classifica iniziale:");
        for (int i = 0; i < nominativiTop.Length; i++)
        {
            Console.WriteLine($"{i + 1}) {nominativiTop[i]} con {punteggiTop[i]} punti");
        }

        Console.Write("\nInserisci il nome del nuovo giocatore: ");
        string nuovoNome = Console.ReadLine()!;

        int nuovoPunteggio = LeggiNumero("Inserisci il punteggio del nuovo giocatore: ", true, 0);

        AggiornaTopTre(nominativiTop, punteggiTop, nuovoNome, nuovoPunteggio);

        Console.WriteLine("\nClassifica aggiornata:");
        for (int i = 0; i < nominativiTop.Length; i++)
        {
            Console.WriteLine($"{i + 1}) {nominativiTop[i]} con {punteggiTop[i]} punti");
        }

        Console.ReadKey();
    }
}
