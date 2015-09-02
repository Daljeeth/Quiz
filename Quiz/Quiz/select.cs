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
    public partial class select : Form
    {
        public select()
        {
            InitializeComponent();
        }

        private void Aptitude_Click(object sender, EventArgs e)
        {
            Aselect f8 = new Aselect();
            f8.Show();
            this.Hide();
            
       

        
        }

        private void Technical_Click(object sender, EventArgs e)
        {
            Tselect f9 = new Tselect();
            f9.Show();
            this.Hide();
        }

      

        private void Gk_Click_1(object sender, EventArgs e)
        {
            Gk f11 = new Gk();
            f11.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Opacity = 0;
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.07;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
