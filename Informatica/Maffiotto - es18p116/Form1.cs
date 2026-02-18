using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maffiotto___es18p116
{
    public partial class Form1 : Form
    {
        string[] cantanti = new string[15]
{
    "Alessandra Amoroso",
    "Angelina Mango",
    "Annalisa",
    "Elodie",
    "Emma",
    "Geolier",
    "Giorgia",
    "Irama",
    "Lazza",
    "Ligabue",
    "Madame",
    "Marco Mengoni",
    "Pinguini Tattici",
    "Ultimo",
    "Vasco Rossi"
};

        string[] canzoni = new string[15]
        {
    "Fino a qui",
    "La Noia",
    "Sinceramente",
    "Tribale",
    "Apnea",
    "I p' me, tu p' te",
    "Come Saprei",
    "Tu no",
    "Cenere",
    "Certe Notti",
    "Marea",
    "Due Vite",
    "Pastello Bianco",
    "Piccola Stella",
    "Albachiara"
        };
        public Form1()
        {
            InitializeComponent();
            lstCantanti.Items.AddRange(cantanti);
            lstCanzoni.Items.AddRange(canzoni);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            string target = txtInput.Text ?? "";
            bool superato = false;
            int i = 0;
            lstOutput.Items.Clear();
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
                            lstOutput.Items.Add(canzoni[i]);
                    }
                    i++;
                }
            }
        }
    }
}
