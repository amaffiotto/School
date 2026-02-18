namespace Maffiotto___es22p116
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
            this.lstCantanti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCanzoni = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPunteggi = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstHitparade = new System.Windows.Forms.ListBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCantanti
            // 
            this.lstCantanti.FormattingEnabled = true;
            this.lstCantanti.Location = new System.Drawing.Point(12, 43);
            this.lstCantanti.Name = "lstCantanti";
            this.lstCantanti.Size = new System.Drawing.Size(120, 264);
            this.lstCantanti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // lstCanzoni
            // 
            this.lstCanzoni.FormattingEnabled = true;
            this.lstCanzoni.Location = new System.Drawing.Point(138, 43);
            this.lstCanzoni.Name = "lstCanzoni";
            this.lstCanzoni.Size = new System.Drawing.Size(120, 264);
            this.lstCanzoni.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // lstPunteggi
            // 
            this.lstPunteggi.FormattingEnabled = true;
            this.lstPunteggi.Location = new System.Drawing.Point(264, 43);
            this.lstPunteggi.Name = "lstPunteggi";
            this.lstPunteggi.Size = new System.Drawing.Size(120, 264);
            this.lstPunteggi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // lstHitparade
            // 
            this.lstHitparade.FormattingEnabled = true;
            this.lstHitparade.Location = new System.Drawing.Point(390, 43);
            this.lstHitparade.Name = "lstHitparade";
            this.lstHitparade.Size = new System.Drawing.Size(237, 264);
            this.lstHitparade.TabIndex = 6;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(12, 314);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(615, 49);
            this.btnCerca.TabIndex = 8;
            this.btnCerca.Text = "Riempi Vettori e calcola hit parade";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstHitparade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPunteggi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCanzoni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCantanti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCantanti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCanzoni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPunteggi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstHitparade;
        private System.Windows.Forms.Button btnCerca;
    }
}

