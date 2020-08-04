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

namespace Bill.Properties
{
    public partial class admin : Form
    {

       

       

        public admin()
        {
            InitializeComponent();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string user = textBox5.Text;
            string pass = textBox6.Text;
            string fullname = textBox6.Text;
            string nic = textBox6.Text;



            //User s = new User(user, pass);


            try
            {


                User sky = new User();

                sky.S(user, pass);

                User addnew = new User();

                MessageBox.Show("Add User name and Password!");


                this.Hide();
                new home().Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }







        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }
    }
}
