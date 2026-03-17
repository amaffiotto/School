namespace Maffiotto___es8p115;

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
    private static void MergeTappo(string[] a, string[] b, string[] c)
    {
        int i = 0, j = 0;
        int n = a.Length;
        int m = b.Length;
        Array.Resize(ref a, n+1);
        Array.Resize(ref b, m+1);
        a[n] = "zzzZZZ";
        b[m] = "zzzZZZ";
        for (int k = 0; k < n+m; k++)
        {
            if (a[i].CompareTo(b[j]) > 0)
            {
                c[k] = b[j++];
            }
            else
            {
                c[k] = a[i++];
            }
        }
    }
    static void Main(string[] args)
    {
        string[] nomiCompleto = new string[nomi.Length+nomi2.Length];
        string[] cognomiCompleto = new string[cognomi.Length+cognomi2.Length];
        
        MergeTappo(nomi, nomi2, nomiCompleto);
        MergeTappo(cognomi, cognomi2, cognomiCompleto);
        
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