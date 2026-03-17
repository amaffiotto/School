using System;

namespace Maffiotto___es5p115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cognomi = {
                "Vlahovic", "Bremer", "Locatelli",
                "Leao", "Hernandez", "Pulisic",
                "Martinez", "Barella", "Thuram",
                "Osimhen", "Kvaratskhelia", "Di Lorenzo",
                "Dybala", "Pellegrini", "Mancini"
            };

            string[] nomi = {
                "Dusan", "Gleison", "Manuel",
                "Rafael", "Theo", "Christian",
                "Lautaro", "Nicolo", "Marcus",
                "Victor", "Khvicha", "Giovanni",
                "Paulo", "Lorenzo", "Gianluca"
            };

            string[] squadre = {
                "Juventus", "Juventus", "Juventus",
                "Milan", "Milan", "Milan",
                "Inter", "Inter", "Inter",
                "Napoli", "Napoli", "Napoli",
                "Roma", "Roma", "Roma"
            };

            string[] cognomiOrdinati = new string[cognomi.Length];
            string[] nomiOrdinati = new string[nomi.Length];

            Console.WriteLine("Inserisci la squadra (es. Juventus, Milan, Inter, Napoli, Roma): ");
            string squadra = Console.ReadLine();

            int numeroTrovati = CopiaVettoreParallelo(squadre, squadra, cognomi, nomi, cognomiOrdinati, nomiOrdinati);

            if (numeroTrovati > 0)
            {
                BubbleSort(cognomiOrdinati, nomiOrdinati, numeroTrovati);

                for (int i = 0; i < numeroTrovati; i++)
                {
                    Console.WriteLine(cognomiOrdinati[i] + " " + nomiOrdinati[i]);
                }
            }
            else
            {
                Console.WriteLine("Nessun giocatore trovato.");
            }
            
            Console.ReadKey();
        }

        private static int CopiaVettoreParallelo(string[] squadre, string target, string[] srcCognomi, string[] srcNomi, string[] destCognomi, string[] destNomi)
        {
            int k = 0;
            for (int i = 0; i < squadre.Length; i++)
            {
                if (squadre[i].ToLower().Trim() == target.ToLower().Trim())
                {
                    destCognomi[k] = srcCognomi[i];
                    destNomi[k] = srcNomi[i];
                    k++;
                }
            }
            return k;
        }

        private static void BubbleSort(string[] cognomi, string[] nomi, int lunghezza)
        {
            for (int i = 0; i < lunghezza - 1; i++)
            {
                for (int j = 0; j < lunghezza - 1 - i; j++)
                {
                    if (string.Compare(cognomi[j], cognomi[j + 1]) > 0)
                    {
                        string tempC = cognomi[j];
                        cognomi[j] = cognomi[j + 1];
                        cognomi[j + 1] = tempC;

                        string tempN = nomi[j];
                        nomi[j] = nomi[j + 1];
                        nomi[j + 1] = tempN;
                    }
                }
            }
        }
    }
}