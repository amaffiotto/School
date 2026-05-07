# Informatica - Classi Terze - Windows Forms - Lezione 8 - Minesweeper

![Library cute image](assets/lesson/library.jpg)

In questa esercitazione occorre implementare l'esercizio come da registrazione, presente in [assets/lesson/recording.mp4](assets/lesson/recording.mp4).

## Suggerimenti Operativi

Eccovi alcuni suggerimenti per riuscire a risolvere l'esercizio.

### Le strutture in C#

In C# le struct implementano il tipo di dato `Record`, quindi contengono al loro interno diversi campi che rappresentano le informazioni che compongono il dato, anche di tipo diverso.

Esempio di struct:

```csharp
struct Point
{
   int x;
   int y; 
}
```

Nell'esercizio ne avete a disposizione una, chiamata `InventoryBook`.

### La parola chiave `var`

In C# si può usare la parola chiave `var` per dichiarare una variabile senza specificare il suo tipo. 

Questo concetto prende il nome di "inferenza del tipo" o "type inference" e permette di semplificare e rendere più leggibile il codice.

> ATTENZIONE: Una variabile dichiarata in questo modo non puù cambiare tipo con assegnazioni successive, quindi se si usa `var` per dichiarare una variabile, non si può assegnare un valore di tipo diverso.
>
> Ad es. se si usa `var x = 10;` e poi si assegna `x = "ciao";` allora `x` sarà di tipo `int` e non `string`, quindi l'assegnazione non avrà successo (errore di compilazione).

```csharp
var x = 10;
var y = 20;
var z = x + y;

// tuttavia non è possibile
var w = "ciao";
w = 10; // ERRORE
```

### I file di testo

In C# si possono leggere e scrivere files. Per leggere un file di testo si usa la classe `StreamReader` e per scrivere un file di testo si usa la classe `StreamWriter`.

``` csharp
StreamReader file = new StreamReader("file.txt");

while(!file.EndOfStream)
{
    var line = file.ReadLine();
    // faccio cose con i dati letti...
}

// importante! liberiamo le risorse allocate dal file
file.Close();

StreamWriter file = new StreamWriter("file.txt");
file.WriteLine("ciao");
file.Close();
```

### L'oggetto DataGridView

L'oggetto `DataGridView` è molto utile per la visualizzazione di dati in una forma tabellare. Ecco come usare un `DataGridView`:

Un `DataGridView` viene creato tramite la finestra di progettazione o tramite codice e ci posso sia creare una tabella vuota, sia popolare una tabella già esistente.

Ecco come popolare una tabella già esistente:

1. Usare le finestra di progettazione, o scrivere codice, per definire le colonne e le righe della tabella. (noi per comodità vedremo solo la parte di progettazione)
2. Usare il metodo `DataGridView.Rows.Add` per aggiungere una riga alla tabella.
    ```csharp
    // inizializzata altrove
    DataGridView dgv;

    int x1 = 1;
    int x2 = 2;
    int x3 = 3;

    // popolare la tabella
    for (int i = 0; i < 10; i++)
    {
        dgv.Rows.Add(x1, x2, x3);
    }
    ```

### Le finestre di dialogo

Le finestre di dialogo servono a mostrare delle informazioni interattive all'utente. L'esempio più famoso è il `MessageBox`, che mostra una finestra di dialogo con un testo e un pulsante di chiusura.

``` csharp
MessageBox.Show(".....");
```

Tuttavia ne esistono molti altri tipi:
- `OpenFileDialog`
- `SaveFileDialog`
- `FolderBrowserDialog`
- ecc...

Tutte le finestre di dialogo condividono in comune un metodo chiamato `ShowDialog`. Ecco come usare una finestra di dialogo:

``` csharp
// inizializzata altrove
OpenFileDialog dialog;

var result = dialog.ShowDialog();
if (result == DialogResult.OK)
{
    // è andato tutto bene
    //
    // (in questo caso l'utente ha scelto un file)
}
else
{
    // l'utente ha annullato
}
```

Le finestre di dialogo `OpenFileDialog` e `SaveFileDialog` hanno un metodo chiamato `OpenFile` che permettono di aprire il file scelto dall'utente.

```csharp
// inizializzata altrove
OpenFileDialog dialog;

var result = dialog.ShowDialog();
if (result == DialogResult.OK)
{
    var file = dialog.OpenFile();
    // file contiene il file scelto dall'utente sotto
    // forma di file stream,
    // quindi lo leggo con uno stream reader.

    StreamReader reader = new StreamReader(file);
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        // faccio cose con i dati letti...
    }
    reader.Close();
}
```

Oppure con la classe SaveFileDialog

```csharp
// inizializzata altrove
SaveFileDialog dialog;

var result = dialog.ShowDialog();
if (result == DialogResult.OK)
{
    var file = dialog.OpenFile();
    // file contiene il file scelto dall'utente sotto
    // forma di file stream,
    // quindi lo salvo con uno stream writer.

    StreamWriter writer = new StreamWriter(file);
    writer.WriteLine("ciao");
    writer.Close();
}
```
