using System;

namespace Maffiotto___es44p85
{
    internal class Program
    {
        static int LeggiNumero(string messaggio, bool soloPositivi = true, int valMin = 0)
        {
            int numero;
            bool isCorrect = false;

            do
            {
                Console.WriteLine(messaggio);
                string input = Console.ReadLine();

                if (int.TryParse(input, out numero))
                {
                    if (soloPositivi && numero < 0)
                    {
                        Console.WriteLine("Il numero deve essere maggiore di 0.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (numero < valMin)
                    {
                        Console.WriteLine($"Il numero deve essere maggiore o uguale a {valMin}.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        isCorrect = true;
                    }
                }
                else
                {
                    Console.WriteLine("Devi inserire un numero intero valido!");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!isCorrect);

            return numero;
        }

        private static void CaricaMatriceManuale(int[,] matrice)
        {
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Clear();

                    for (int r = 0; r < matrice.GetLength(0); r++)
                    {
                        for (int c = 0; c < matrice.GetLength(1); c++)
                        {
                            if (r == i && c == j)
                            {
                                Console.Write(" ? \t");
                            }
                            else if (r < i || (r == i && c < j))
                            {
                                Console.Write($" {matrice[r, c]} \t");
                            }
                            else
                            {
                                Console.Write(" . \t");
                            }
                        }
                        Console.WriteLine("\n");
                    }

                    matrice[i, j] = LeggiNumero($"Inserisci valore per [{i},{j}]: ", false, int.MinValue);
                }
            }
        }

        private static void StampaMatrice(int[,] matrice)
        {
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write(matrice[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static bool VerificaOrdinamento(int[,] matrice)
        {
            if (matrice.Length == 0) return true;

            int precedente = matrice[0, 0];

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    if (i == 0 && j == 0) continue;

                    if (matrice[i, j] < precedente)
                    {
                        return false;
                    }
                    precedente = matrice[i, j];
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int r = LeggiNumero("Inserire numero di righe: ");
            int c = LeggiNumero("Inserire numero di colonne: ");
            int[,] matrice = new int[r, c];
            
            CaricaMatriceManuale(matrice);
            Console.Clear();
            StampaMatrice(matrice);

            bool isSorted = VerificaOrdinamento(matrice);
            
            if (isSorted)
            {
                Console.WriteLine("La matrice è ordinata in ordine crescente.");
            }
            else
            {
                Console.WriteLine("La matrice NON è ordinata in ordine crescente.");
            }
            Console.ReadKey();
        }
    }
}