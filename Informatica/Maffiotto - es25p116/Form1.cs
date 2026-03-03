using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maffiotto___es25p116
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
            listBox1.Items.AddRange(animali);
            listBox2.Items.AddRange(specie);
        }

        static int RicercaABlocchi(string[] array, string target)
        {
            int n = array.Length;
            int step = (int)Math.Sqrt(n);
            int prev = 0;

            while (array[Math.Min(step, n) - 1].CompareTo(target) < 0)
            {
                prev = step;
                step += (int)Math.Sqrt(n);
                if (prev >= n) return -1;
            }

            while (array[prev].CompareTo(target) < 0)
            {
                prev++;
                if (prev == Math.Min(step, n)) return -1;
            }

            if (array[prev] == target) return prev;
            return -1;
        }


        private void btnCerca_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text.Length <= 3)
            {
                MessageBox.Show("Inserire il campo animale");
            }
            else
            {
                int index = RicercaABlocchi(animali, textBox1.Text);
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
