using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maffiotto___es24pag116
{
    public partial class Form1 : Form
    {
        string[] animali = {
        "Aquila",
        "Cane",
        "Cavallo",
        "Coccodrillo",
        "Delfino",
        "Elefante",
        "Farfalla",
        "Gatto",
        "Rana",
        "Squalo"
        };

        string[] specie = {
        "Uccello",
        "Mammifero",
        "Mammifero",
        "Rettile",
        "Mammifero",
        "Mammifero",
        "Insetto",
        "Mammifero",
        "Anfibio",
        "Pesce"
        };
        public Form1()
        {
            InitializeComponent();
            lstAnimali.Items.AddRange(animali);
            lstSpecie.Items.AddRange(specie);
        }

        static int RicercaBinaria(string[] array, string target)
        {
            int inizio = 0, fine = array.Length - 1;
            while (inizio <= fine)
            {
                int medio = inizio + (fine - inizio) / 2;
                int confronto = array[medio].CompareTo(target);

                if (confronto == 0) return medio;
                if (confronto < 0) inizio = medio + 1;
                else fine = medio - 1;
            }
            return -1;
        }


        private void btnCerca_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == null || textBox1.Text.Length <= 3)
            {
                MessageBox.Show("Inserire il campo animale");
            }
            else
            {
                int index = RicercaBinaria(animali, textBox1.Text);
                if (index == -1)
                {
                    MessageBox.Show($"l'animale {textBox1.Text} non è presente nell'array");
                }
                else
                {
                    MessageBox.Show($"l'animale appartiene alla specie: {specie[index]}.");
                }
            }
        }


    }
}
