using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            int difficulty = 1;

            if (rbEasy.Checked)
            {
                difficulty = 1;
            }
            else if (rbHard.Checked)
            {
                difficulty = 3;
            }
            else if (rbINSANE.Checked)
            {
                difficulty = 20;
            }

            MainGame test = new MainGame(difficulty, txtPlayerName.Text);
            this.Hide();
            test.ShowDialog();
            this.Show();
        }
    }
}
