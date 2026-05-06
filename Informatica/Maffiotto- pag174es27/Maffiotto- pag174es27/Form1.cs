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

namespace Maffiotto___pag174es27
{
    public struct Professore
    {
        public string Codice { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Materia { get; set; }
        public string Scuola { get; set; }
    }
    public partial class Form1 : Form
    {
        List<Professore> list = new List<Professore>();

        List<Professore> cerca = new List<Professore>();
        public Form1()
        {
            InitializeComponent();

            LeggiFile("Professori.dat");

            List<Professore> listaOrdinata = list.OrderBy(p => p.Scuola).ToList();

            dataGridView1.DataSource = listaOrdinata;
        }

        private void LeggiFile(string nomeFile)
        {
            using (StreamReader sr = new StreamReader(nomeFile))
            {
                string riga;
                while ((riga = sr.ReadLine()) != null)
                {
                    string[] dati = new string[5];
                    dati = riga.Split('|');
                    Professore p = new Professore();
                    p.Codice = dati[0];
                    p.Cognome = dati[1];
                    p.Nome = dati[2];
                    p.Materia = dati[3];
                    p.Scuola = dati[4];

                    list.Add(p);
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string materia = textBox1.Text;

            cerca.Clear();
            foreach (Professore p in list)
            {
                if (p.Materia == materia)
                {
                    cerca.Add(p);
                }
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = cerca;
        }
    }
}
