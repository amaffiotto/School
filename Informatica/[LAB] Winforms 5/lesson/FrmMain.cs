using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace lesson
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// Struct to represent a book in the inventory.
        /// </summary>
        struct InventoryBook
        {
            public string name;
            public string author;
            public int year;
            public int quantity;
            public double price;
        }

        OpenFileDialog ofd;
        SaveFileDialog sfd;
        public FrmMain()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            sfd = new SaveFileDialog();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        var row = sr.ReadLine().Split(',');
                        dgvInventory.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                    }
                }
                MessageBox.Show("Import completato con successo", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Export completato con successo", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            var result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (DataGridViewRow row in dgvInventory.Rows)
                    {
                            string nome = row.Cells[0].Value.ToString();
                            string autore = row.Cells[1].Value.ToString();
                            string anno = row.Cells[2].Value.ToString();
                            string qta = row.Cells[3].Value.ToString();
                            string prezzo = row.Cells[4].Value.ToString();

                            sw.WriteLine($"{nome},{autore},{anno},{qta},{prezzo}");
                    }
                }
                MessageBox.Show("Export completato con successo","Successo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nessun percorso selezionato","Errore",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
