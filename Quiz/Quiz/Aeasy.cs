using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Client.Education;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;




namespace Quiz
{
    public partial class Aeasy : Form
    {
    
        public Aeasy()
        {
            InitializeComponent();
        }
        int m = 20;
        int s = 0;
        int k = 0;
        int ps = 1;
        int x = 0;
        int[] index = new int[21];

        public void rd()
        {
            if (radioButton1.Checked == true)
            {
                index[x] = 1;
            }
            else if (radioButton2.Checked == true)
            {
                index[x] = 2;
            }
            else if (radioButton3.Checked == true)
            {
                index[x] = 3;
            }
            else if (radioButton4.Checked == true)
            {
                index[x] = 4;
            }
            else
            {
                index[x] = 0;
            }
            x = x + 1;
        }
        public void easy()
        {
            String myConnection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Daljeet\Documents\Visual Studio 2013\Projects\Quiz\Quiz\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection myconn = new SqlConnection(myConnection);

            myconn.Open();
            SqlCommand cmdDataBase1 = new SqlCommand("select * FROM aeasy;", myconn);
            SqlCommand cmdDataBase2 = new SqlCommand("insert into stats_tab (slno,question,opt1,opt2,opt3,opt4,Correct_Answer,Your_Answer) select * from aeasy WHERE (ABS(CAST((BINARY_CHECKSUM(sno,RAND())) as int)) % 100) < 30 and sno = sno;", myconn);
            SqlCommand cmdDataBase3 = new SqlCommand("select * from stats_tab;", myconn);

            try
            {

                SqlDataAdapter sda = new SqlDataAdapter(cmdDataBase3);
                cmdDataBase1.ExecuteNonQuery();
                cmdDataBase2.ExecuteNonQuery();

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Tables.Add(dt);
                sda.Fill(dt);

                foreach (DataRow myRow in dt.Rows)
                {
                    label1.Text = myRow[2].ToString();
                    radioButton1.Text = myRow[3].ToString();
                    radioButton2.Text = myRow[4].ToString();
                    radioButton3.Text = myRow[5].ToString();
                    radioButton4.Text = myRow[6].ToString();



                }
            }
            catch (Exception Exception)
            {
                MessageBox.Show(Exception.Message);
            }
            rd();
            myconn.Close();

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
            if(progressBar1.Value != 1200)
            {
                progressBar1.Value++;
            }
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == 0 && s == 0)
            {
                timer1.Stop();
                MessageBox.Show("TImes up!.");

            }

            String mm = Convert.ToString(m);
            String ss = Convert.ToString(s);

            label2.Text = mm;
            label4.Text = ss;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            String constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Daljeet\Documents\Visual Studio 2013\Projects\Quiz\Quiz\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            string Query = "select count(*) from stats_tab where stats_tab.Correct_Answer = stats_tab.Your_Answer ;";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmdDataBase2 = new SqlCommand(Query, con);
            con.Open();

