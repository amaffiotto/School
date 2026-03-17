using lesson;

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
        string[,] gameMatrix;

        PictureBox lastCard;

        public FrmMain()
        {
            InitializeComponent();
        }

        // logica di gioco

        public void ResetGame()
        {
            remainingErrors = 3;
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
                }
            }
        }

        private void FlipCard(PictureBox flippedCard)
        {
            if (lastCard == null)
            {
                lastCard = flippedCard;
            }
            else
            {
                int flippedX = flippedCard.Name[7] - '0';
                int flippedY = flippedCard.Name[8] - '0';

                int lastX = flippedCard.Name[7] - '0';
                int lastY = flippedCard.Name[8] - '0';
                if (gameMatrix[flippedX, flippedY] == gameMatrix[lastX, lastY])
                {

                }
            }

        }


        // rendering

        private void BtnResetGame_Click(object sender, EventArgs e)
        {
            lastCard = null;
            ResetGame();   // logica di gioco
            ResetGameUI(); // logica di rendering
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





        // FUNZIONI PER SBAGLIO
        private void FrmMain_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}