using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maffiotto___es19p116
{
    public partial class Form1 : Form
    {
        string[] cantanti = new string[30]
{
    "Alessandra Amoroso", "Angelina Mango", "Annalisa", "Annalisa", "Elodie",
    "Emma", "Geolier", "Geolier", "Giorgia", "Irama",
    "Jay-Z", "Jay-Z", "Kanye West", "Kanye West", "Lazza",
    "Lazza", "Ligabue", "Madame", "Marco Mengoni", "Pinguini Tattici",
    "Pinguini Tattici", "Playboi Carti", "Playboi Carti", "Sfera Ebbasta", "Tananai",
    "Tedua", "The Kolors", "Ultimo", "Vasco Rossi", "Zucchero"
};

        string[] canzoni = new string[30]
        {
    "Fino a qui", "La Noia", "Sinceramente", "Euforia", "Tribale",
    "Apnea", "I p' me, tu p' te", "L'ultima poesia", "Come Saprei", "Tu no",
    "Empire State of Mind", "The Story of O.J.", "Stronger", "Runaway", "Cenere",
    "100 Messaggi", "Certe Notti", "Marea", "Due Vite", "Pastello Bianco",
    "Ricordi", "Magnolia", "Sky", "Visiera a becco", "Veleno",
    "Red Light", "Un ragazzo una ragazza", "Piccola Stella", "Albachiara", "Baila"
        };
        public Form1()
        {
            InitializeComponent();
            lstCantanti.Items.AddRange(cantanti);
            lstCanzoni.Items.AddRange(canzoni);
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            string target = txtInput.Text ?? "";
            bool superato = false;
            int i = 0;
            int count = 0;
            if (target.Length > 3)
            {
                while (!superato && i < cantanti.Length)
                {
                    if (target.CompareTo(cantanti[i]) < 0)
                    {
                        superato = true;
                    }
                    if (target == cantanti[i])
                    {
                        count++;
                    }
                    i++;
                }
                MessageBox.Show($"Ci sono {count} canzoni di {target} in libreria");
            }
            else
            {
                MessageBox.Show("Inserire almeno 3 caratteri", "Attenzione!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
