using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maffiotto___es22p116
{
    public partial class Form1 : Form
    {
        string[] cantanti = new string[30]
{
    "Alessandra Amoroso", "Angelina Mango", "Annalisa", "Annalisa", "Elodie",
    "Emma", "Geolier", "Geolier", "Giorgia", "Irama",
    "Jay-Z", "Jay-Z", "Kanye West", "Kanye West", "Lazza",
    "Lazza", "Ligabue", "Madame", "Marco Mengoni", "Pinguini Tattici",
    "Pinguini Tattici", "Playboi Carti", "Playboi Carti", "Sfera Ebbasta", "Tananai",
    "Tedua", "The Kolors", "Ultimo", "Vasco Rossi", "Zucchero"
};

        string[] canzoni = new string[30]
        {
    "Fino a qui", "La Noia", "Sinceramente", "Euforia", "Tribale",
    "Apnea", "I p' me, tu p' te", "L'ultima poesia", "Come Saprei", "Tu no",
    "Empire State of Mind", "The Story of O.J.", "Stronger", "Runaway", "Cenere",
    "100 Messaggi", "Certe Notti", "Marea", "Due Vite", "Pastello Bianco",
    "Ricordi", "Magnolia", "Sky", "Visiera a becco", "Veleno",
    "Red Light", "Un ragazzo una ragazza", "Piccola Stella", "Albachiara", "Baila"
        };

        int[] punteggi = new int[30];
        Random rnd = new Random();
        void BubbleSortEClassifica(int[] voti, string[] nomi, string[] brani)
        {
            int n = voti.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (voti[j] < voti[j + 1])
                    {
                        int tempVoto = voti[j];
                        voti[j] = voti[j + 1];
                        voti[j + 1] = tempVoto;

                        string tempNome = nomi[j];
                        nomi[j] = nomi[j + 1];
                        nomi[j + 1] = tempNome;

                        string tempBrano = brani[j];
                        brani[j] = brani[j + 1];
                        brani[j + 1] = tempBrano;
                    }
                }
            }

            int[] posizioni = new int[n];
            int rango = 1;

            for (int i = 0; i < n; i++)
            {
                if (i > 0 && voti[i] < voti[i - 1])
                {
                    rango++;
                }
                posizioni[i] = rango;
            }

            for (int i = 0; i < n; i++)
            {
                voti[i] = posizioni[i];
            }
        }
        public Form1()
        {
            InitializeComponent();
            lstCantanti.Items.AddRange(cantanti);
            lstCanzoni.Items.AddRange(canzoni);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstPunteggi.Items.Clear();
            lstHitparade.Items.Clear();
            for (int i = 0; i < punteggi.Length; i++)
            {
                punteggi[i] = rnd.Next(1, 51);
                lstPunteggi.Items.Add(punteggi[i]);
            }
            BubbleSortEClassifica(punteggi, cantanti, canzoni);
            for (int i = punteggi.Length - 1;i >= 0;i--)
            {
                lstHitparade.Items.Add($"{punteggi[i]} - {canzoni[i]} - {cantanti[i]}");
            }
        }
    }
}
