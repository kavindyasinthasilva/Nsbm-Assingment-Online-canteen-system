using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Bill.Checkout
{
    class chackcart
    {
      

      

        string name;
        string add;

        string phone;

        string t;//tele

        string re;




        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30");




        public void total(string reslt)
        {

            this.re = reslt;


        }

        public void other(string x, string y, string z,string t,string a,string b)
        {


            string commandStrings = "SELECT SUM (Total) FROM cart";
            con.Open();




            SqlCommand sqlCommands = new SqlCommand(commandStrings, con);
            object result = sqlCommands.ExecuteScalar();
            

            sqlCommands.ExecuteNonQuery();
            con.Close();




            string cratid =a;
            string css = b;
            this.name = x;
            this.add = y;
            this.phone = z;

            this.t = t;

          



            string commandString = "INSERT INTO oder(name,address,phone,cradit,css,desk,total) VALUES('" + name.ToString() + "','" + add.ToString() + "','" + phone.ToString() + "','" + cratid.ToString() + "','" + css.ToString() + "','" + t.ToString() + "','" + result.ToString() + "');";


            



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




    }
}