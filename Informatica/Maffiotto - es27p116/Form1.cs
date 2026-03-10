using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maffiotto___es27p116
{
    public partial class Form1 : Form
    {
        static string[] animali = {
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

        static string[] specie = {
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
    static string TrovaSpecieConPiuAnimali()
    {
        int count = 1;
        int maxCount = 1;
        string maxSpecie = specie[0];
        string precedente = specie[0];

        for (int i = 1; i < specie.Length; i++)
        {
            if (specie[i] == precedente)
            {
                count++;
            }
            else
            {
                count = 1;
                precedente = specie[i];
            }

            if (count > maxCount)
            {
                maxCount = count;
                maxSpecie = specie[i];
            }
        }

        return $"La specie con più animali è {maxSpecie} con {maxCount} animali.";
        }
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(specie);
            listBox2.Items.AddRange(animali);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TrovaSpecieConPiuAnimali());
        }
    }
}
