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
    public partial class last : Form
    {
        public last()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30");

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 700)
            {
                timer1.Stop();

                // items number
                int id = laststep.getlast.TextData;
                int id1 = laststep.getlast.TextData1;





                // count


                int count = laststep.getlast.count1;

                string commandStrings = "INSERT INTO items(iteme,count) VALUES('" + id.ToString() + "','" + count.ToString() + "');";


             //     string commandStringe = "INSERT INTO items(iteme) VALUES('" + id1.ToString() + "');";
             



             



                SqlCommand sqlCommands = new SqlCommand(commandStrings, con);

              //  SqlCommand sqlCommandse = new SqlCommand(commandStringe, con);

                con.Open();

                sqlCommands.ExecuteNonQuery();


                con.Close();

                this.Hide();

                new Coustomerlogin.coustomerlog().Show();




            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {











        }
    }
}
