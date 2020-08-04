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

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30");

        public mamber()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string name = textBox1.Text ;
            string age = textBox2.Text;
            string address = textBox3.Text;
            string nic = textBox4.Text;
            string department = textBox5.Text;


        //  InharitansEmployer.employer x = new InharitansEmployer.employer();





          InharitansEmployer.employerdb y = new InharitansEmployer.employerdb(name, age, address, nic, department);



            string commandString = "INSERT INTO member(name,age,address,nic,deparment) VALUES('" + y.setname().ToString() + "','" + y.setage().ToString() + "','" + y.setadd().ToString() + "','" + y.setnic().ToString() + "','" + y.setde().ToString() + "');";





            try

            {
                SqlCommand sqlCommand = new SqlCommand(commandString, con);

                con.Open();

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Thank you!");
                con.Close();



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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
