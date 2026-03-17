using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maffiotto___es55p86
{
    public partial class Form1 : Form
    {
        static void CaricaMatrice(int[,] matrice)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrice.GetLength(0); i++)
                for (int j = 0; j < matrice.GetLength(1); j++)
                    matrice[i, j] = rnd.Next(-10, 11);
        }

        static bool DiagonalePositiva(int[,] matrice)
        {
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrice.GetLength(1); j++)
                {
                    if (matrice[i, j] <= 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int r = Convert.ToInt32(textBox1.Text);
            int c = Convert.ToInt32(textBox2.Text);
            int[,] matrice = new int[r, c];

            CaricaMatrice(matrice);

            string[] stringheMatrice = new string[matrice.GetLength(0)];
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                string riga = "";
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    riga += matrice[i, j] + " ";
                }
                stringheMatrice[i] = riga.Trim();
            }

            listBox1.Items.AddRange(stringheMatrice);

            if(DiagonalePositiva(matrice))
            {
                MessageBox.Show("I numeri al di sopra della diagonale SONO positivi");
            }
            else
            {
                MessageBox.Show("I numeri al di sopra della diagonale NON SONO positivi");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
