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
    public partial class ragister : Form
    {
        public ragister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)


        {


            string username = textBox1.Text;
            string name = textBox2.Text;
            string email = textBox3.Text;
            string pass = textBox4.Text;


            regencap x = new regencap();

            x.User = username;
            x.Password = pass;









            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30");


            string commandString = "INSERT INTO reg(username,password,email,name) VALUES('" + username.ToString() + "','" + pass.ToString() + "','" + email.ToString() + "','" + name.ToString() + "');";

            SqlCommand sqlCommand = new SqlCommand(commandString, con);

            con.Open();

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show(" Singin Completed");

            this.Hide();
            new coustomerlog().Show();

            con.Close();

        }
    }
}
