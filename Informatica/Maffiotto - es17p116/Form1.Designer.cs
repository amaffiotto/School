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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

