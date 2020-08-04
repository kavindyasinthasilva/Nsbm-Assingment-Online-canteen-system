using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bill.Properties
{
    public class User
    {
        public string user;
        public string pass;
        public string full;
        public string nic;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30");


        public User()
        {
           

        }

        public   void  S (string u ,string p)

        {
            this.user = u;
            this.pass = p;

        string commandString = "INSERT INTO login(username,password) VALUES('" + user.ToString() + "','" + pass.ToString() + "');";

        SqlCommand sqlCommand = new SqlCommand(commandString, con);

      
            sqlCommand.ExecuteNonQuery();
             con.Open();
            con.Close();




        }

       
        
        
    }
}
