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

namespace Bill.Coustomerlogin
{
    public partial class coustomerlog : Form
    {
        public coustomerlog()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this.Hide();

            // new Lodepage.leode().Show();

           


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30");


            con.Open();
            string userid = textBox1.Text;
            string password = textBox2.Text;


            logencap x = new logencap();

            x.User = userid;
            x.Password = password;

            SqlCommand cmd = new SqlCommand("select username,password from  reg where username='" + x.User + "'and password='" + x.Password + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to Homepage http://nsbm.lk");
                 this.Hide();

                 new Lodepage.leode().Show();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();



        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ragister().Show();
        }
    }


}
