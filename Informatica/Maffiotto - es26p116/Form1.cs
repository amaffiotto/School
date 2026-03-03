using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maffiotto___es26p116
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

        static void SelectionSort(string[] vet1, string[] vet2)
        {
            for (int i = 0; i < vet1.Length - 1; i++)
            {
                int posMin = i;
                for (int j = i + 1; j < vet1.Length; j++)
                {
                    if (vet1[j].CompareTo(vet1[posMin]) < 0)
                        posMin = j;
                }

                if (posMin != i)
                {
                    string temp1 = vet1[i];
                    vet1[i] = vet1[posMin];
                    vet1[posMin] = temp1;

                    string temp2 = vet2[i];
                    vet2[i] = vet2[posMin];
                    vet2[posMin] = temp2;
                }
            }
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            SelectionSort(specie, animali);
            lstAnimali.Items.Clear();
            lstSpecie .Items.Clear();
            lstAnimali.Items.AddRange(animali);
            lstSpecie.Items.AddRange(specie);
        }
    }
}
