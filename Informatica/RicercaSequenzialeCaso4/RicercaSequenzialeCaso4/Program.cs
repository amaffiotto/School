using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RicercaSequenzialeCaso4
{
    internal class Program
    {
        private static int RicercaSequenzialeCaso4(string[] vettore, int[] posizioni, string nome)
        {
            int i = 0;
            int count = 0;

            while (i < vettore.Length && nome.CompareTo(vettore[i]) > 0)
            {
                i++;
            }

            while (i < vettore.Length && vettore[i] == nome)
            {
                posizioni[count] = i;
                count++;
                i++;
            }

            return count;
        }
        private static int RicercaSequenzialeCaso4Libro(string[] vettore, int[] posizioni, string nome) {
            bool superato = false;
            int i = 0, j = 0;
            while(i < vettore.Length && !superato)
            {
                if (vettore[i] == nome)
                {
                    posizioni[j] = i;
                    j++;
                }
                else
                {
                    if (nome.CompareTo(vettore[i]) < 0)
                    {
                        superato = true;
                    }
                }
                i++;
            }
            return j;
        }


        static void Main(string[] args)
        {

            string[] v = new string[]
                { "Chiera", "Gallo", "Gallo", "Gallo", "Melandri", "Rossi", "Rossi" };


            int[] vPos = new int[v.Length];

            Console.Write("Inserisci il nome da cercare: ");
            string nome = Console.ReadLine();

            int nElementi = RicercaSequenzialeCaso4Libro(v, vPos, nome);

            if (nElementi == 0)
            {
                Console.WriteLine($"Nome: {nome} NON presente!");
            }
            else
            {
                Console.WriteLine($"Il nome: {nome} compare {nElementi} volte ed è nelle seguenti posizioni: ");
                for (int i = 0; i < nElementi; i++)
                {
                    Console.Write(vPos[i] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}