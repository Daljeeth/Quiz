using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;




namespace Quiz
{
    public partial class login : Form
    {
         public login()
        {
            InitializeComponent();
        }

         private void signin_Click(object sender, EventArgs e) 
         {
             try
             {
                 string myconn = @"server=192.168.0.1;Database=C:\USERS\DALJEET\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\QUIZ\QUIZ\DATABASE1.MDF;User Id=Daljeet;password=2015;Connect Timeout=30";
                 SqlConnection con = new SqlConnection(myconn);

                 string que = "Select * from student_info where username='" + this.username_txt.Text + "' and password='" + this.password_txt.Text + "'";
                 SqlCommand command = new SqlCommand(que, con);


                 SqlDataReader myReader;
                 con.Open();
                 myReader = command.ExecuteReader();
                 int count = 0;
                 while (myReader.Read())
                 {
                     count = count + 1;
                 }
                 if (count == 1)
                 {
                     welcome f2 = new welcome();
                     f2.Show();
                     this.Hide();
                 }
                 else if (count > 1)
                 {
                     MessageBox.Show("Duplicate username and password.. Access denied");

                 }
                 else
                     MessageBox.Show("Username and password is not correct.. Please try again");




                 con.Close();


             }
             catch (Exception Exception)
             {
                 MessageBox.Show(Exception.Message);
             }
         }

         private void Form1_Load(object sender, EventArgs e)
         {
             this.TopMost = true;
             this.FormBorderStyle = FormBorderStyle.None;
             this.WindowState = FormWindowState.Maximized;
             // Set Form's Transperancy 100 %
             this.Opacity = 0;

             // Start the Timer To Animate Form
             timer1.Enabled = true;
         }

        

         private void timer1_Tick(object sender, EventArgs e)
         {
             this.Opacity += 0.07;
         }

         private void exit_Click(object sender, EventArgs e)
         {
             Application.Exit();
         }
         
    }
}
