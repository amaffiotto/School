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
            BtnResetGame = new Button();
            LblRemainingErrors = new Label();
            PcbGrid00 = new PictureBox();
            PcbGrid01 = new PictureBox();
            PcbGrid02 = new PictureBox();
            PcbGrid12 = new PictureBox();
            PcbGrid11 = new PictureBox();
            PcbGrid10 = new PictureBox();
            PcbGrid22 = new PictureBox();
            PcbGrid21 = new PictureBox();
            PcbGrid20 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PcbGrid00).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid02).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid20).BeginInit();
            SuspendLayout();
            // 
            // BtnResetGame
            // 
            BtnResetGame.Cursor = Cursors.Hand;
            BtnResetGame.Location = new Point(368, 7);
            BtnResetGame.Margin = new Padding(2);
            BtnResetGame.Name = "BtnResetGame";
            BtnResetGame.Size = new Size(111, 44);
            BtnResetGame.TabIndex = 0;
            BtnResetGame.Text = "NUOVA PARTITA";
            BtnResetGame.UseVisualStyleBackColor = true;
            BtnResetGame.Click += BtnResetGame_Click;
            // 
            // LblRemainingErrors
            // 
            LblRemainingErrors.AutoSize = true;
            LblRemainingErrors.Location = new Point(368, 64);
            LblRemainingErrors.Margin = new Padding(2, 0, 2, 0);
            LblRemainingErrors.Name = "LblRemainingErrors";
            LblRemainingErrors.Size = new Size(104, 15);
            LblRemainingErrors.TabIndex = 1;
            LblRemainingErrors.Text = "Errori Rimanenti: 3";
            LblRemainingErrors.Visible = false;
            // 
            // PcbGrid00
            // 
            PcbGrid00.BackColor = Color.White;
            PcbGrid00.BorderStyle = BorderStyle.FixedSingle;
            PcbGrid00.Cursor = Cursors.Hand;
            PcbGrid00.Enabled = false;
            PcbGrid00.Location = new Point(10, 7);
            PcbGrid00.Margin = new Padding(2);
            PcbGrid00.Name = "PcbGrid00";
            PcbGrid00.Size = new Size(106, 117);
            PcbGrid00.SizeMode = PictureBoxSizeMode.StretchImage;
            PcbGrid00.TabIndex = 2;
            PcbGrid00.TabStop = false;
            PcbGrid00.Click += PcbCard_Click;
            // 
            // PcbGrid01
            // 
            PcbGrid01.BackColor = Color.White;
            PcbGrid01.BorderStyle = BorderStyle.FixedSingle;
            PcbGrid01.Cursor = Cursors.Hand;
            PcbGrid01.Enabled = false;
            PcbGrid01.Location = new Point(120, 7);
            PcbGrid01.Margin = new Padding(2);
            PcbGrid01.Name = "PcbGrid01";
            PcbGrid01.Size = new Size(106, 117);
            PcbGrid01.SizeMode = PictureBoxSizeMode.StretchImage;
            PcbGrid01.TabIndex = 3;
            PcbGrid01.TabStop = false;
            PcbGrid01.Click += PcbCard_Click;
            // 
            // PcbGrid02
            // 
            PcbGrid02.BackColor = Color.White;
            PcbGrid02.BorderStyle = BorderStyle.FixedSingle;
            PcbGrid02.Cursor = Cursors.Hand;
            PcbGrid02.Enabled = false;
            PcbGrid02.Location = new Point(229, 7);
            PcbGrid02.Margin = new Padding(2);
            PcbGrid02.Name = "PcbGrid02";
            PcbGrid02.Size = new Size(106, 117);
            PcbGrid02.SizeMode = PictureBoxSizeMode.StretchImage;
            PcbGrid02.TabIndex = 4;
            PcbGrid02.TabStop = false;
            PcbGrid02.Click += PcbCard_Click;
            // 
            // PcbGrid12
            // 
            PcbGrid12.BackColor = Color.White;
            PcbGrid12.BorderStyle = BorderStyle.FixedSingle;
            PcbGrid12.Cursor = Cursors.Hand;
            PcbGrid12.Enabled = false;
            PcbGrid12.Location = new Point(229, 127);
            PcbGrid12.Margin = new Padding(2);
            PcbGrid12.Name = "PcbGrid12";
            PcbGrid12.Size = new Size(106, 117);
            PcbGrid12.SizeMode = PictureBoxSizeMode.StretchImage;
            PcbGrid12.TabIndex = 7;
            PcbGrid12.TabStop = false;
            PcbGrid12.Click += PcbCard_Click;
            // 
            // PcbGrid11
            // 
            PcbGrid11.BackColor = Color.White;
            PcbGrid11.BorderStyle = BorderStyle.FixedSingle;
            PcbGrid11.Cursor = Cursors.Hand;
            PcbGrid11.Enabled = false;
            PcbGrid11.Location = new Point(120, 127);
            PcbGrid11.Margin = new Padding(2);
            PcbGrid11.Name = "PcbGrid11";
            PcbGrid11.Size = new Size(106, 117);
            PcbGrid11.SizeMode = PictureBoxSizeMode.StretchImage;
            PcbGrid11.TabIndex = 6;
            PcbGrid11.TabStop = false;
            PcbGrid11.Click += PcbCard_Click;
            // 
            // PcbGrid10
            // 
            PcbGrid10.BackColor = Color.White;
            PcbGrid10.BorderStyle = BorderStyle.FixedSingle;
            PcbGrid10.Cursor = Cursors.Hand;
            PcbGrid10.Enabled = false;
            PcbGrid10.Location = new Point(10, 127);
            PcbGrid10.Margin = new Padding(2);
            PcbGrid10.Name = "PcbGrid10";
            PcbGrid10.Size = new Size(106, 117);
            PcbGrid10.SizeMode = PictureBoxSizeMode.StretchImage;
            PcbGrid10.TabIndex = 5;
            PcbGrid10.TabStop = false;
            PcbGrid10.Click += PcbCard_Click;
            // 
            // PcbGrid22
            // 
            PcbGrid22.BackColor = Color.White;
            PcbGrid22.BorderStyle = BorderStyle.FixedSingle;
            PcbGrid22.Cursor = Cursors.Hand;
            PcbGrid22.Enabled = false;
            PcbGrid22.Location = new Point(229, 247);
            PcbGrid22.Margin = new Padding(2);
            PcbGrid22.Name = "PcbGrid22";
            PcbGrid22.Size = new Size(106, 117);
            PcbGrid22.SizeMode = PictureBoxSizeMode.StretchImage;
            PcbGrid22.TabIndex = 10;
            PcbGrid22.TabStop = false;
            PcbGrid22.Click += PcbCard_Click;
            // 
            // PcbGrid21
            // 
            PcbGrid21.BackColor = Color.White;
            PcbGrid21.BorderStyle = BorderStyle.FixedSingle;
            PcbGrid21.Cursor = Cursors.Hand;
            PcbGrid21.Enabled = false;
            PcbGrid21.Location = new Point(120, 247);
            PcbGrid21.Margin = new Padding(2);
            PcbGrid21.Name = "PcbGrid21";
            PcbGrid21.Size = new Size(106, 117);
            PcbGrid21.SizeMode = PictureBoxSizeMode.StretchImage;
            PcbGrid21.TabIndex = 9;
            PcbGrid21.TabStop = false;
            PcbGrid21.Click += PcbCard_Click;
            // 
            // PcbGrid20
            // 
            PcbGrid20.BackColor = Color.White;
            PcbGrid20.BorderStyle = BorderStyle.FixedSingle;
            PcbGrid20.Cursor = Cursors.Hand;
            PcbGrid20.Enabled = false;
            PcbGrid20.Location = new Point(10, 247);
            PcbGrid20.Margin = new Padding(2);
            PcbGrid20.Name = "PcbGrid20";
            PcbGrid20.Size = new Size(106, 117);
            PcbGrid20.SizeMode = PictureBoxSizeMode.StretchImage;
            PcbGrid20.TabIndex = 8;
            PcbGrid20.TabStop = false;
            PcbGrid20.Click += PcbCard_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 371);
            Controls.Add(PcbGrid22);
            Controls.Add(PcbGrid21);
            Controls.Add(PcbGrid20);
            Controls.Add(PcbGrid12);
            Controls.Add(PcbGrid11);
            Controls.Add(PcbGrid10);
            Controls.Add(PcbGrid02);
            Controls.Add(PcbGrid01);
            Controls.Add(PcbGrid00);
            Controls.Add(LblRemainingErrors);
            Controls.Add(BtnResetGame);
            Name = "FrmMain";
            Text = "Memory";
            ((System.ComponentModel.ISupportInitialize)PcbGrid00).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid01).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid02).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid12).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid11).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid10).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid22).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid21).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbGrid20).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button BtnResetGame;
        private Label LblRemainingErrors;
        private PictureBox PcbGrid00;
        private PictureBox PcbGrid01;
        private PictureBox PcbGrid02;
        private PictureBox PcbGrid12;
        private PictureBox PcbGrid11;
        private PictureBox PcbGrid10;
        private PictureBox PcbGrid22;
        private PictureBox PcbGrid21;
        private PictureBox PcbGrid20;
    }
}