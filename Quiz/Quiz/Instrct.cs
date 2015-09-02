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
    public partial class Instrct : Form
    {
        public Instrct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcome f2 = new welcome();
            f2.Show();
            this.Close();
        }

      

        private void Form7_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
           // this.Opacity = 0;        
        }

     

      /*  private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.07;
        }

        */
    }
}
