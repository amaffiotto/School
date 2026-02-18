using System;

namespace Maffiotto___es45p85
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

                    matrice[i, j] = LeggiNumero($"Inserisci valore per [{i},{j}] (0 o 1): ", false, 0);
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

        private static bool VerificaCroce(int[,] matrice)
        {
            int centro = matrice.GetLength(0) / 2;

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    if (i == centro || j == centro)
                    {
                        if (matrice[i, j] != 1) return false;
                    }
                    else
                    {
                        if (matrice[i, j] != 0) return false;
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int r;
            do
            {
                r = LeggiNumero("Inserire la dimensione della matrice (deve essere dispari): ", true, 3);
                if (r % 2 == 0)
                {
                    Console.WriteLine("Il numero deve essere dispari.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (r % 2 == 0);

            int[,] matrice = new int[r, r];
            
            CaricaMatriceManuale(matrice);
            Console.Clear();
            StampaMatrice(matrice);

            bool isCroce = VerificaCroce(matrice);

            if (isCroce)
            {
                Console.WriteLine("La matrice contiene una croce centrale di 1 e 0 altrove.");
            }
            else
            {
                Console.WriteLine("La matrice NON rispetta le condizioni.");
            }
            Console.ReadKey();
        }
    }
}