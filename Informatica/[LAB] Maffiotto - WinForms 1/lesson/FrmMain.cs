using Timer = System.Threading.Timer;

namespace lesson
{
    public partial class FrmMain : Form
    {
        // variabili globali
        static string[] cards = { "berry.jpg", "cherry.jpg", "stars.png", "tree.jpg" };
        static string bomb = "bomb.jpg";

        // ci serve per posizionare le carte in maniera casuale
        static Random rnd = new Random();

        static int GRID_SIZE = 3;

        // stato di gioco
        int remainingErrors;
        int correctPairs;
        string[,] gameMatrix;

        PictureBox lastCard;

        public FrmMain()
        {
            InitializeComponent();
        }

        // logica di gioco

        public void ResetGame()
        {
            lastCard = null;
            remainingErrors = 3;
            correctPairs = 0;
            GenerateGameGrid();
        }

        private void GenerateGameGrid()
        {
            gameMatrix = new string[GRID_SIZE, GRID_SIZE];

            // prima metto la bomba in una cella casuale
            int x = rnd.Next(0, GRID_SIZE);
            int y = rnd.Next(0, GRID_SIZE);
            gameMatrix[x, y] = bomb;

            // successivamente scorro cards, e metto 2 volte la 
            // singola card in una posizione casuale libera.
            foreach (string card in cards)
            {
                for (int i = 0; i < 2; i++)
                {
                    // genero una singola card in una posizione
                    // casuale
                    do
                    {
                        x = rnd.Next(0, GRID_SIZE);
                        y = rnd.Next(0, GRID_SIZE);
                    }
                    // ripeto finché è occupata
                    while (gameMatrix[x, y] != null);

                    gameMatrix[x, y] = card;
                }
            }
        }

        private void FlipCard(PictureBox flippedCard)
        {

            int flippedX = flippedCard.Name[7] - '0'; // converto da carattere a intero
            int flippedY = flippedCard.Name[8] - '0'; // togliendo '0' -> 48

            // facciamo vedere la carta
            flippedCard.Load($"assets/img/{gameMatrix[flippedX, flippedY]}");

            // se è la bomba è auto-loss
            if (gameMatrix[flippedX, flippedY] == bomb)
            {
                // perso
                MessageBox.Show("Hai perso", "Memory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GameOver();

                // tutte le picturebox del form (modo 1)
                // calcola dal nome
                for (int i = 0; i < GRID_SIZE; i++)
                {
                    for (int j = 0; j < GRID_SIZE; j++)
                    {
                        PictureBox pcbCard = (PictureBox)Controls[$"PcbGrid{i}{j}"];
                        pcbCard.Enabled = false;
                    }
                }

                // tutte le picturebox del form (modo 2) - foreach
                // foreach (PictureBox pcb in Controls.OfType<PictureBox>())
                // {
                //    pcb.Enabled = false;
                // }
            }

            if (lastCard == null)
            {
                lastCard = flippedCard;
                lastCard.Enabled = false; // cosi non posso cliccarla
                                          // due volte
            }
            else
            {
                int lastX = lastCard.Name[7] - '0'; // converto da carattere a intero
                int lastY = lastCard.Name[8] - '0'; // togliendo '0' -> 48

                // do gia per scontato che flipped e last non siano nella stessa
                // posizione
                if (gameMatrix[flippedX, flippedY] == gameMatrix[lastX, lastY])
                {
                    // giusto, lo rendo permanente e vado avanti
                    flippedCard.Enabled = false;

                    correctPairs++;

                    if (correctPairs == cards.Length)
                    {
                        // vinto, perchè ho fatto una coppia per ogni carta
                        // quando ho fatto partire il gioco

                        MessageBox.Show("Hai Vinto", "Memory", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GameOver();
                        // tutte le picturebox del form (modo 1)
                        // calcola dal nome
                        

                        // tutte le picturebox del form (modo 2) - foreach
                        // foreach (PictureBox pcb in Controls.OfType<PictureBox>())
                        // {
                        //    pcb.Enabled = false;
                        // }
                    }
                }
                else
                {
                    // sbagliato, perdo un tentativo e ricopro dopo un intervallo
                    remainingErrors--;

                    LblRemainingErrors.Text = $"Errori rimanenti: {remainingErrors}";

                    if (remainingErrors == 0)
                    {
                        // perso
                        MessageBox.Show("Hai perso", "Memory", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // tutte le picturebox del form (modo 1)
                        // calcola dal nome
                        GameOver();

                        // tutte le picturebox del form (modo 2) - foreach
                        // foreach (PictureBox pcb in Controls.OfType<PictureBox>())
                        // {
                        //    pcb.Enabled = false;
                        // }
                    }
                    else
                    {
                        // attesa ...
                        Refresh();
                        Thread.Sleep(2000);

                        // ri-copro e riabilito tutto
                        lastCard.Image = null;
                        flippedCard.Image = null;

                        lastCard.Enabled = true;
                        flippedCard.Enabled = true;
                    }
                }

                // in ogni caso la coppia pescata viene resettata
                lastCard = null;
            }
        }

        private void GameOver()
        {
            BtnResetGame.Enabled = true;

            for (int i = 0; i < GRID_SIZE; i++)
            {
                for (int j = 0; j < GRID_SIZE; j++)
                {
                    PictureBox pcbCard = (PictureBox)Controls[$"PcbGrid{i}{j}"];
                    pcbCard.Enabled = false;
                }
            }
        }

        // rendering

        private void BtnResetGame_Click(object sender, EventArgs e)
        {
            ResetGame();   // logica di gioco
            ResetGameUI(); // logica di rendering
        }

        private void PcbCard_Click(object sender, EventArgs e)
        {
            PictureBox flippedCard = (PictureBox)sender;
            FlipCard(flippedCard);
            FlipCardUI(flippedCard);
        }

        private void ResetGameUI()
        {
            // quando comincia una nuova partita:
            // - disabilito il bottone nuova partita
            BtnResetGame.Enabled = false;
            // - inizializzo la label con il valore corretto
            LblRemainingErrors.Text = $"Errori rimanenti: {remainingErrors}";
            // - abilito tutte le picturebox
            for (int i = 0; i < GRID_SIZE; i++)
            {
                for (int j = 0; j < GRID_SIZE; j++)
                {
                    PictureBox pcbCard = (PictureBox)Controls[$"PcbGrid{i}{j}"];
                    pcbCard.Image = null;
                    pcbCard.Enabled = true;
                }
            }
            // - mostro la label
            LblRemainingErrors.Visible = true;
        }

        private void FlipCardUI(PictureBox flippedCard)
        {
            //throw new NotImplementedException();
        }
    }
}