            try
            {
                SqlDataAdapter sss = new SqlDataAdapter();

                sss.SelectCommand = cmdDataBase2;
                cmdDataBase2.ExecuteNonQuery();
                int count = Convert.ToInt32(cmdDataBase2.ExecuteScalar());



                MessageBox.Show("Your score is : " + count.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        


            con.Close();
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            insert();
            rd();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            ps = ps + 1;
            if (k <= 20)
            {
                k = k + 1;
                String myConnection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Daljeet\Documents\Visual Studio 2013\Projects\Quiz\Quiz\Database1.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection myconn = new SqlConnection(myConnection);

                myconn.Open();
                SqlCommand cmdDataBase1 = new SqlCommand("select * FROM stats_tab where sno = @sno;", myconn);
                cmdDataBase1.Parameters.AddWithValue("@sno", ps);
                try
                {

                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmdDataBase1;

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    ds.Tables.Add(dt);
                    sda.Fill(dt);


                    foreach (DataRow myRow in dt.Rows)
                    {

                        label1.Text = myRow[2].ToString();
                        radioButton1.Text = myRow[3].ToString();
                        radioButton2.Text = myRow[4].ToString();
                        radioButton3.Text = myRow[5].ToString();
                        radioButton4.Text = myRow[6].ToString();
                    }

                }

                catch (Exception Exception)
                {
                    MessageBox.Show(Exception.Message);
                }
                myconn.Close();
            }
            if (k == 20)
            {
                button2.Visible = false;
            }



        }



   

        private void button1_Click(object sender, EventArgs e)
        {
            ps = ps - 1;
            String myConnection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Daljeet\Documents\Visual Studio 2013\Projects\Quiz\Quiz\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection myconn = new SqlConnection(myConnection);

            myconn.Open();

            SqlCommand p1 = new SqlCommand("select * from stats_tab where sno = @sno;", myconn);
            p1.Parameters.AddWithValue("@sno", ps);


            try
            {


                SqlDataAdapter pp = new SqlDataAdapter();

                pp.SelectCommand = p1;

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Tables.Add(dt);
                pp.Fill(dt);


                foreach (DataRow myRow in dt.Rows)
                {

                    label1.Text = myRow[1].ToString();
                    radioButton1.Text = myRow[2].ToString();
                    radioButton2.Text = myRow[3].ToString();
                    radioButton3.Text = myRow[4].ToString();
                    radioButton4.Text = myRow[5].ToString();
                }





                if (index[ps] == 1)
                {
                    radioButton1.Checked = true;
                }
                if (index[ps] == 2)
                {
                    radioButton2.Checked = true;
                }
                if (index[ps] == 3)
                {
                    radioButton3.Checked = true;
                }
                if (index[ps] == 4)
                {
                    radioButton4.Checked = true;
                }
            }


            catch (Exception jk)
            {
                MessageBox.Show(jk.Message);
            } myconn.Close();
        }




        public void insert()
        {

            String myConnection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Daljeet\Documents\Visual Studio 2013\Projects\Quiz\Quiz\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection myconn1 = new SqlConnection(myConnection);

            myconn1.Open();
            try
            {
                SqlCommand c11 = new SqlCommand("select * stats_tab where slno=@slno;", myconn1);
                c11.Parameters.AddWithValue("@slno", ps);
                SqlCommand c1 = new SqlCommand("Update stats_tab set Your_Answer = @Your_Answer where slno = @slno  ;", myconn1);
                c1.Parameters.AddWithValue("@Your_Answer", radioButton1.Text);
                c1.Parameters.AddWithValue("@slno", ps);
                SqlCommand c2 = new SqlCommand("Update stats_tab set Your_Answer = @Your_Answer where slno = @slno ;", myconn1);
                c2.Parameters.AddWithValue("@Your_Answer", radioButton2.Text);
                c2.Parameters.AddWithValue("@slno", ps);
                SqlCommand c3 = new SqlCommand("Update stats_tab set Your_Answer = @Your_Answer where slno = @slno;", myconn1);
                c3.Parameters.AddWithValue("@Your_Answer", radioButton3.Text);
                c3.Parameters.AddWithValue("@slno", ps);
                SqlCommand c4 = new SqlCommand("UPdate stats_tab set Your_Answer = @Your_Answer where slno = @slno;", myconn1);
                c4.Parameters.AddWithValue("@Your_Answer", radioButton4.Text);
                c4.Parameters.AddWithValue("@slno", ps);


                SqlDataAdapter sa = new SqlDataAdapter(c11);
                DataSet ds1 = new DataSet();
                DataTable dt1 = new DataTable();

                if (radioButton1.Checked)
                {
                    sa.SelectCommand = c1;
                    ;
                    c1.ExecuteNonQuery();
                }

                else if (radioButton2.Checked)
                {
                    sa.SelectCommand = c2;

                    c2.ExecuteNonQuery();
                }

                else if (radioButton3.Checked)
                {
                    sa.SelectCommand = c3;

                    c3.ExecuteNonQuery();
                }
                else if (radioButton4.Checked)
                {
                    sa.SelectCommand = c4;

                    c4.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Question unanswered");
                }
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }


            myconn1.Close();
        }

        private void Aeasy_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
           

            timer1.Start();
            progressBar1.Maximum = 1200;

            easy();
        }

    
    
    
    }



}


             

        
            


    




        
            

         
    
                







       

      
        
      

        

       
        
    
   
            

   
       
           
        

       

      


        
    


