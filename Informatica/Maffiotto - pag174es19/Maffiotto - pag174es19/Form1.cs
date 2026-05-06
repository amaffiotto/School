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

namespace Maffiotto___pag174es19
{
    struct Paziente
    {
        public string codicePaziente;
        public string cognome;
        public string nome;
        public string citta;
        public string reparto;
        public string nLetto;

        public override string ToString()
        {
            return $"{codicePaziente} {cognome} {nome} {citta} {reparto} {nLetto}";
        }
    }

    public partial class Form1 : Form
    {
        Paziente[] pazienti = new Paziente[100];
        int nPazienti = 0;

        public Form1()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader("Pazienti.dat"))
            {
                string riga;
                string[] dati;
                while ((riga = sr.ReadLine()) != null)
                {
                    dati = riga.Split('|');
                    if (dati.Length != 6)
                    {
                        MessageBox.Show($"Errore nella struttura del file .dat alla riga {nPazienti}", "ERRORE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    pazienti[nPazienti].codicePaziente = dati[0];
                    pazienti[nPazienti].cognome = dati[1];
                    pazienti[nPazienti].nome = dati[2];
                    pazienti[nPazienti].citta = dati[3];
                    pazienti[nPazienti].reparto = dati[4];
                    pazienti[nPazienti].nLetto = dati[5];
                    lstDatiCaricati.Items.Add(pazienti[nPazienti].ToString());
                    nPazienti++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstRisultati.Items.Clear();
            string cittaRicercata = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(cittaRicercata))
            {
                MessageBox.Show("Errore: inserire una città", "ERRORE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool trovato = false;

            for (int i = 0; i < nPazienti; i++)
            {
                if (string.Compare(pazienti[i].citta, cittaRicercata, StringComparison.Ordinal) == 0)
                {
                    lstRisultati.Items.Add(pazienti[i].ToString());
                    trovato = true;
                }
            }

            if (!trovato)
            {
                MessageBox.Show($"Nessun paziente trovato per la città {cittaRicercata}", "ERRORE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
