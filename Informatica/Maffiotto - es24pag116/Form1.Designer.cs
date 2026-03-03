namespace Maffiotto___es24pag116
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAnimali
            // 
            this.lstAnimali.FormattingEnabled = true;
            this.lstAnimali.Location = new System.Drawing.Point(12, 39);
            this.lstAnimali.Name = "lstAnimali";
            this.lstAnimali.Size = new System.Drawing.Size(120, 329);
            this.lstAnimali.TabIndex = 0;
            // 
            // lstSpecie
            // 
            this.lstSpecie.FormattingEnabled = true;
            this.lstSpecie.Location = new System.Drawing.Point(138, 39);
            this.lstSpecie.Name = "lstSpecie";
            this.lstSpecie.Size = new System.Drawing.Size(120, 329);
            this.lstSpecie.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(12, 400);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(246, 50);
            this.btnCerca.TabIndex = 3;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstSpecie);
            this.Controls.Add(this.lstAnimali);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAnimali;
        private System.Windows.Forms.ListBox lstSpecie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCerca;
    }
}

