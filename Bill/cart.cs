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
using System.Data.OleDb;

namespace Bill
{
    public partial class cart : Form
    {
    

        public cart()
        {
            InitializeComponent();
          
        }

        
        private void button5_Click(object sender, EventArgs e)
        {

            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30";

            string q = "SELECT * FROM cart";

            SqlDataAdapter ad = new SqlDataAdapter(q, con);
            DataSet set = new DataSet();
            ad.Fill(set, "cart");
            dataGridView1.DataSource = set.Tables["cart"];

           




        }

        private void button6_Click(object sender, EventArgs e)
        {

            String userid = textBox2.Text;

           string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30";

            string q = "delete from cart Where Id='" + userid + "'";

            SqlDataAdapter ad = new SqlDataAdapter(q, con);
            DataSet set = new DataSet();
            ad.Fill(set, "cart");
          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();



            new Properties.coutomerlog().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30");

            string commandString = "SELECT SUM (Total) FROM cart";
            con.Open();




            SqlCommand sqlCommand = new SqlCommand(commandString, con);
            object result = sqlCommand.ExecuteScalar();
            MessageBox.Show("Your bil value is " + result.ToString());

            sqlCommand.ExecuteNonQuery();
            con.Close();


            Checkout.chackcart obj = new Checkout.chackcart();

            int amount = int.Parse(result.ToString());

            obj.total(result);


            this.Hide();



            new Checkout.chackout().Show();


        }
    }
    
}
