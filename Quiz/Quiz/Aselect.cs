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
    public partial class Aselect : Form
    {
        public Aselect()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
           // this.Opacity = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aeasy f4 = new Aeasy();
            f4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Amedium f5 = new Amedium();
            f5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ahard f6 = new Ahard();
            f6.Show();
            this.Hide();
        }

       /* private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.07;
        }*/
    }
}
