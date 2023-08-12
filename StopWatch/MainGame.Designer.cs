namespace StopWatch
{
    partial class MainGame
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
            this.components = new System.ComponentModel.Container();
            this.btnTestAttack = new System.Windows.Forms.Button();
            this.pnlPlayArea = new System.Windows.Forms.Panel();
            this.lblDialog = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.pbEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.AttackTimer = new System.Windows.Forms.Timer(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.pbHealthBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlPlayArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTestAttack
            // 
            this.btnTestAttack.Location = new System.Drawing.Point(476, 618);
            this.btnTestAttack.Name = "btnTestAttack";
            this.btnTestAttack.Size = new System.Drawing.Size(196, 60);
            this.btnTestAttack.TabIndex = 0;
            this.btnTestAttack.Text = "Attack";
            this.btnTestAttack.UseVisualStyleBackColor = true;
            this.btnTestAttack.Click += new System.EventHandler(this.btnTestAttack_Click);
            // 
            // pnlPlayArea
            // 
            this.pnlPlayArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlPlayArea.Controls.Add(this.lblDialog);
            this.pnlPlayArea.Controls.Add(this.lblDamage);
            this.pnlPlayArea.Controls.Add(this.pbEnemyHealth);
            this.pnlPlayArea.Font = new System.Drawing.Font("Segoe UI", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlPlayArea.Location = new System.Drawing.Point(12, 12);
            this.pnlPlayArea.Name = "pnlPlayArea";
            this.pnlPlayArea.Size = new System.Drawing.Size(988, 594);
            this.pnlPlayArea.TabIndex = 1;
            // 
            // lblDialog
            // 
            this.lblDialog.BackColor = System.Drawing.Color.Black;
            this.lblDialog.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDialog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDialog.Location = new System.Drawing.Point(114, 443);
            this.lblDialog.Name = "lblDialog";
            this.lblDialog.Padding = new System.Windows.Forms.Padding(10);
            this.lblDialog.Size = new System.Drawing.Size(787, 140);
            this.lblDialog.TabIndex = 2;
            this.lblDialog.Text = "label1";
            this.lblDialog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.ForeColor = System.Drawing.Color.Lime;
            this.lblDamage.Location = new System.Drawing.Point(377, 85);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(239, 100);
            this.lblDamage.TabIndex = 1;
            this.lblDamage.Text = "label1";
            // 
            // pbEnemyHealth
            // 
            this.pbEnemyHealth.Location = new System.Drawing.Point(114, 59);
            this.pbEnemyHealth.Name = "pbEnemyHealth";
            this.pbEnemyHealth.Size = new System.Drawing.Size(749, 23);
            this.pbEnemyHealth.TabIndex = 0;
            // 
            // MoveTimer
            // 
            this.MoveTimer.Enabled = true;
            this.MoveTimer.Interval = 50;
            this.MoveTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AttackTimer
            // 
            this.AttackTimer.Interval = 2500;
            this.AttackTimer.Tick += new System.EventHandler(this.AttackTimer_Tick);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(12, 618);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(300, 54);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label1";
            // 
            // pbHealthBar
            // 
            this.pbHealthBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pbHealthBar.ForeColor = System.Drawing.Color.DarkOrange;
            this.pbHealthBar.Location = new System.Drawing.Point(318, 636);
            this.pbHealthBar.Name = "pbHealthBar";
            this.pbHealthBar.Size = new System.Drawing.Size(100, 23);
            this.pbHealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbHealthBar.TabIndex = 3;
            this.pbHealthBar.Value = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Heal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1012, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbHealthBar);
            this.Controls.Add(this.btnTestAttack);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlPlayArea);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.pnlPlayArea.ResumeLayout(false);
            this.pnlPlayArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTestAttack;
        private Panel pnlPlayArea;
        private System.Windows.Forms.Timer MoveTimer;
        private Label lblHealth;
        private System.Windows.Forms.Timer AttackTimer;
        private Label lblName;
        private ProgressBar pbHealthBar;
        private Button button1;
        private ProgressBar pbEnemyHealth;
        private Label lblDamage;
        private Label lblDialog;
    }
}