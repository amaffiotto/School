using System.IO;

namespace Maffiotto___Problema_9;


class Program
{
    struct recApp
    {
        public string codiceLibro;
        public string titolo;
        public string autore;
        public string casaEditrice;
        public string prezzo;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Inserire l'autore...");
        string target = Console.ReadLine();
        recApp rec = new recApp();
        int i = 0;
        bool trovato = false;
        recApp[] output = new recApp[1000];
        using (StreamReader reader = new StreamReader("peb.dat"))
        {
            
            while (!reader.EndOfStream)
            {
                string[] elementiStringa = reader.ReadLine().Split('|');
                rec.codiceLibro = elementiStringa[0];
                rec.titolo = elementiStringa[1];
                rec.autore = elementiStringa[2];
                rec.casaEditrice = elementiStringa[3];
                rec.prezzo = (elementiStringa[4]);
                if (rec.autore == target)
                {
                    output[i].codiceLibro = rec.codiceLibro;
                    output[i].titolo = rec.titolo;
                    output[i].autore = rec.autore;
                    output[i].casaEditrice = rec.casaEditrice;
                    output[i].prezzo = rec.prezzo;
                    i++;
                    trovato = true;
                }
            }
        }
        
        Array.Resize(ref output, i);

        if (trovato)
        {
            Console.WriteLine($"Dell autore {target} sono stati trovati i seguenti libri:");
            Console.WriteLine("------------------");
            foreach (recApp app in output)
            {
                Console.WriteLine(app.codiceLibro);
                Console.WriteLine(app.titolo);
                Console.WriteLine(app.casaEditrice);
                Console.WriteLine(app.prezzo);
                Console.WriteLine("------------------");
            }
        }
        else
        {
            Console.WriteLine("Autore NON trovato");
        }

    }
}