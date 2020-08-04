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
    public partial class salaryshow : Form
    {
        public salaryshow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30";

            string q = "SELECT * FROM salary";

            SqlDataAdapter ad = new SqlDataAdapter(q, con);
            DataSet set = new DataSet();
            ad.Fill(set, "salary");
            dataGridView1.DataSource = set.Tables["salary"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();




            new home().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
