using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maffiotto___es28p116
{
    public partial class Form1 : Form
    {
        string[] animali = {
         "Rana",
    "Farfalla",
    "Cane",
    "Cavallo",
    "Delfino",
    "Elefante",
    "Gatto",
    "Squalo",
    "Coccodrillo",
    "Aquila"
};

    string[] specie = {
    "Anfibio",
    "Insetto",
    "Mammifero",
    "Mammifero",
    "Mammifero",
    "Mammifero",
    "Mammifero",
    "Pesce",
    "Rettile",
    "Uccello"
};
    public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(animali);
            listBox2.Items.AddRange(specie);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string target = textBox1.Text;
            for (int i = 0; i < specie.Length; i++)
            {
                if( specie[i] == target )
                {
                    count++;
                }
            }
            MessageBox.Show($"La specie{target} ha {count} animali.");
        }
    }
}
