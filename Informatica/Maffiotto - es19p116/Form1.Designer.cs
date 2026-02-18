namespace Maffiotto___es19p116
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
            this.btnCerca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCantanti = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCanzoni = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(408, 153);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(253, 23);
            this.btnCerca.TabIndex = 0;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci il nome del cantante:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstCantanti
            // 
            this.lstCantanti.FormattingEnabled = true;
            this.lstCantanti.Location = new System.Drawing.Point(46, 61);
            this.lstCantanti.Name = "lstCantanti";
            this.lstCantanti.Size = new System.Drawing.Size(120, 316);
            this.lstCantanti.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantanti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Canzoni";
            // 
            // lstCanzoni
            // 
            this.lstCanzoni.FormattingEnabled = true;
            this.lstCanzoni.Location = new System.Drawing.Point(210, 61);
            this.lstCanzoni.Name = "lstCanzoni";
            this.lstCanzoni.Size = new System.Drawing.Size(120, 316);
            this.lstCanzoni.TabIndex = 4;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(561, 116);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCanzoni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCantanti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCantanti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCanzoni;
        private System.Windows.Forms.TextBox txtInput;
    }
}

