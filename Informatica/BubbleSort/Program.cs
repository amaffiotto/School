namespace BubbleSort;

internal class Program
{
    static void BubbleSort(string[] vet)
    {
        int i = -1;
        bool swapped;

        do
        {
            i++;
            swapped = false;
            for (int j = vet.Length - 2; j >= i; j--)
            {
                if (vet[j].CompareTo(vet[j + 1]) > 0)
                {
                    string temp = vet[j];
                    vet[j] = vet[j + 1];
                    vet[j + 1] = temp;
                    swapped = true;
                }
            }
        } while (swapped && i < vet.Length-1);
    }

    private static void Main(string[] args)
    {
        string[] vet = { "Barbara", "Alberto", "Paola", "Domenico", "Beatrice", "Vincenzo" };
        for (int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine($"Elemento {i}: {vet[i]}");
        }

        Console.WriteLine("Esecuzione Bubblesort...");
        
        BubbleSort(vet);
        
        for (int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine($"Elemento {i}: {vet[i]}");
        }
    }
}
