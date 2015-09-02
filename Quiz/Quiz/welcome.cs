using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void TakeQuiz_Click(object sender, EventArgs e)
        {
            select f3 = new select();
            f3.Show();
            this.Close();

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            login f1 = new login();
            MessageBox.Show("You have Logged out..!!");
            f1.Show();
            this.Close();

        }

        private void Instructions_Click(object sender, EventArgs e)
        {
            Instrct f7 = new Instrct();
            f7.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Opacity = 0;
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.3;
        }
    }
}
