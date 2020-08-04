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
    public partial class oderdash : Form
    {
        public oderdash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
             new Coustomerlogin.coustomerlog(). Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30";
            string q = "SELECT * FROM oder";

            SqlDataAdapter ad = new SqlDataAdapter(q, con);
            DataSet set = new DataSet();
            ad.Fill(set, "oder");
            dataGridView2.DataSource = set.Tables["oder"];

        }
    }
}
