using System.IO;

namespace Maffiotto___pag173es1;


class Program
{
    struct recApp
    {
        public string codiceLibro;
        public string titolo;
        public string autore;
        public string casaEditrice;
        public double prezzo;
    }
    static void Main(string[] args)
    {
        recApp[] recs = new recApp[100];
        using (StreamReader reader = new StreamReader("peb.dat"))
        {
            int i = 0;
            while (!reader.EndOfStream)
            {
                string[] elementiStringa = reader.ReadLine().Split('|');
                recs[i].codiceLibro = elementiStringa[0];
                recs[i].titolo = elementiStringa[1];
                recs[i].autore = elementiStringa[2];
                recs[i].casaEditrice = elementiStringa[3];
                recs[i].prezzo = double.Parse(elementiStringa[4]);
                i++;
            }
            Array.Resize(ref recs, i);
        }

        Console.WriteLine("Inserire l'autore...");
        string target = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < recs.Length; i++)
        {
            if (recs[i].autore == target)
            {
                count++;
            }
        }

        Console.WriteLine($"L'autore {target} ha {count} libri in elenco");
    }
}