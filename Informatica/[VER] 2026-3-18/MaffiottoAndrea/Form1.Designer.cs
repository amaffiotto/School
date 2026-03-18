namespace MaffiottoAndrea
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
            this.lstStudenti = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstVoti = new System.Windows.Forms.ListBox();
            this.lblStudenti = new System.Windows.Forms.Label();
            this.lblVoti = new System.Windows.Forms.Label();
            this.lblRis = new System.Windows.Forms.Label();
            this.lstRisultato = new System.Windows.Forms.ListBox();
            this.txtNinput = new System.Windows.Forms.TextBox();
            this.txtCinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstStudenti
            // 
            this.lstStudenti.FormattingEnabled = true;
            this.lstStudenti.Location = new System.Drawing.Point(46, 48);
            this.lstStudenti.Name = "lstStudenti";
            this.lstStudenti.Size = new System.Drawing.Size(120, 238);
            this.lstStudenti.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1046, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Genera voti calcola media e visualizza risultato";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstVoti
            // 
            this.lstVoti.FormattingEnabled = true;
            this.lstVoti.Location = new System.Drawing.Point(172, 48);
            this.lstVoti.Name = "lstVoti";
            this.lstVoti.Size = new System.Drawing.Size(120, 238);
            this.lstVoti.TabIndex = 2;
            // 
            // lblStudenti
            // 
            this.lblStudenti.AutoSize = true;
            this.lblStudenti.Location = new System.Drawing.Point(46, 29);
            this.lblStudenti.Name = "lblStudenti";
            this.lblStudenti.Size = new System.Drawing.Size(49, 13);
            this.lblStudenti.TabIndex = 3;
            this.lblStudenti.Text = "Studenti:";
            this.lblStudenti.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVoti
            // 
            this.lblVoti.AutoSize = true;
            this.lblVoti.Location = new System.Drawing.Point(172, 28);
            this.lblVoti.Name = "lblVoti";
            this.lblVoti.Size = new System.Drawing.Size(28, 13);
            this.lblVoti.TabIndex = 4;
            this.lblVoti.Text = "Voti:";
            // 
            // lblRis
            // 
            this.lblRis.AutoSize = true;
            this.lblRis.Location = new System.Drawing.Point(298, 28);
            this.lblRis.Name = "lblRis";
            this.lblRis.Size = new System.Drawing.Size(51, 13);
            this.lblRis.TabIndex = 6;
            this.lblRis.Text = "Risultato:";
            // 
            // lstRisultato
            // 
            this.lstRisultato.FormattingEnabled = true;
            this.lstRisultato.Location = new System.Drawing.Point(298, 48);
            this.lstRisultato.Name = "lstRisultato";
            this.lstRisultato.Size = new System.Drawing.Size(794, 238);
            this.lstRisultato.TabIndex = 5;
            // 
            // txtNinput
            // 
            this.txtNinput.Location = new System.Drawing.Point(1098, 64);
            this.txtNinput.Name = "txtNinput";
            this.txtNinput.Size = new System.Drawing.Size(100, 20);
            this.txtNinput.TabIndex = 7;
            // 
            // txtCinput
            // 
            this.txtCinput.Location = new System.Drawing.Point(1097, 108);
            this.txtCinput.Name = "txtCinput";
            this.txtCinput.Size = new System.Drawing.Size(100, 20);
            this.txtCinput.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1098, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inserire N (max 20)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1097, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Inserire C:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCinput);
            this.Controls.Add(this.txtNinput);
            this.Controls.Add(this.lblRis);
            this.Controls.Add(this.lstRisultato);
            this.Controls.Add(this.lblVoti);
            this.Controls.Add(this.lblStudenti);
            this.Controls.Add(this.lstVoti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstStudenti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudenti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstVoti;
        private System.Windows.Forms.Label lblStudenti;
        private System.Windows.Forms.Label lblVoti;
        private System.Windows.Forms.Label lblRis;
        private System.Windows.Forms.ListBox lstRisultato;
        private System.Windows.Forms.TextBox txtNinput;
        private System.Windows.Forms.TextBox txtCinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

