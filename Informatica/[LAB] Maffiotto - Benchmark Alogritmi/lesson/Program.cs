namespace lesson
{
    using System;
    using System.Diagnostics; // Necessario per Stopwatch

    public class Program
    {

        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            // definire:
            // - l'algoritmo (o gli algoritmi) di cui fare il benchmark
            //   in questo caso "Algoritmi di ricerca"
            // - i test cases (casi numerosi ma univoci, uguali per tutti)
            //   su cui far girare gli algoritmi. I test cases spesso hanno un nome
            //   "ordinato", "ordinato al contrario" "casuale" etc...
            // - calcolare i tempi (media, varianza)

            int choice = Menu();

            switch (choice)
            {
                case 1:
                    BenchmarkSearch();
                    break;
                case 2:
                    BenchmarkSort();
                    break;
                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }
        }

        /// <summary>
        /// Mostra il menu di scelta all'utente e ne restituisce l'input.
        /// </summary>
        /// <returns>La scelta effettuata dall'utente (1 o 2).</returns>
        private static int Menu()
        {
            int choice;

            do
            {
                Console.WriteLine("1 -> Benchmark ricerca");
                Console.WriteLine("2 -> Benchmark ordinamento");

                choice = Convert.ToInt32(Console.ReadLine());
            }
            while (choice < 1 || choice > 2);

            return choice;
        }
        //=========================================================================
        // BENCHMARK RICERCHE
        //=========================================================================

        /// <summary>
        /// Gestisce il flusso principale per il benchmark degli algoritmi di ricerca.
        /// </summary>
        private static void BenchmarkSearch()
        {
            Console.WriteLine("Benchmark degli algoritmi di ricerca...");

            // Abbiamo (algoritmi)
            // - ricerca sequenziale
            // - ricerca sequenziale ottimizzata
            // - ricerca binaria
            //
            // Abbiamo (casi)
            // - vettori di dimensioni diverse
            // - vettori ordinati e non
            // - vettori ordinati al contrario
            // - vettori parzialmente ordinati
            //
            // Abbiamo (unità di misura target) = µs (microsecondi)

            int[][] cases = GenerateBenchmarkCases(1000);
            int[][] SortedWithRepetitioncases = GenerateOrderedBenchmarkCases(1000);
            int[][] SortedWithoutRepetitioncases = GenerateOrderedWithoutRepetitionBenchmarkCases(1000);
            
            int[] sequentialSearchTimes = BenchmarkSequentialSearch(cases);
            int[] sequentialSearchOnOrderedWRTimes = BenchmarkSequentialSearch(SortedWithRepetitioncases);
            int[] sequentialSearchOnOrderedWORTimes = BenchmarkSequentialSearch(SortedWithoutRepetitioncases);
            
            int[] OptimizedSequentialSearchTimes = BenchmarkOptimizedSequentialSearch(SortedWithRepetitioncases);
            int[] OptimizedSequentialSearchWORTimes = BenchmarkOptimizedSequentialSearch(SortedWithoutRepetitioncases);
            
            int[] binarySearchTimes = BenchmarkBinarySearch(SortedWithoutRepetitioncases);
            
            PrintTimes("Ricerca sequenziale (Array NON ordinato con ripetizioni)", sequentialSearchTimes);
            Console.WriteLine("\n");
            PrintTimes("Ricerca Sequenziale (Array ordinato con ripetizioni)", sequentialSearchOnOrderedWRTimes);
            Console.WriteLine("\n");
            PrintTimes("Ricerca Sequenziale (Array ordinato SENZA ripetizioni)", sequentialSearchOnOrderedWORTimes);
            Console.WriteLine("\n---------------------------------------\n");
            
            PrintTimes("Ricerca sequenziale ottimizzata (Array ordinato con ripetizioni)", OptimizedSequentialSearchTimes);
            Console.WriteLine("\n");
            PrintTimes("Ricerca sequenziale ottimizzata (Array ordinato SENZA ripetizioni)", OptimizedSequentialSearchWORTimes);
            Console.WriteLine("\n---------------------------------------\n");
            
            PrintTimes("Ricerca Binaria (Array ordinato SENZA ripetizioni)", binarySearchTimes);
        }

        /// <summary>
        /// Stampa i tempi di un benchmark.
        /// </summary>
        /// <param name="name">Nome visualizzato del benchmark</param>
        /// <param name="times">I tempi da stampare</param>
        private static void PrintTimes(string name, int[] times)
        {
            Console.WriteLine($"{name} :");

            // media
            double average = times[0];
            for (int i = 1; i < times.Length; i++)
            {
                average += times[i];
            }
            average /= times.Length;

            // scarto quadratico medio
            double discardAvg = 0;
            for (int i = 0; i < times.Length; i++)
            {
                double discard = times[i] - average;
                discardAvg += discard * discard;
            }
            discardAvg = Math.Sqrt(discardAvg);

            Console.WriteLine($"Media (µs): {average}, Scarto quadratico medio (µs): {discardAvg}");
        }

        //=========================================================================
        //Gen test cases
        //=========================================================================

        /// <summary>
        /// Genera i vettori da usare in tutti i benchmark (versione non ordinata).
        /// </summary>
        /// <param name="n">Il numero di casi da generare.</param>
        /// <returns>I vettori generati</returns>
        private static int[][] GenerateBenchmarkCases(int n)
        {
            int[][] cases = new int[n][];

            for (int i = 0; i < n; i++)
            {
                cases[i] = GenerateRandomBenchmarkCase(i * 10 + 1);
            }

            return cases;
        }

        /// <summary>
        /// Genera un singolo case (un vettore casuale).
        /// </summary>
        /// <param name="n">La dimensione del vettore.</param>
        /// <returns>Un vettore generato casualmente</returns>
        private static int[] GenerateRandomBenchmarkCase(int n)
        {
            Random rnd = new Random();
            int[] benchCase = new int[n];

            for (int i = 0; i < n; i++)
            {
                benchCase[i] = rnd.Next(0, 10000);
            }

            return benchCase;
        }

        /// <summary>
        /// Genera i vettori da usare nei benchmark che richiedono ordinamento (CON RIPETIZIONI).
        /// </summary>
        /// <param name="n">Il numero di casi da generare.</param>
        /// <returns>Una matrice di vettori ordinati (CON RIPETIZIONI).</returns>
        private static int[][] GenerateOrderedBenchmarkCases(int n)
        {
            int[][] cases = new int[n][];

            for (int i = 0; i < n; i++)
            {
                cases[i] = GenerateOrderedWithRepetitionBenchmarkCase(i * 10 + 1);
            }

            return cases;
        }

        /// <summary>
        /// Genera un singolo case ordinato con possibilità di ripetizioni.
        /// </summary>
        /// <param name="n">La dimensione del vettore.</param>
        /// <returns>Un vettore ordinato.</returns>
        private static int[] GenerateOrderedWithRepetitionBenchmarkCase(int n)
        {
            Random rnd = new Random();
            int[] benchCase = new int[n];

            for (int i = 0; i < n; i++)
            {
                benchCase[i] = rnd.Next(0, 10000);
            }
            Array.Sort(benchCase);

            return benchCase;
        }
        
        /// <summary>
        /// Genera i vettori da usare nei benchmark che richiedono ordinamento senza ripetizioni.
        /// </summary>
        /// <param name="n">Il numero di casi da generare.</param>
        /// <returns>Una matrice di vettori ordinati SENZA RIPETIZIONI.</returns>
        private static int[][] GenerateOrderedWithoutRepetitionBenchmarkCases(int n)
        {
            int[][] cases = new int[n][];

            for (int i = 0; i < n; i++)
            {
                cases[i] = GenerateOrderedWithoutRepetitionBenchmarkCase(i * 10 + 1);
            }

            return cases;
        }
        
        /// <summary>
        /// Genera un singolo case ordinato senza possibilità di ripetizioni.
        /// </summary>
        /// <param name="n">La dimensione del vettore.</param>
        /// <returns>Un vettore ordinato e senza ripetizioni.</returns>
        private static int[] GenerateOrderedWithoutRepetitionBenchmarkCase(int n)
        {
            Random rnd = new Random();
            int[] benchCase = new int[n];

            int currentVal = 0;
            for (int i = 0; i < n; i++)
            {
                currentVal += rnd.Next(1, 10); 
                benchCase[i] = currentVal;
            }
            
            return benchCase;
        }
        
        
        //=========================================================================
        // RICERCA SEQUENZIALE
        //=========================================================================

        /// <summary>
        /// Effettua un benchmark della ricerca sequenziale classica.
        /// </summary>
        /// <param name="cases">I bench cases da usare</param>
        /// <returns>I tempi dei benchmark</returns>
        private static int[] BenchmarkSequentialSearch(int[][] cases)
        {
            int[] times = new int[cases.Length];

            for (int i = 0; i < cases.Length; i++)
            {
                times[i] = BenchmarkSequentialSearchCase(cases[i]);
            }

            return times;
        }

        /// <summary>
        /// Restituisce il tempo di benchmark per un singolo caso di 
        /// ricerca sequenziale.
        /// </summary>
        /// <param name="benchCase">il bench case</param>
        /// <returns>Il tempo del benchmark in millisecondi.</returns>
        private static int BenchmarkSequentialSearchCase(int[] benchCase)
        {
            var watch = Stopwatch.StartNew();

            // cerchiamo sempre l'elemento a metà, per comodità, ma si può cambiare
            int index = SequentialSearch(benchCase, benchCase[benchCase.Length / 2]);
            if (index == -1)
            {
                Console.WriteLine("ERRORE IMPORTANTE");
            }

            watch.Stop();

            // Converto i millisecondi in microsecondi moltiplicando per 1000
            return (int)(watch.Elapsed.TotalMilliseconds * 1000);
        }

        /// <summary>
        /// Algoritmo di ricerca sequenziale. Scorre il vettore fino a trovare l'elemento.
        /// </summary>
        /// <param name="benchCase">Il vettore in cui cercare.</param>
        /// <param name="value">Il valore da cercare.</param>
        /// <returns>L'indice del valore trovato, oppure -1.</returns>
        private static int SequentialSearch(int[] benchCase, int value)
        {
            for (int i = 0; i < benchCase.Length; i++)
            {
                if (benchCase[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
        
        //=========================================================================
        // RICERCA SEQUENZIALE OTTIMIZZATA
        //=========================================================================

        /// <summary>
        /// Effettua un benchmark della ricerca sequenziale ottimizzata (per vettori ordinati).
        /// </summary>
        /// <param name="cases">I bench cases ordinati da usare.</param>
        /// <returns>I tempi dei benchmark.</returns>
        private static int[] BenchmarkOptimizedSequentialSearch(int[][] cases)
        {
            int[] times = new int[cases.Length];

            for (int i = 0; i < cases.Length; i++)
            {
                times[i] = BenchmarkOptimizedSequentialSearchCase(cases[i]);
            }

            return times;
        }

        /// <summary>
        /// Restituisce il tempo di benchmark per un singolo caso di 
        /// ricerca sequenziale ottimizzata.
        /// </summary>
        /// <param name="benchCase">Il bench case ordinato.</param>
        /// <returns>Il tempo del benchmark in millisecondi.</returns>
        private static int BenchmarkOptimizedSequentialSearchCase(int[] benchCase)
        {
            var watch = Stopwatch.StartNew();

            // cerchiamo sempre l'elemento a metà, per comodità, ma si può cambiare
            int index = OptimizedSequentialSearch(benchCase, benchCase[benchCase.Length / 2]);
            if (index == -1)
            {
                Console.WriteLine("ERRORE IMPORTANTE");
            }

            watch.Stop();

            return (int)(watch.Elapsed.TotalMilliseconds * 1000);
        }

        /// <summary>
        /// Algoritmo di ricerca sequenziale ottimizzata. Interrompe la ricerca se l'elemento corrente
        /// è maggiore del valore cercato (richiede vettore ordinato).
        /// </summary>
        /// <param name="benchCase">Il vettore ordinato in cui cercare.</param>
        /// <param name="value">Il valore da cercare.</param>
        /// <returns>L'indice del valore trovato, oppure -1.</returns>
        private static int OptimizedSequentialSearch(int[] benchCase, int value)
        {
            for (int i = 0; i < benchCase.Length && benchCase[i] <= value; i++)
            {
                if (benchCase[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
        //=========================================================================
        // RICERCA BINARIA
        //=========================================================================

        /// <summary>
        /// Effettua un benchmark della ricerca binaria.
        /// </summary>
        /// <param name="cases">I bench cases da usare.</param>
        /// <returns>I tempi dei benchmark.</returns>
        private static int[] BenchmarkBinarySearch(int[][] cases)
        {
            int[] times = new int[cases.Length];

            for (int i = 0; i < cases.Length; i++)
            {
                times[i] = BenchmarkBinarySearchCase(cases[i]);
            }

            return times;
        }

        private static int BenchmarkBinarySearchCase(int[] benchCase)
        {
            // Non cerco l'elemento a metà se no lo troverebbe sempre per primo
            Random rnd = new Random();
            int targetIndex = rnd.Next(0, benchCase.Length - 1);
            int target = benchCase[targetIndex];
            
            var watch = Stopwatch.StartNew();

            int index = BinarySearch(benchCase, target);
            if (index == -1)
            {
                Console.WriteLine("ERRORE IMPORTANTE");
            }

            watch.Stop();

            return (int)(watch.Elapsed.TotalMilliseconds * 1000);
        }

        /// <summary>
        /// Esegue una ricerca binaria (dicotomica) su un array di interi.
        /// L'array DEVE essere ordinato in modo crescente.
        /// </summary>
        /// <param name="array">L'array ordinato.</param>
        /// <param name="target">Il valore da cercare.</param>
        /// <returns>L'indice dell'elemento se trovato, altrimenti -1.</returns>
        static int BinarySearch(int[] array, int target)
        {
            int inizio = 0, fine = array.Length - 1;
            while (inizio <= fine)
            {
                int medio = inizio + (fine - inizio) / 2;
                if (array[medio] == target)
                {
                    return medio;
                }
                if (array[medio] < target)
                {
                    inizio = medio + 1;
                }
                else
                {
                    fine = medio - 1;
                }
            }
            return -1;
        }
        
        //========================================================================
        // BENCHMARK RICERCHE
        //========================================================================

        /// <summary>
        /// Gestisce il flusso principale per il benchmark degli algoritmi di ordinamento (Non Implementato).
        /// </summary>
        private static void BenchmarkSort()
        {
            throw new NotImplementedException();
        }
    }
}