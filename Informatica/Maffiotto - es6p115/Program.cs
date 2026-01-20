using System;

namespace Maffiotto___es6p115
{
    internal class Program
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
                "Roma", "Roma", "Napoli"
            };

            VisualizzaStatisticheSquadre(squadre);

            Console.ReadKey();
        }

        static void VisualizzaStatisticheSquadre(string[] squadre)
        {
            string[] nomiSquadreUniche = new string[squadre.Length];
            int[] numeroGiocatori = new int[squadre.Length];
            int contaSquadre = 0;
            
            for (int i = 0; i < squadre.Length; i++)
            {
                string squadraCorrente = squadre[i];
                int indiceTrovato = -1;

                for (int j = 0; j < contaSquadre; j++)
                {
                    if (nomiSquadreUniche[j] == squadraCorrente)
                    {
                        indiceTrovato = j;
                        break;
                    }
                }

                if (indiceTrovato != -1)
                {
                    numeroGiocatori[indiceTrovato]++;
                }
                else
                {
                    nomiSquadreUniche[contaSquadre] = squadraCorrente;
                    numeroGiocatori[contaSquadre] = 1;
                    contaSquadre++;
                }
            }
            
            for (int i = 0; i < contaSquadre - 1; i++)
            {
                for (int j = 0; j < contaSquadre - 1 - i; j++)
                {
                    if (numeroGiocatori[j] < numeroGiocatori[j + 1])
                    {
                        int tempNum = numeroGiocatori[j];
                        numeroGiocatori[j] = numeroGiocatori[j + 1];
                        numeroGiocatori[j + 1] = tempNum;

                        string tempNome = nomiSquadreUniche[j];
                        nomiSquadreUniche[j] = nomiSquadreUniche[j + 1];
                        nomiSquadreUniche[j + 1] = tempNome;
                    }
                }
            }

            Console.WriteLine("--- Numero giocatori per squadra (Ordine Decrescente) ---");
            for (int i = 0; i < contaSquadre; i++)
            {
                Console.WriteLine($"Squadra: {nomiSquadreUniche[i]} \t- Giocatori: {numeroGiocatori[i]}");
            }
        }
    }
}