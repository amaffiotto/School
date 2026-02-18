using System;

namespace Maffiotto___es48p86
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

        private static void CaricaMatrice(int[,] matrice, int min, int max, char tipologia = 'n')
        {
            Random rnd = new Random();
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    switch (tipologia)
                    {
                        case 'n':
                            matrice[i, j] = rnd.Next(min, max);
                            break;
                        case 'p':
                            matrice[i, j] = rnd.Next(99) + 1;
                            break;
                    }
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

        static void Main(string[] args)
        {
            int r = LeggiNumero("Inserire la dimensione della matrice quadrata: ");
            int[,] matrice = new int[r, r];
            CaricaMatrice(matrice, 1, 10);
            
            Console.WriteLine("\nMatrice generata:");
            StampaMatrice(matrice);

            if (AreMatrixDiagonalsAverageEqual(matrice))
            {
                Console.WriteLine("\nLa media della diagonale principale e della secondaria sono uguali.");
            }
            else
            {
                Console.WriteLine("\nLe medie delle diagonali sono diverse.");
            }
            Console.ReadKey();
        }

        private static bool AreMatrixDiagonalsAverageEqual(int[,] matrice)
        {
            int n = matrice.GetLength(0);
            if (n == 0) return true;

            double sum1 = 0;
            double sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                sum1 += matrice[i, i];
                sum2 += matrice[i, n - 1 - i];
            }

            double media1 = sum1 / n;
            double media2 = sum2 / n;
            Console.WriteLine($"Media 1: {media1}, Media 2: {media2}");

            return media1 == media2;
        }
    }
}