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
    public partial class Tselect : Form
    {
        public Tselect()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teasy te = new Teasy();
            te.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tmedium tm = new Tmedium();
            tm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thard th = new Thard();
            th.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
