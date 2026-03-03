namespace Maffiotto___es26p116
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstAnimali = new System.Windows.Forms.ListBox();
            this.lstSpecie = new System.Windows.Forms.ListBox();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAnimali
            // 
            this.lstAnimali.FormattingEnabled = true;
            this.lstAnimali.Location = new System.Drawing.Point(12, 12);
            this.lstAnimali.Name = "lstAnimali";
            this.lstAnimali.Size = new System.Drawing.Size(120, 407);
            this.lstAnimali.TabIndex = 0;
            // 
            // lstSpecie
            // 
            this.lstSpecie.FormattingEnabled = true;
            this.lstSpecie.Location = new System.Drawing.Point(147, 12);
            this.lstSpecie.Name = "lstSpecie";
            this.lstSpecie.Size = new System.Drawing.Size(120, 407);
            this.lstSpecie.TabIndex = 1;
            // 
            // btnOrdina
            // 
            this.btnOrdina.Location = new System.Drawing.Point(12, 425);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(255, 23);
            this.btnOrdina.TabIndex = 2;
            this.btnOrdina.Text = "Ordina per Specie";
            this.btnOrdina.UseVisualStyleBackColor = true;
            this.btnOrdina.Click += new System.EventHandler(this.btnOrdina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrdina);
            this.Controls.Add(this.lstSpecie);
            this.Controls.Add(this.lstAnimali);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAnimali;
        private System.Windows.Forms.ListBox lstSpecie;
        private System.Windows.Forms.Button btnOrdina;
    }
}

