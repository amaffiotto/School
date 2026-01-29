using System.Xml.Schema;

namespace esercizio_2026_01_29;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inserire la dimesnione del vettore: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserire min: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserire max: ");
        int max = Convert.ToInt32(Console.ReadLine());
        int[] array = RandomLoadArray(n, min, max);
        PrintArray(array);
        string stringArray = StringToArray(array);
        Console.WriteLine($"Ecco l'array trasformato in stringa: {stringArray}");
        int maxArray = GreaterOfArray(array);
        Console.WriteLine($"L'elemento maggiore dell'array è {maxArray}");
        Console.WriteLine($"Inserire l'inizio del subArray");
        int subArrayStart = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Inserire la fine del subArray");
        int subArrayEnd = Convert.ToInt32(Console.ReadLine());
        int maxSubArray = GreaterOfSubArray(array,  subArrayStart, subArrayEnd);
        Console.WriteLine($"L'elemento più grande compreso tra gli indici {subArrayStart} e {subArrayEnd} è {maxSubArray}");
        Console.WriteLine("Inserire l'elemento per controllare se è nell'array");
        int isInArray = Convert.ToInt32(Console.ReadLine());
        if (ArrayContainsElement(array, isInArray))
        {
            Console.WriteLine($"L'elemento {isInArray} è nel vettore");
        }
        else
        {
            Console.WriteLine($"L'elemento {isInArray} NON è nel vettore");
        }
        int[] newSortedArray = SortedArray(array);
        SortArray(array);
        Console.WriteLine($"L'array ordinato è: ");
        PrintArray(array);
        Console.WriteLine("Il nuovo array ordinato è: ");
        PrintArray(newSortedArray);
        int[] arrayToSubSort = RandomLoadArray(10, 1, 10);
        Console.WriteLine("Inserire l'inizio del subArraySort");
        int subArraySortStart = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserire la fine del subArraySort");
        int subArraySortEnd = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Array prima del subSort");
        PrintArray(arrayToSubSort);
        SortSubArray(arrayToSubSort, subArrayStart, subArrayEnd);
        Console.WriteLine("Array dopo il subSort");
        PrintArray(arrayToSubSort);
    }

    /// <summary>
    /// Ordina un array di interi usando l'algoritmo Bubble Sort.
    /// Ottimizzato con flag 'swapped' per terminare prima se già ordinato.
    /// </summary>
    /// <param name="vet">L'array da ordinare.</param>
    /// <returns>Un nuovo array ordinato tramite bubble sort</returns>
    static int[] BubbleSortNewArray(int[] array)
    {
        int[] vet = (int[])array.Clone();
        int i = 0;
        bool swapped;
        do
        {
            swapped = false;
            for (int j = 0; j < vet.Length - 1 - i; j++)
            {
                if (vet[j] > vet[j + 1])
                {
                    int temp = vet[j];
                    vet[j] = vet[j + 1];
                    vet[j + 1] = temp;
                    swapped = true;
                }
            }
            i++;
        } while (swapped);
        return vet;
    }
    
    /// <summary>
    /// Ordina un array di interi usando l'algoritmo Bubble Sort.
    /// Ottimizzato con flag 'swapped' per terminare prima se già ordinato.
    /// </summary>
    /// <param name="vet">L'array da ordinare.</param>
    static void BubbleSort(int[] vet)
    {
        int i = 0;
        bool swapped;
        do
        {
            swapped = false;
            for (int j = 0; j < vet.Length - 1 - i; j++)
            {
                if (vet[j] > vet[j + 1])
                {
                    int temp = vet[j];
                    vet[j] = vet[j + 1];
                    vet[j + 1] = temp;
                    swapped = true;
                }
            }
            i++;
        } while (swapped);
    }

    /// <summary>
    /// Esegue il bubble sort su una sezione di un array
    /// </summary>
    /// <param name="array"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns>L'array riordinato secondo il criterio sopra citato</returns>
    private static void SortSubArray(int[] array, int start, int end)
    {
        if (array == null || start < 0 || end >= array.Length || start >= end)
        {
            Console.WriteLine("Errore: Indici non validi per il sotto-array.");
            return;
        }
        
        int n = end - start + 1;
        bool swapped;
        int i = 0;

        do
        {
            swapped = false;
            for (int j = start; j < end - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }
            i++;
        } while (swapped);
    }


    private static int[] SortedArray(int[] array)
    {
        return BubbleSortNewArray(array);
    }

    private static void SortArray(int[] array)
    {
        BubbleSort(array);
    }

    /// <summary>
    /// Trova se un elemento è contenuto nell'array
    /// </summary>
    /// <param name="array"></param>
    /// <param name="element"></param>
    /// <returns>True se è nell'array e False se non c'è</returns>
    private static bool ArrayContainsElement(int[] array, int element)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Trova il numero più grande in una determinata sezione di un vettore
    /// </summary>
    /// <param name="array"></param>
    /// <param name="subArrayStart"></param>
    /// <param name="subArrayEnd"></param>
    /// <returns>Il max nel subArray</returns>
    private static int GreaterOfSubArray(int[] array, int subArrayStart, int subArrayEnd)
    {
        if (subArrayStart > subArrayEnd)
        {
            return -1;
        }
        int max = int.MinValue;
        for (int i = subArrayStart; i <= subArrayEnd; i++)
        {
            if (array[i] > max)
            {
                max  = array[i];
            } 
        }
        return max;
    }

    /// <summary>
    /// Trasforma un vettore in una strinag
    /// </summary>
    /// <param name="array"></param>
    /// <returns>Stringa equivalente al vettore con gli elementi separati da spazi</returns>
    private static string StringToArray(int[] array)
    {
        string result = "";
        for (int i = 0; i < array.Length - 1; i++)
        {
            result += Convert.ToString(array[i]);
            result += " ";
        }
        result += array[array.Length - 1];
        return result;
    }

    /// <summary>
    /// Restituisce il numero più grande in un array
    /// </summary>
    /// <param name="array"></param>
    /// <returns>il numero più grande presente nell'array</returns>
    private static int GreaterOfArray(int[] array)
    {
        int max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }


    /// <summary>
    /// Carica un array di n numeri casuali, fra min e max
    /// </summary>
    /// <param name="n"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns>un array di n elementi compresi tra min e max</returns>
    private static int[] RandomLoadArray(int n, int min, int max)
    {
        Random rnd = new Random();
        if (n <= 0)
        {
            return null;
        }
        int[] ris = new int[n];
        for (int i = 0; i < n; i++)
        {
            ris[i]  = rnd.Next(min, max + 1);
        }
        return ris;
    }
    /// <summary>
    /// Stampa un vettore a schermo
    /// </summary>
    /// <param name="array"></param>
    private static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
    
    
}