using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            
            
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Daljeet\Documents\Visual Studio 2013\Projects\Quiz\Quiz\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand("select slno,Question,Correct_Answer,Your_Answer from stats_tab;", conDataBase);
            conDataBase.Open();
            try
            {
                SqlDataAdapter dd = new SqlDataAdapter();
                dd.SelectCommand = cmdDataBase;
                DataTable dtd = new DataTable();
                dd.Fill(dtd);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dtd;
                dataGridView1.DataSource = bsource;
                dd.Update(dtd);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conDataBase.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Daljeet\Documents\Visual Studio 2013\Projects\Quiz\Quiz\Database1.mdf;Integrated Security=True;Connect Timeout=30";
           
            SqlConnection con = new SqlConnection(constring);
          
            con.Open();
            SqlCommand sd = new SqlCommand("truncate table stats_tab;", con);
            sd.ExecuteNonQuery();
            con.Close();
            Application.Exit();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
