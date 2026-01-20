namespace Maffiotto___es9p115;

class Program
{
    static void Main(string[] args)
    {
        string[] nomi =
        {
            "Marco", "Luca", "Andrea", "Giuseppe", "Francesco", "Paolo", "Antonio", "Stefano", "Matteo", "Davide"
        };

        string[] citta =
        {
            "Alba", "Bra", "Cuneo", "Fossano", "Saluzzo", "Savigliano", "Cavallermaggiore", "Bandito", "Roreto", "B. S. Martino"
        };
        Array.Sort(nomi);
        Array.Sort(citta);
        bool trovato = false, superato = false;
        int i = 0,cont = 0;
        
        Console.Write("Inserisci il nome della città da cercare: ");
        String nome = Console.ReadLine();

        while (!superato && i < citta.Length)
        {
            if (citta[i] == nome)
            {
                trovato = true;
                cont++;
                i++;
            }
            else
            {
                if (citta[i].CompareTo(nome) > 0)
                {
                    superato = true;
                }
                else
                {
                    i++;
                }
            }
        }

        if (trovato)
        {
            Console.WriteLine($"Il numero di studenti residenti a {nome} sono: {cont}");
        }
        else
        {
            Console.WriteLine($"Nessuno studente residente a {nome}");
        }
    }
}