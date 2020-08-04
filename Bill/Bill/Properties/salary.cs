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
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            // inharitance - mian salary -baseclass
            // basical -derived classs


            int NiC = int.Parse(textBox1.Text);


            int Bsalary = int.Parse(textBox2.Text);

            int houres = int.Parse(textBox3.Text);
            int year = int.Parse(textBox3.Text);

            mainsalary s = new mainsalary();
            Basicsal x = new Basicsal(NiC, Bsalary, houres, year);

            


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30");
            string qu = "INSERT INTO salary( NIC,Basic,year,houer,p) VALUES ('" +  x.setnic ().ToString() + "','" + x.setBsalary().ToString() + "','" + x.setyear().ToString() + "','" + x.sethoures().ToString() + "', '" + x.Updatesalary().ToString() + "');";
            SqlCommand cmd = new SqlCommand(qu, con);

            try
            {

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add new Salary");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }













        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }
    }
}
