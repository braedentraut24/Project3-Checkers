namespace Project3_Checkers
{
    partial class DriverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblHorizBar = new System.Windows.Forms.Label();
            this.lblP1Name = new System.Windows.Forms.Label();
            this.txtP1Name = new System.Windows.Forms.TextBox();
            this.lblP1Char = new System.Windows.Forms.Label();
            this.txtP1Char = new System.Windows.Forms.TextBox();
            this.lblP2Name = new System.Windows.Forms.Label();
            this.txtP2Name = new System.Windows.Forms.TextBox();
            this.lblP2Char = new System.Windows.Forms.Label();
            this.txtP2Char = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(262, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(261, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Checkers!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthors.Location = new System.Drawing.Point(163, 50);
            this.lblAuthors.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(496, 29);
            this.lblAuthors.TabIndex = 1;
            this.lblAuthors.Text = "Written by Braeden Trautz and Colin Gilchrist";
            this.lblAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(9, 95);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(769, 29);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Enter names below, and chose a letter or symbol to represent your pieces.";
            // 
            // lblHorizBar
            // 
            this.lblHorizBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHorizBar.Location = new System.Drawing.Point(0, 87);
            this.lblHorizBar.Name = "lblHorizBar";
            this.lblHorizBar.Size = new System.Drawing.Size(2000, 2);
            this.lblHorizBar.TabIndex = 2;
            // 
            // lblP1Name
            // 
            this.lblP1Name.AutoSize = true;
            this.lblP1Name.Font = new System.Drawing.Font("Constantia", 11F);
            this.lblP1Name.Location = new System.Drawing.Point(12, 174);
            this.lblP1Name.Name = "lblP1Name";
            this.lblP1Name.Size = new System.Drawing.Size(128, 23);
            this.lblP1Name.TabIndex = 4;
            this.lblP1Name.Text = "Player 1 Name:";
            // 
            // txtP1Name
            // 
            this.txtP1Name.Font = new System.Drawing.Font("Constantia", 11F);
            this.txtP1Name.Location = new System.Drawing.Point(168, 171);
            this.txtP1Name.MaxLength = 25;
            this.txtP1Name.Name = "txtP1Name";
            this.txtP1Name.Size = new System.Drawing.Size(279, 30);
            this.txtP1Name.TabIndex = 5;
            this.txtP1Name.WordWrap = false;
            // 
            // lblP1Char
            // 
            this.lblP1Char.AutoSize = true;
            this.lblP1Char.Font = new System.Drawing.Font("Constantia", 11F);
            this.lblP1Char.Location = new System.Drawing.Point(466, 174);
            this.lblP1Char.Name = "lblP1Char";
            this.lblP1Char.Size = new System.Drawing.Size(141, 23);
            this.lblP1Char.TabIndex = 6;
            this.lblP1Char.Text = "Player 1 Symbol:";
            // 
            // txtP1Char
            // 
            this.txtP1Char.Font = new System.Drawing.Font("Constantia", 11F);
            this.txtP1Char.Location = new System.Drawing.Point(638, 171);
            this.txtP1Char.MaxLength = 1;
            this.txtP1Char.Name = "txtP1Char";
            this.txtP1Char.Size = new System.Drawing.Size(70, 30);
            this.txtP1Char.TabIndex = 7;
            this.txtP1Char.WordWrap = false;
            // 
            // lblP2Name
            // 
            this.lblP2Name.AutoSize = true;
            this.lblP2Name.Font = new System.Drawing.Font("Constantia", 11F);
            this.lblP2Name.Location = new System.Drawing.Point(12, 246);
            this.lblP2Name.Name = "lblP2Name";
            this.lblP2Name.Size = new System.Drawing.Size(131, 23);
            this.lblP2Name.TabIndex = 8;
            this.lblP2Name.Text = "Player 2 Name:";
            // 
            // txtP2Name
            // 
            this.txtP2Name.Font = new System.Drawing.Font("Constantia", 11F);
            this.txtP2Name.Location = new System.Drawing.Point(168, 243);
            this.txtP2Name.MaxLength = 25;
            this.txtP2Name.Name = "txtP2Name";
            this.txtP2Name.Size = new System.Drawing.Size(279, 30);
            this.txtP2Name.TabIndex = 9;
            this.txtP2Name.WordWrap = false;
            // 
            // lblP2Char
            // 
            this.lblP2Char.AutoSize = true;
            this.lblP2Char.Font = new System.Drawing.Font("Constantia", 11F);
            this.lblP2Char.Location = new System.Drawing.Point(466, 246);
            this.lblP2Char.Name = "lblP2Char";
            this.lblP2Char.Size = new System.Drawing.Size(144, 23);
            this.lblP2Char.TabIndex = 10;
            this.lblP2Char.Text = "Player 2 Symbol:";
            // 
            // txtP2Char
            // 
            this.txtP2Char.Font = new System.Drawing.Font("Constantia", 11F);
            this.txtP2Char.Location = new System.Drawing.Point(638, 243);
            this.txtP2Char.MaxLength = 1;
            this.txtP2Char.Name = "txtP2Char";
            this.txtP2Char.Size = new System.Drawing.Size(70, 30);
            this.txtP2Char.TabIndex = 11;
            this.txtP2Char.WordWrap = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Lime;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Location = new System.Drawing.Point(12, 353);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(240, 60);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "Let\'s Play!";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(530, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(240, 60);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DriverForm
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(782, 425);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtP2Char);
            this.Controls.Add(this.lblP2Char);
            this.Controls.Add(this.txtP2Name);
            this.Controls.Add(this.lblP2Name);
            this.Controls.Add(this.txtP1Char);
            this.Controls.Add(this.lblP1Char);
            this.Controls.Add(this.txtP1Name);
            this.Controls.Add(this.lblP1Name);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblHorizBar);
            this.Controls.Add(this.lblAuthors);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkers in C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblHorizBar;
        private System.Windows.Forms.Label lblP1Name;
        private System.Windows.Forms.TextBox txtP1Name;
        private System.Windows.Forms.Label lblP1Char;
        private System.Windows.Forms.TextBox txtP1Char;
        private System.Windows.Forms.Label lblP2Name;
        private System.Windows.Forms.TextBox txtP2Name;
        private System.Windows.Forms.Label lblP2Char;
        private System.Windows.Forms.TextBox txtP2Char;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
    }
}

