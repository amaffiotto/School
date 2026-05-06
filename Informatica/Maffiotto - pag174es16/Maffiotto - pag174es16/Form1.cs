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

namespace Maffiotto___pag174es16
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
            return codicePaziente +" "+cognome+" "+nome+" "+ citta+ " "+ reparto+" "+ nLetto;
        }
    }
    public partial class Form1 : Form
    {
        Paziente[] pazientiCaricati = new Paziente[100];
        public Form1()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader("reparto.dat"))
            {
                string riga;
                string[] dati = new string[6];
                int i = 0;
                while((riga = sr.ReadLine()) != null)
                {
                    dati = riga.Split('|');
                    if (dati.Length != 6)
                    {
                        MessageBox.Show($"Errore nella struttura del file .dat nella riga {i}", "ERRORE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        i++;
                    }
                    pazientiCaricati[i].codicePaziente = dati[0];
                    pazientiCaricati[i].cognome = dati[1];
                    pazientiCaricati[i].nome = dati[2];
                    pazientiCaricati[i].citta = dati[3];
                    pazientiCaricati[i].reparto = dati[4];
                    pazientiCaricati[i].nLetto = dati[5];
                    lstDatiCaricati.Items.Add(pazientiCaricati[i].ToString());
                    i++;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string reparto = textBox1.Text;
            bool found = false;
            if (reparto == "" || reparto == null)
            {
                MessageBox.Show("Errore: inserire un reparto", "ERRORE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < pazientiCaricati.Length; i++)
                {
                    if (pazientiCaricati[i].reparto == reparto)
                    {
                        listBox2.Items.Add(pazientiCaricati[i].ToString());
                        found = true;
                    }
                }
                if(!found)
                {
                    MessageBox.Show($"Errore: Nessun paziente trovato per il reparto {reparto}", "ERRORE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
