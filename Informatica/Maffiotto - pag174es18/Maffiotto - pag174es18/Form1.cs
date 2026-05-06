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

namespace Maffiotto___pag174es18
{
    // Struttura per ogni paziente
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
        struct recRepartoCount
        {
            public string reparto;
            public int count;
        }

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
            recRepartoCount[] tabellaReparti = new recRepartoCount[100];
            int nReparti = 0;

            for (int i = 0; i < nPazienti; i++)
            {
                string repartoCorrente = pazienti[i].reparto;
                bool trovato = false;

                for (int j = 0; j < nReparti; j++)
                {
                    if (string.Compare(tabellaReparti[j].reparto, repartoCorrente, StringComparison.Ordinal) == 0)
                    {
                        tabellaReparti[j].count++;
                        trovato = true;
                        break;
                    }
                }

                if (!trovato)
                {
                    tabellaReparti[nReparti].reparto = repartoCorrente;
                    tabellaReparti[nReparti].count = 1;
                    nReparti++;
                }
            }

            lstRisultati.Items.Clear();
            for (int j = 0; j < nReparti; j++)
            {
                lstRisultati.Items.Add($"Reparto {tabellaReparti[j].reparto}: {tabellaReparti[j].count} pazienti");
            }
        }
    }
}
