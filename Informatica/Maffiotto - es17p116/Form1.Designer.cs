namespace Maffiotto___es17p116
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.lstRisultato = new System.Windows.Forms.ListBox();
            this.lstCantanti = new System.Windows.Forms.ListBox();
            this.lstCanzoni = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci il nome del cantante:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(388, 55);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(239, 87);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(249, 23);
            this.btnCerca.TabIndex = 2;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // lstRisultato
            // 
            this.lstRisultato.FormattingEnabled = true;
            this.lstRisultato.Location = new System.Drawing.Point(239, 128);
            this.lstRisultato.Name = "lstRisultato";
            this.lstRisultato.Size = new System.Drawing.Size(249, 95);
            this.lstRisultato.TabIndex = 3;
            // 
            // lstCantanti
            // 
            this.lstCantanti.FormattingEnabled = true;
            this.lstCantanti.Location = new System.Drawing.Point(68, 87);
            this.lstCantanti.Name = "lstCantanti";
            this.lstCantanti.Size = new System.Drawing.Size(120, 95);
            this.lstCantanti.TabIndex = 4;
            // 
            // lstCanzoni
            // 
            this.lstCanzoni.FormattingEnabled = true;
            this.lstCanzoni.Location = new System.Drawing.Point(68, 248);
            this.lstCanzoni.Name = "lstCanzoni";
            this.lstCanzoni.Size = new System.Drawing.Size(120, 95);
            this.lstCanzoni.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista Cantanti";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista Canzoni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCanzoni);
            this.Controls.Add(this.lstCantanti);
            this.Controls.Add(this.lstRisultato);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.ListBox lstRisultato;
        private System.Windows.Forms.ListBox lstCantanti;
        private System.Windows.Forms.ListBox lstCanzoni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

