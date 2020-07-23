using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bill.Properties
{
    class basicsal : mainsalary
    {
        int upadtsalary;
        int bssic;
        int hour;
        int yera;
       

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30");


        public void newdata(int x, int y, int z, int j)
        {

            this.bssic = y;
            this.hour = z;
            this.yera = j;



            if (yera >= 5)
            {

                if (j>18)
                {
                    // update salry ;
                    upadtsalary = y * 1000;

                }
               

            }
            else if( yera>=5)
            {

                if (j==18)
                    {
                      upadtsalary = y * 2000;
                    
                    }

            }
            
         
            

            string commandString = "INSERT INTO salary(NIC,Basic,year,houer,p) VALUES('" + x.ToString() + "','" + j.ToString() + "', '" + z.ToString() + "','" + y.ToString() + "','" + upadtsalary.ToString() + "');";

            SqlCommand sqlCommand = new SqlCommand(commandString, con);

            con.Open();

            sqlCommand.ExecuteNonQuery();
            con.Close();


        }
      


        

    }
}
