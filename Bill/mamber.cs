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

namespace Bill
{
    public partial class mamber : Form

    {
        
      

        public mamber()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30");
            string qu ="INSERT INTO smember( name, age,address,NIC,deparment) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "');";
            SqlCommand cmd = new SqlCommand(qu,con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add new user" );
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }
    }
}
