namespace lesson
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvInventory = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            author = new DataGridViewTextBoxColumn();
            publicationYear = new DataGridViewTextBoxColumn();
            storageQty = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            BtnImport = new Button();
            BtnExport = new Button();
            ofdImport = new OpenFileDialog();
            sfdExport = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AllowUserToOrderColumns = true;
            dgvInventory.AllowUserToResizeColumns = false;
            dgvInventory.AllowUserToResizeRows = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { colName, author, publicationYear, storageQty, price });
            dgvInventory.Location = new Point(22, 26);
            dgvInventory.Margin = new Padding(6);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersWidth = 82;
            dgvInventory.Size = new Size(1055, 994);
            dgvInventory.TabIndex = 0;
            // 
            // colName
            // 
            colName.HeaderText = "Nome";
            colName.MinimumWidth = 10;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // author
            // 
            author.HeaderText = "Autore";
            author.MinimumWidth = 10;
            author.Name = "author";
            author.ReadOnly = true;
            // 
            // publicationYear
            // 
            publicationYear.HeaderText = "Anno di pubblicazione";
            publicationYear.MinimumWidth = 10;
            publicationYear.Name = "publicationYear";
            publicationYear.ReadOnly = true;
            // 
            // storageQty
            // 
            storageQty.HeaderText = "Quantità in magazzino";
            storageQty.MinimumWidth = 10;
            storageQty.Name = "storageQty";
            storageQty.ReadOnly = true;
            // 
            // price
            // 
            price.HeaderText = "Prezzo ($)";
            price.MinimumWidth = 10;
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // BtnImport
            // 
            BtnImport.Location = new Point(1088, 26);
            BtnImport.Margin = new Padding(6);
            BtnImport.Name = "BtnImport";
            BtnImport.Size = new Size(479, 96);
            BtnImport.TabIndex = 1;
            BtnImport.Text = "Importa Inventario";
            BtnImport.UseVisualStyleBackColor = true;
            BtnImport.Click += BtnImport_Click;
            // 
            // BtnExport
            // 
            BtnExport.Location = new Point(1088, 134);
            BtnExport.Margin = new Padding(6);
            BtnExport.Name = "BtnExport";
            BtnExport.Size = new Size(479, 96);
            BtnExport.TabIndex = 2;
            BtnExport.Text = "Exporta Inventario";
            BtnExport.UseVisualStyleBackColor = true;
            BtnExport.Click += BtnExport_Click;
            // 
            // ofdImport
            // 
            ofdImport.FileName = "inventory.txt";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1590, 1054);
            Controls.Add(BtnExport);
            Controls.Add(BtnImport);
            Controls.Add(dgvInventory);
            Margin = new Padding(6);
            Name = "FrmMain";
            Text = "Biblioteca - Quiet Edition (shhh...)";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInventory;
        private Button BtnImport;
        private Button BtnExport;
        private OpenFileDialog ofdImport;
        private SaveFileDialog sfdExport;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn publicationYear;
        private DataGridViewTextBoxColumn storageQty;
        private DataGridViewTextBoxColumn price;
    }
}