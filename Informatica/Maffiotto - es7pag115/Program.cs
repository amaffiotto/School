namespace Maffiotto___es7pag115;

internal class Program
{
    /// <summary>
    /// Stampa a video tutti gli elementi di un vettore con il loro indice.
    /// </summary>
    /// <param name="vettoreSorgente">Array di interi da stampare.</param>
    private static void StampaVettore(string[] vettoreSorgente)
    {
        for (int i = 0; i < vettoreSorgente.Length; i++)
        {
            Console.WriteLine($"Elemento {i + 1}: {vettoreSorgente[i]}");
        }
    }

    static string[] nomi = new string[]
    {
        "Alessandro",
        "Andrea",
        "Francesco",
        "Giovanni",
        "Luca",
        "Marco",
        "Matteo",
        "Paolo"
    };


    static string[] cognomi = new string[]
    {
        "Bianchi",
        "Conti",
        "Esposito",
        "Ferrari",
        "Gallo",
        "Romano",
        "Rossi",
        "Verdi"
    };

    static string[] nomi2 = new string[]
    {
        "Christian",
        "Daniele",
        "Davide",
        "Emanuele",
        "Federico",
        "Gabriele",
        "Nicola",
        "Riccardo",
        "Simone",
        "Stefano"
    };

    static string[] cognomi2 = new string[]
    {
        "Caruso",
        "DeLuca",
        "Fabbri",
        "Lombardi",
        "Marchetti",
        "Moretti",
        "Pellegrini",
        "Rinaldi",
        "Serra",
        "Sorrentino"
    };
    private static void MergeBase(string[] a, string[] b, string[] c)
    {
        int i = 0, j = 0, k = 0;

        do
        {
            if (a[i].CompareTo(b[j]) > 0)
            {
                c[k] = b[j];
                j++;
            }
            else if (a[i].CompareTo(b[j]) == 0)
            {
                c[k] = a[i];
                j++;
                i++;
            }
            else
            {
                c[k] = a[i];
                i++;
            }

            k++;
        } while (i < a.Length && j < b.Length);

        if (i >= a.Length)
        {
            for (; j < b.Length; j++)
            {
                c[k++] = b[j];
            }
        }
        else
        {
            for (; i < a.Length; i++)
            {
                c[k++] = a[i];
            }
        }
    }
    static void Main(string[] args)
    {
        string[] nomiCompleto = new string[nomi.Length+nomi2.Length];
        string[] cognomiCompleto = new string[cognomi.Length+cognomi2.Length];
        
        MergeBase(nomi, nomi2, nomiCompleto);
        MergeBase(cognomi, cognomi2, cognomiCompleto);
        
        StampaVettore(nomi);
        Console.WriteLine("\n");
        StampaVettore(nomi2);
        Console.WriteLine("\n");
        StampaVettore(nomiCompleto);
        Console.WriteLine("==============================");
        StampaVettore(cognomi);
        Console.WriteLine("\n");
        StampaVettore(cognomi2);
        Console.WriteLine("\n");
        StampaVettore(cognomiCompleto);
        
    }

}