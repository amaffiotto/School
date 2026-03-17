using System;

namespace Maffiotto___es21p84
{
    internal class Program
    {
        static Random rnd = new Random();

        static int LeggiNumero(string messaggio, bool soloPositivi = true)
        {
            int numero;
            bool isCorrect;

            do
            {
                Console.WriteLine(messaggio);
                if (int.TryParse(Console.ReadLine(), out numero))
                    isCorrect = true;
                else
                {
                    isCorrect = false;
                    Console.WriteLine("Devi inserire un numero intero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (isCorrect && soloPositivi && numero <= 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Il numero deve essere maggiore di 0");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (!isCorrect);

            return numero;
        }

        private static void CaricaVettore(int[] vettore, int min, int max, char tipologia = 'n')
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                switch (tipologia)
                {
                    case 'n':
                        vettore[i] = rnd.Next(min, max);
                        break;

                    case 'p':
                        vettore[i] = rnd.Next(99) + 1;
                        break;
                }
            }
        }

        private static void StampaVettore(int[] vettoreSorgente)
        {
            for (int i = 0; i < vettoreSorgente.Length; i++)
            {
                Console.WriteLine($"Elemento {i}: {vettoreSorgente[i]}");
            }
        }

        // Metodo richiesto dall'esercizio 21
        static void SpostaVettoreCircolare(int[] A)
        {
            if (A.Length <= 1) return;

            // Salviamo l'ultimo elemento
            int ultimo = A[A.Length - 1];

            // Spostiamo tutti gli elementi in avanti (partendo dal fondo)
            for (int i = A.Length - 1; i > 0; i--)
            {
                A[i] = A[i - 1];
            }

            // Inseriamo l'ultimo elemento nella prima posizione
            A[0] = ultimo;
        }

        static void Main(string[] args)
        {
            int n = LeggiNumero("Inserire la dimensione del vettore da creare");
            int[] vetA = new int[n];

            CaricaVettore(vetA, 1, 100);

            Console.WriteLine("\n--- Vettore Originale ---");
            StampaVettore(vetA);

            SpostaVettoreCircolare(vetA);

            Console.WriteLine("\n--- Vettore dopo lo spostamento circolare ---");
            StampaVettore(vetA);

            Console.ReadKey();
        }
    }
}