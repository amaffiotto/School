using System;

namespace Maffiotto___es12p115
{
    internal class Program
    {
        /// <summary>
        /// Conta quanti libri trattano un certo genere e sono pubblicati da una certa casa editrice.
        /// </summary>
        /// <param name="generi">Vettore parallelo dei generi.</param>
        /// <param name="caseEditrici">Vettore parallelo delle case editrici.</param>
        /// <param name="genereDaCercare">Genere da cercare.</param>
        /// <param name="casaEditriceDaCercare">Casa editrice da cercare.</param>
        /// <returns>Numero di libri che rispettano entrambi i criteri.</returns>
        private static int ContaLibri(string[] generi, string[] caseEditrici, string genereDaCercare, string casaEditriceDaCercare)
        {
            int count = 0;

            for (int i = 0; i < generi.Length; i++)
            {
                if (generi[i] == genereDaCercare && caseEditrici[i] == casaEditriceDaCercare)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            string[] titoli =
            {
                "Il nome della rosa",
                "1984",
                "Il signore degli anelli",
                "Harry Potter e la pietra filosofale",
                "Il piccolo principe",
                "La coscienza di Zeno",
                "Il codice Da Vinci",
                "Orgoglio e pregiudizio",
                "I promessi sposi",
                "Fahrenheit 451"
            };

            string[] generi =
            {
                "Giallo storico",
                "Fantascienza",
                "Fantasy",
                "Fantasy",
                "Narrativa",
                "Narrativa",
                "Thriller",
                "Romanzo",
                "Romanzo storico",
                "Fantascienza"
            };

            string[] caseEditrici =
            {
                "Bompiani",
                "Mondadori",
                "Bompiani",
                "Salani",
                "Bompiani",
                "Newton Compton",
                "Mondadori",
                "Feltrinelli",
                "Garzanti",
                "Mondadori"
            };

            Console.Write("Inserisci il genere: ");
            string genereIn = Console.ReadLine() ?? "";

            Console.Write("Inserisci la casa editrice: ");
            string casaEditriceIn = Console.ReadLine() ?? "";

            int nLibri = ContaLibri(generi, caseEditrici, genereIn, casaEditriceIn);

            Console.WriteLine($"\nLibri trovati: {nLibri}");

            Console.ReadKey();
        }
    }
}
