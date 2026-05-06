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

namespace Maffiotto___pag173es2
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
        struct recAutoreCount
        {
            public string autore;
            public int count;
        }

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
                        continue;
                    }
                    libri[nLibri].codiceLibro = dati[0];
                    libri[nLibri].titolo = dati[1];
                    libri[nLibri].autore = dati[2];
                    libri[nLibri].casaEditrice = dati[3];
                    libri[nLibri].prezzo = double.Parse(dati[4], System.Globalization.CultureInfo.InvariantCulture);
                    lstDatiCaricati.Items.Add(libri[nLibri].ToString());
                    nLibri++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recAutoreCount[] tabellaAutori = new recAutoreCount[100];
            int nAutori = 0;

            for (int i = 0; i < nLibri; i++)
            {
                string autoreCorrente = libri[i].autore;
                bool trovato = false;

                for (int j = 0; j < nAutori; j++)
                {
                    if (string.Compare(tabellaAutori[j].autore, autoreCorrente, StringComparison.Ordinal) == 0)
                    {
                        tabellaAutori[j].count++;
                        trovato = true;
                        break;
                    }
                }

                if (!trovato)
                {
                    tabellaAutori[nAutori].autore = autoreCorrente;
                    tabellaAutori[nAutori].count = 1;
                    nAutori++;
                }
            }

            int maxCount = 0;
            string autoreMax = "";
            for (int j = 0; j < nAutori; j++)
            {
                if (tabellaAutori[j].count > maxCount)
                {
                    maxCount = tabellaAutori[j].count;
                    autoreMax = tabellaAutori[j].autore;
                }
            }

            lblRisultato.Text = $"Autore con più libri: {autoreMax} ({maxCount} libri)";
        }
    }
}
