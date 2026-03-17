using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Maffiotto___p116es29
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
            string animaleInput = textBox1.Text;
            string specieAnimale = "";

            for (int i = 0; i < animali.Length; i++)
            {
                if (animali[i] == animaleInput)
                {
                    specieAnimale = specie[i];
                }
            }

            listBox2.Items.Clear();

            for (int i = 0; i < animali.Length; i++)
            {
                if (specie[i] == specieAnimale && animali[i] != animaleInput)
                {
                    listBox2.Items.Add(animali[i]);
                }
            }
        }
    }
    }
