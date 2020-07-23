using System;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bill
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30");

            string user = textBox4.Text;
            string pass = textBox2.Text;

            userlog.userencapsulationu x = new userlog.userencapsulationu();
            x.User = user;
            x.Password = pass;


            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='" + x.User + "' AND password='" + x.Password + "'", con);

                con.Close();
               
                this.Hide();
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {


                    MessageBox.Show(" Username and Password Correct!");

                    this.Hide();
                    new home().Show();




                }
                else
                    MessageBox.Show("Invalid username or password");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Properties.coutomerlog().Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
