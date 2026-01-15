using System;

namespace RicercaBinaria
{
    internal class Program
    {
        private static int RicercaDicotomica(string[] v, string nomeDaCercare)
        {
            int posizione = -1, min = 0, max = v.Length - 1, meta;

            while (min <= max)
            {
                meta = (max + min) / 2;
                if (v[meta] == nomeDaCercare)
                {
                    return meta;
                }
                else
                {
                    if (nomeDaCercare.CompareTo(v[meta]) > 0)
                    {
                        min = meta + 1;
                    }
                    else // in questo caso nome da cercare sarà sicuramente più piccolo se fosse stato uguale a vettore[i] sarei già uscito al return sopra
                    {
                        max = meta - 1;
                    }
                }
            }

            return posizione;
        }

        static void Main(string[] args)
        {
            string[] v = { "Agosti", "Barbieri", "Bianchi", "Colombo", "Conti", "De Luca", "Esposito", "Ferri", "Fontana", "Galli", "Gentile", "Greco", "Lombardi", "Marini", "Martini", "Moretti", "Ricci", "Rossi", "Russo", "Villa" };
            Console.WriteLine("Inserisci il nome da cercare: ");
            string nomeDaCercare = Console.ReadLine();
            int pos = Array.BinarySearch(v, nomeDaCercare);

            //RicercaDicotomica(v, nomeDaCercare);
            if (pos <= -1)
                Console.WriteLine($"Il nome: {nomeDaCercare} NON è presente nell'insieme");
            else
                Console.WriteLine($"Il nome: {nomeDaCercare} è stato trovato all'indice {pos}");

        }

    }
}
