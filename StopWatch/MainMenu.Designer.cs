namespace StopWatch
{
    partial class MainMenu
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.gbDifficulties = new System.Windows.Forms.GroupBox();
            this.rbINSANE = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.gbDifficulties.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(173, 258);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(173, 37);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(174, 23);
            this.txtPlayerName.TabIndex = 1;
            // 
            // gbDifficulties
            // 
            this.gbDifficulties.Controls.Add(this.rbINSANE);
            this.gbDifficulties.Controls.Add(this.rbHard);
            this.gbDifficulties.Controls.Add(this.rbEasy);
            this.gbDifficulties.Location = new System.Drawing.Point(58, 82);
            this.gbDifficulties.Name = "gbDifficulties";
            this.gbDifficulties.Size = new System.Drawing.Size(289, 154);
            this.gbDifficulties.TabIndex = 2;
            this.gbDifficulties.TabStop = false;
            this.gbDifficulties.Text = "Difficulty";
            // 
            // rbINSANE
            // 
            this.rbINSANE.AutoSize = true;
            this.rbINSANE.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rbINSANE.ForeColor = System.Drawing.Color.Red;
            this.rbINSANE.Location = new System.Drawing.Point(34, 117);
            this.rbINSANE.Name = "rbINSANE";
            this.rbINSANE.Size = new System.Drawing.Size(69, 19);
            this.rbINSANE.TabIndex = 2;
            this.rbINSANE.Text = "INSANE";
            this.rbINSANE.UseVisualStyleBackColor = true;
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Location = new System.Drawing.Point(34, 72);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(51, 19);
            this.rbHard.TabIndex = 1;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Checked = true;
            this.rbEasy.Location = new System.Drawing.Point(34, 27);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(48, 19);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Location = new System.Drawing.Point(58, 40);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(96, 15);
            this.lblCharacterName.TabIndex = 3;
            this.lblCharacterName.Text = "Character Name:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 326);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.gbDifficulties);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnStartGame);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.gbDifficulties.ResumeLayout(false);
            this.gbDifficulties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStartGame;
        private TextBox txtPlayerName;
        private GroupBox gbDifficulties;
        private RadioButton rbINSANE;
        private RadioButton rbHard;
        private RadioButton rbEasy;
        private Label lblCharacterName;
    }
}