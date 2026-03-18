using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaffiottoAndrea
{
    public partial class Form1 : Form
    {
        string[] congomi =
        {
            "Aigotti",
            "Bianchi",
            "Conti",
            "Druzzo",
            "Erti",
            "Findus",
            "Giaccardi",
            "Hilton",
            "Isaia",
            "Jhon",
            "Kleda",
            "Leon",
            "Maffiotto",
            "Nadir",
            "Ometto",
            "Perrone",
            "Rosso",
            "Seta",
            "Zhu"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstRisultato.Items.Clear();
            lstStudenti.Items.Clear();
            lstVoti.Items.Clear();

            if (string.IsNullOrEmpty(txtCinput.Text) || string.IsNullOrEmpty(txtNinput.Text))
            {
                MessageBox.Show("Devi inserire i valori n e c");
            }
            else
            {
                int n = Convert.ToInt32(txtNinput.Text);
                int c = Convert.ToInt32(txtNinput.Text);

                if (n > 20 || n < 0 || c < 0)
                {
                    MessageBox.Show("n non puo essere maggiore del numero di studenti massimo");
                }
                else
                {
                    for(int i = 0; i < n; i++)
                    {
                        lstStudenti.Items.Add(congomi[i]);
                    }
                    int[,] matriceVoti = new int[n, c];

                    RiempiMatrice(matriceVoti);

                    string[] arrayRis = TrasformaMatriceInArray(matriceVoti);

                    lstVoti.Items.AddRange(arrayRis);


                    for(int i = 0;i < n; i++)
                    {
                        double[] medieMaterie = CalcolaMedieMaterie(matriceVoti, i);
                        string stringaOut = CostruisciStringaRisultato(matriceVoti, congomi[i], medieMaterie, i);

                        lstRisultato.Items.Add(stringaOut);
                    }
                }
            }

        }

        private string CostruisciStringaRisultato(int[,] matrice, string congome, double[] avgMaterie, int indexStd)
        {
            string output = "";

            int nMateriaMax = TrovaIndiceMediaMax(avgMaterie);
            double mediaMateriaMax = TrovaMediaMax(avgMaterie);
            string votiPerMaxMateria = TrovaVotiPerMaxMateria(matrice, nMateriaMax);
            string votoMineMax = TrovaVotoMineMax(matrice, indexStd);

            output += $"Lo studente: {congome} ha la media più alta ({mediaMateriaMax}) nella materia: {nMateriaMax} la media è stata ottenuta con i voti {votiPerMaxMateria}, {votoMineMax}";


            return output;
        }

        private string TrovaVotoMineMax(int[,] matrice, int indexStd)
        {
            string output = "";

            int votoMin = int.MaxValue;
            int votoMax = int.MinValue;

            for (int i = 0; i < matrice.GetLength(1); i++)
            {
                if (matrice[indexStd, i] > votoMax)
                {
                    votoMax = matrice[indexStd, i];
                }
                if(matrice[indexStd, i] < votoMin)
                {
                    votoMin = matrice[indexStd, i];
                }

            }

            return $"Voto Min: {votoMin}, Voto Max: {votoMax}";
        }

        private string TrovaVotiPerMaxMateria(int[,] matrice, int indexMax)
        {
            string output = "";

            for(int i = 0; i < matrice.GetLength(1); i++)
            {
                output += matrice[indexMax, i] + " ";
            }

            return output;
        }

        private int TrovaIndiceMediaMax(double[] medieMaterie)
        {
            int output = int.MinValue;

            for (int i = 0; i < medieMaterie.Length; i++)
            {
                if (medieMaterie[i] > output)
                {
                    output = i;
                }
            }

            return output;
        }

        private double TrovaMediaMax(double[] medieMaterie)
        {
            double output = double.MinValue;

            for(int i = 0; i < medieMaterie.Length; i++)
            {
                if (medieMaterie[i] > output)
                {
                    output = medieMaterie[i];
                }
            }

            return output;
        }

        private double[] CalcolaMedieMaterie(int[,] matriceVoti, int nStudente)
        {
            double[] output = new double[matriceVoti.GetLength(0)];

            for(int i = 0; i < matriceVoti.GetLength(0); i++)
            {
                for(int j = 0; j < matriceVoti.GetLength(1); j++)
                {
                    output[i] += matriceVoti[nStudente, j];
                }
                output[i] /= matriceVoti.GetLength(1);
            }

            return output;
        }

        private string[] TrasformaMatriceInArray(int[,] matriceVoti)
        {
            string[] output = new string[matriceVoti.GetLength(0)];

            for (int i = 0; i < matriceVoti.GetLength(0); i++)
            {
                for (int j = 0; j < matriceVoti.GetLength(1); j++)
                {
                    output[i] += Convert.ToString(matriceVoti[i, j]) + " ";
                }
            }
            return output;
        }

        private void RiempiMatrice(int[,] matriceVoti)
        {
            Random rnd = new Random();

            for (int i = 0; i < matriceVoti.GetLength(0); i++)
            {
                for (int j = 0; j < matriceVoti.GetLength(1); j++)
                {
                    matriceVoti[i, j] = rnd.Next(1, 11);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
