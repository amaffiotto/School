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

namespace Maffiotto___pag174es21
{
    struct Calciatore
    {
        public string codiceGiocatore;
        public string cognome;
        public string nome;
        public string squadra;
        public string ruolo;
        public int nGoal;

        public override string ToString()
        {
            return $"{codiceGiocatore} {cognome} {nome} {squadra} {ruolo} {nGoal}";
        }
    }

    public partial class Form1 : Form
    {
        Calciatore[] calciatori = new Calciatore[100];
        int nCalciatori = 0;

        public Form1()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader("Calciatori.dat"))
            {
                string riga;
                string[] dati;
                while ((riga = sr.ReadLine()) != null)
                {
                    dati = riga.Split('|');
                    if (dati.Length != 6)
                    {
                        MessageBox.Show($"Errore nella struttura del file .dat alla riga {nCalciatori}", "ERRORE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    calciatori[nCalciatori].codiceGiocatore = dati[0];
                    calciatori[nCalciatori].cognome = dati[1];
                    calciatori[nCalciatori].nome = dati[2];
                    calciatori[nCalciatori].squadra = dati[3];
                    calciatori[nCalciatori].ruolo = dati[4];
                    calciatori[nCalciatori].nGoal = int.Parse(dati[5]);
                    lstDatiCaricati.Items.Add(calciatori[nCalciatori].ToString());
                    nCalciatori++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstRisultati.Items.Clear();
            string squadraRicercata = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(squadraRicercata))
            {
                MessageBox.Show("Errore: inserire una squadra", "ERRORE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool trovato = false;

            for (int i = 0; i < nCalciatori; i++)
            {
                if (string.Compare(calciatori[i].squadra, squadraRicercata) == 0)
                {
                    lstRisultati.Items.Add(calciatori[i].ToString());
                    trovato = true;
                }
            }

            if (!trovato)
            {
                MessageBox.Show($"Nessun giocatore trovato per la squadra {squadraRicercata}", "ERRORE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
