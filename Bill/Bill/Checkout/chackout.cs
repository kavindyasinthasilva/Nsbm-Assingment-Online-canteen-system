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


namespace Bill.Checkout
{
    public partial class chackout : Form
    {
        public chackout()
        {
            InitializeComponent();
        }

        private void chackout_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30");

            var query = "SELECT SUM (Total) FROM cart";
            con.Open();


            using (var cmd = new SqlCommand(query, con))
            {
                TotalValueLabel.Text = cmd.ExecuteScalar().ToString();
            }

           
            con.Close();



            chackcart x = new chackcart();

            x.total(TotalValueLabel.Text);




        }

        private void panel3_Paint(object sender, PaintEventArgs e)




        {


           





            







        }

        private void button2_Click(object sender, EventArgs e)
        {

            

            string name;
            string address;
            string phone;
            string cradit;
            string css;
            string table;


            name = textBox3.Text;
            address = textBox4.Text;

            phone = textBox5.Text;
            cradit = textBox6.Text;
            css = textBox7.Text;
            table = textBox8.Text;

            Checkout.encapsul obj = new Checkout.encapsul();

            obj.craditcard = cradit;
            obj.cssnumber = css;

      


            Checkout.chackcart dit = new Checkout.chackcart();

            dit.other(name,address, phone,table,obj.craditcard, obj.cssnumber);


            this.Hide();

            new last().Show();




        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Properties.coutomerlog();
        }

        private void TotalValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
