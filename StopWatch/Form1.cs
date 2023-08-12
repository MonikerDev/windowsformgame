using System.Diagnostics;

namespace StopWatch
{
    public partial class Form1 : Form
    {

        public static Stopwatch sw = new Stopwatch();
        public static Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sw.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sw.Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            sw.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = sw.Elapsed.ToString();

            if(random.Next(0,10) < 5)
            {
                btnTarget.Left = random.Next(0, this.Width);
                btnTarget.Top = random.Next(0,this.Height);
                btnTarget.Visible = true;
            }
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            (sender as Button).Visible = false;
        }
    }
}