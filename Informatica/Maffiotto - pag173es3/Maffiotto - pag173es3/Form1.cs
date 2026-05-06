using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Maffiotto___pag173es3
{
    // Struttura per ogni libro
    struct recLibro
    {
        public string codiceLibro;
        public string titolo;
        public string autore;
        public string casaEditrice;
        public double prezzo;

        public override string ToString()
        {
            return $"{codiceLibro} {titolo} {autore} {casaEditrice} {prezzo:F2}";
        }
    }

    public partial class Form1 : Form
    {
        recLibro[] libri = new recLibro[100];
        int nLibri = 0;

        public Form1()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader("libri.dat"))
            {
                string riga;
                string[] dati;
                while ((riga = sr.ReadLine()) != null)
                {
                    dati = riga.Split('|');
                    if (dati.Length != 5)
                    {
                        MessageBox.Show($"Errore nella struttura del file .dat alla riga {nLibri}", "ERRORE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    libri[nLibri].codiceLibro = dati[0];
                    libri[nLibri].titolo = dati[1];
                    libri[nLibri].autore = dati[2];
                    libri[nLibri].casaEditrice = dati[3];
                    libri[nLibri].prezzo = double.Parse(dati[4])s;
                    lstDatiCaricati.Items.Add(libri[nLibri].ToString());
                    nLibri++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recLibro[] libriOrdinati = new recLibro[nLibri];
            for (int i = 0; i < nLibri; i++)
                libriOrdinati[i] = libri[i];

            for (int i = 0; i < nLibri - 1; i++)
            {
                int posMin = i;

                for (int j = i + 1; j < nLibri; j++)
                {
                    if (string.Compare(libriOrdinati[j].autore, libriOrdinati[posMin].autore, StringComparison.Ordinal) < 0)
                    {
                        posMin = j;
                    }
                }

                if (posMin != i)
                {
                    recLibro temp = libriOrdinati[i];
                    libriOrdinati[i] = libriOrdinati[posMin];
                    libriOrdinati[posMin] = temp;
                }
            }

            lstDatiOrdinati.Items.Clear();
            for (int i = 0; i < nLibri; i++)
                lstDatiOrdinati.Items.Add(libriOrdinati[i].ToString());
        }
    }
}
