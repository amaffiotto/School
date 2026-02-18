using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maffiotto___es17p116
{
    public partial class Form1 : Form
    {
        string[] Canzoni = { "Albachiara", "Cenere", "Sere Nere", "Sally", "Supereroi" };
        string[] Cantanti = { "Vasco Rossi", "Lazza", "Tiziano Ferro", "Vasco Rossi", "Mr Rain" };
        public Form1()
        {
            InitializeComponent();
            lstCantanti.Items.AddRange(Cantanti);
            lstCanzoni.Items.AddRange(Canzoni);
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            lstRisultato.Items.Clear();
            string target = txtInput.Text ?? "";
            bool found = false;
            for (int i = 0; i < Canzoni.Length; i++)
            {
                if (Cantanti[i] == target)
                {
                    found = true;
                    lstRisultato.Items.Add(Canzoni[i]);
                }
            }

            if (!found)
            {
                lstRisultato.Items.Add($"Non sono presenti canzoni di {target}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
