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
    public partial class employer : Form
    {
        public employer()
        {
            InitializeComponent();
        }

        private void employer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30";
            string q = "SELECT * FROM member";

            SqlDataAdapter ad = new SqlDataAdapter(q, con);
            DataSet set = new DataSet();
            ad.Fill(set, "member");
            dataGridView1.DataSource = set.Tables["member"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30";
            string q = "SELECT * FROM member";
            SqlDataAdapter ad = new SqlDataAdapter(q, con);

            DataSet set = new DataSet();
            SqlCommand command = null;
            //Exception! Object reference not set to an instance of an object
            command.ExecuteNonQuery();
            set.Tables["member"].Rows[0].Delete();
            dataGridView1.DataSource = set.Tables["member"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
