using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StopWatch
{
    public partial class MainGame : Form
    {
        public static Stopwatch watch = new Stopwatch();
        public static System.Timers.Timer delayTimer = new System.Timers.Timer(1000);
        public static Random random = new Random();

        public int difficultyModifier;
        public string playerName;
        public int playerHealth = 100;
        public int enemyHealth;
        private int attackCount;
        public bool firstAttack = true;
        public bool finalAttack = false;
        int finalAttacks = 5;

        public DialogHandler dialog = new DialogHandler();

        public MainGame(int difficulty, string Name)
        {
            this.difficultyModifier = difficulty;
            this.playerName = Name;

            enemyHealth = 100 * difficultyModifier;

            InitializeComponent();

            lblName.Text = Name;
            lblName.TextAlign = ContentAlignment.MiddleCenter;

            pbEnemyHealth.Visible = false;
            lblDamage.Visible = false;

            lblDialog.Text = dialog.PullNextLine();

            watch.Start();

        }

        public void VerticalWallAttack()
        {
            int dir = random.Next(-1, 2);

            if (dir == 1)
            {
                int pelletCount = this.Height / 120;

                for (int i = 0; i < pelletCount; i++)
                {
                    Button temp = new Button();

                    temp.Width = 30;
                    temp.Height = 30;

                    temp.MouseEnter += PelletCollide;

                    pnlPlayArea.Controls.Add(temp);
                    temp.Location = new Point(0, (120 * i) + random.Next(120));
                    temp.Tag = "Pellet|Left|40";
                }
            }
            else if (dir == -1)
            {
                int pelletCount = this.Height / 120;

                for (int i = 0; i < pelletCount; i++)
                {
                    Button temp = new Button();

                    temp.Width = 30;
                    temp.Height = 30;

                    temp.MouseEnter += PelletCollide;

                    pnlPlayArea.Controls.Add(temp);
                    temp.Location = new Point(this.Width, (120 * i) + random.Next(120));
                    temp.Tag = "Pellet|Right|40";
                }
            }
            else
            {
                VerticalWallAttack();
            }
        }

        private void HorizontalWallAttack()
        {
            int dir = random.Next(-1, 2);

            if (dir == 1)
            {
                int pelletCount = this.Width / 120;

                for (int i = 0; i < pelletCount; i++)
                {
                    Button temp = new Button();

                    temp.Width = 30;
                    temp.Height = 30;

                    temp.MouseEnter += PelletCollide;

                    pnlPlayArea.Controls.Add(temp);
                    temp.Location = new Point((120 * i) + random.Next(120), 0);
                    temp.Tag = "Pellet|Down|40";
                }
            }
            else if (dir == -1)
            {
                int pelletCount = this.Width / 120;

                for (int i = 0; i < pelletCount; i++)
                {
                    Button temp = new Button();

                    temp.Width = 30;
                    temp.Height = 30;

                    temp.MouseEnter += PelletCollide;

                    pnlPlayArea.Controls.Add(temp);
                    temp.Location = new Point((120 * i) + random.Next(10), this.Height);
                    temp.Tag = "Pellet|Up|40";
                }
            }
            else
            {
                HorizontalWallAttack();
            }
        }

        public void CircleAroundAttack()
        {
            Point p = MousePosition;

            //Top Left Pellet
            Button temp = new Button();

            temp.Width = 30;
            temp.Height = 30;

            temp.MouseEnter += PelletCollide;

            pnlPlayArea.Controls.Add(temp);
            temp.Location = new Point(p.X - 240, p.Y - 240);
            temp.Tag = "Pellet|SouthWest|15";

            //Top middle pellet
            Button temp2 = new Button();

            temp2.Width = 30;
            temp2.Height = 30;

            temp2.MouseEnter += PelletCollide;

            pnlPlayArea.Controls.Add(temp2);
            temp2.Location = new Point(p.X, p.Y - 360);
            temp2.Tag = "Pellet|Down|20";

            //Top Right Pellet
            Button temp3 = new Button();

            temp3.Width = 30;
            temp3.Height = 30;

            temp3.MouseEnter += PelletCollide;

            pnlPlayArea.Controls.Add(temp3);
            temp3.Location = new Point(p.X + 240, p.Y - 240);
            temp3.Tag = "Pellet|SouthEast|15";

            //Left Pellet
            Button temp4 = new Button();

            temp4.Width = 30;
            temp4.Height = 30;

            temp4.MouseEnter += PelletCollide;

            pnlPlayArea.Controls.Add(temp4);
            temp4.Location = new Point(p.X - 360, p.Y);
            temp4.Tag = "Pellet|Left|20";

            //Right Pellet
            Button temp5 = new Button();

            temp5.Width = 30;
            temp5.Height = 30;

            temp5.MouseEnter += PelletCollide;

            pnlPlayArea.Controls.Add(temp5);
            temp5.Location = new Point(p.X + 360, p.Y);
            temp5.Tag = "Pellet|Right|20";

            //Bottom Left
            Button temp6 = new Button();

            temp6.Width = 30;
            temp6.Height = 30;

            temp6.MouseEnter += PelletCollide;

            pnlPlayArea.Controls.Add(temp6);
            temp6.Location = new Point(p.X - 240, p.Y + 240);
            temp6.Tag = "Pellet|NorthWest|15";

            //Bottom
            Button temp7 = new Button();

            temp7.Width = 30;
            temp7.Height = 30;

            temp7.MouseEnter += PelletCollide;

            pnlPlayArea.Controls.Add(temp7);
            temp7.Location = new Point(p.X, p.Y + 360);
            temp7.Tag = "Pellet|Up|20";

            //Bottom right
            Button temp8 = new Button();

            temp8.Width = 30;
            temp8.Height = 30;

            temp8.MouseEnter += PelletCollide;

            pnlPlayArea.Controls.Add(temp8);
            temp8.Location = new Point(p.X + 240, p.Y + 240);
            temp8.Tag = "Pellet|NorthEast|15";
        }

        public void SeekingPelletAttack()
        {
            int pelletCount = random.Next(5, 10);

            for (int i = 0; i < pelletCount; i++)
            {
                Point p = MousePosition;
                Point spawnPoint = new Point(random.Next(0, this.Width), random.Next(0, this.Height));
                string direction = "Right";
                int xdir = Math.Sign((spawnPoint.X - p.X));
                int ydir = Math.Sign((spawnPoint.Y - p.Y));

                if (xdir == -1 && ydir == -1)
                {
                    direction = "SouthWest";
                }
                else if (xdir == -1 && ydir == 1)
                {
                    direction = "NorthWest";
                }
                else if (xdir == 1 && ydir == -1)
                {
                    direction = "SouthEast";
                }
                else if (xdir == 1 && ydir == 1)
                {
                    direction = "NorthWest";
                }

                Button temp = new Button();

                temp.Width = 30;
                temp.Height = 30;

                temp.MouseEnter += PelletCollide;

                pnlPlayArea.Controls.Add(temp);
                temp.Location = spawnPoint;
                temp.Tag = "Pellet|" + direction + "|20";
            }


        }

        private void btnTestAttack_Click(object sender, EventArgs e)
        {
            attackCount = random.Next(5, 11);
            button1.Enabled = false;
            button1.Visible = false;
            btnTestAttack.Enabled = false;
            btnTestAttack.Visible = false;

            DealDamage();

            if(enemyHealth == 0)
            {
                finalAttack = true;
                lblDialog.Text = dialog.PullNextLine();
            }
            AttackTimer.Enabled = true;
        }

        private void PelletCollide(object sender, EventArgs e)
        {
            if (playerHealth - (5 * difficultyModifier) > 0)
            {
                playerHealth -= 5 * difficultyModifier;
            }
            else
            {
                playerHealth = 0;
            }

            pnlPlayArea.Controls.Remove((sender as Control));

            pbHealthBar.Value = playerHealth;

            if (playerHealth <= 0)
            {
                MessageBox.Show("You died");
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control control in pnlPlayArea.Controls)
            {
                if (control.Tag != null)
                {
                    string[] tagPieces = (control as Button).Tag.ToString().Split('|');
                    int speed = int.Parse(tagPieces[2]);
                    if (tagPieces[0] == "Pellet")
                    {
                        if (tagPieces[1] == "Left")
                        {
                            control.Left += speed;
                        }
                        else if (tagPieces[1] == "Right")
                        {
                            control.Left -= speed;
                        }
                        else if (tagPieces[1] == "Up")
                        {
                            control.Top -= speed;
                        }
                        else if (tagPieces[1] == "Down")
                        {
                            control.Top += speed;
                        }
                        else if (tagPieces[1] == "SouthWest")
                        {
                            control.Left += speed;
                            control.Top += speed;
                        }
                        else if (tagPieces[1] == "SouthEast")
                        {
                            control.Left -= speed;
                            control.Top += speed;
                        }
                        else if (tagPieces[1] == "NorthWest")
                        {
                            control.Left += speed;
                            control.Top -= speed;
                        }
                        else if (tagPieces[1] == "NorthEast")
                        {
                            control.Left -= speed;
                            control.Top -= speed;
                        }
                    }

                    if (control.Left < -360 || control.Left > (this.Width + 360)||
                        control.Top < -360 || control.Top > (this.Height + 360))
                    {
                        pnlPlayArea.Controls.Remove(control);
                    }
                }

            }

        }


        public void EnemyAttack()
        {
            int choice = random.Next(7);

            if (choice == 0)
            {
                VerticalWallAttack();
                HorizontalWallAttack();
            }
            if (choice == 1)
            {
                SeekingPelletAttack();
                SeekingPelletAttack();
            }
            if (choice == 2)
            {
                CircleAroundAttack();
                HorizontalWallAttack();
            }
            if (choice == 3)
            {
                SeekingPelletAttack();
                HorizontalWallAttack();
            }
            if (choice == 4)
            {
                CircleAroundAttack();
                VerticalWallAttack();
                HorizontalWallAttack();
            }
            if (choice == 5)
            {
                CircleAroundAttack();
                VerticalWallAttack();
            }
            if (choice == 6)
            {
                SeekingPelletAttack();
                VerticalWallAttack();
            }
        }

        private void AttackTimer_Tick(object sender, EventArgs e)
        {
            if(playerHealth > 0){

                if (lblDialog.Visible)
                {

                    lblDialog.Visible = false;
                }
                if (pbEnemyHealth.Visible)
                {
                    pbEnemyHealth.Visible = false;
                    lblDamage.Visible = false;
                }
                if (!finalAttack)
                {
                    if (attackCount > 0)
                    {
                        EnemyAttack();
                        attackCount--;
                    }
                    else
                    {
                        btnTestAttack.Enabled = true;
                        btnTestAttack.Visible = true;
                        button1.Enabled = true;
                        button1.Visible = true;

                        lblDialog.Text = dialog.PullFlavorText();
                        lblDialog.Visible = true;

                        AttackTimer.Enabled = false;
                    }

                }
                else
                {
                    if (finalAttacks > 0)
                    {
                        FinalAttack();
                        finalAttacks--;
                    }
                    else
                    {
                        finalAttacks = 0;
                        attackCount = 0;
                        AttackTimer.Enabled = false;
                        MoveTimer.Enabled = false;
                        MessageBox.Show("You managed to defeat Craigory, you won!");
                        this.Close();
                    }
                }
            }
            else
            {
                AttackTimer.Enabled = false;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(playerHealth + 10 < 100)
            {
                playerHealth += 10;
            }
            else
            {
                playerHealth = 100;
            }
            pbHealthBar.Value = playerHealth;

            attackCount = random.Next(5, 11);
            button1.Enabled = false;
            button1.Visible = false;
            btnTestAttack.Enabled = false;
            btnTestAttack.Visible = false;
            AttackTimer.Enabled = true;
        }

        private void DealDamage()
        {
            int damage = random.Next(15, 35);

            if (firstAttack)
            {
                lblDialog.Text = dialog.PullNextLine();
                firstAttack = false;
            }
            else
            {
                lblDialog.Text = "You swing your sword at Craigory " +
                    "for " + damage + " damage!";
            }

            lblDamage.Text = damage.ToString();
            lblDamage.Visible = true;

            if(enemyHealth - damage > 0)
            {
                enemyHealth -= damage;
            }
            else
            {
                enemyHealth = 0;
            }
            pbEnemyHealth.Visible = true;
            pbEnemyHealth.Value = enemyHealth / difficultyModifier;
        }

        public void FinalAttack()
        {
            int choice = random.Next(4);

            if(choice == 0)
            {
                HorizontalWallAttack();
                VerticalWallAttack();
                CircleAroundAttack();
            }
            else if(choice == 1)
            {
                SeekingPelletAttack();
                CircleAroundAttack();
                SeekingPelletAttack();
            }
            else if(choice == 2)
            {
                VerticalWallAttack();
                VerticalWallAttack();
                HorizontalWallAttack();
            }
            else if(choice == 3)
            {
                SeekingPelletAttack();
                SeekingPelletAttack();
                SeekingPelletAttack();
            }
        }
    }
}
