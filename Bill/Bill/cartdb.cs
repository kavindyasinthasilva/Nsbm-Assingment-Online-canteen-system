using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bill
{
    class cartdb
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kavindu yasintha\Documents\billmangment.mdf;Integrated Security=True;Connect Timeout=30");

        public void rice(int count)
        {
            int id = 001;
            int price = 240;

            int amount = count;

            int newprice = amount * price;






            string commandString = "INSERT INTO cart(itemno,amount,price,Total) VALUES('" + id.ToString() + "','" + amount.ToString() + "', '" + price.ToString() + "','" + newprice.ToString() + "');";


            SqlCommand sqlCommand = new SqlCommand(commandString, con);

            con.Open();

            sqlCommand.ExecuteNonQuery();


            con.Close();


            // last step code 

        laststep.getlast x = new laststep.getlast();

           laststep. getlast.TextData = id;





          

           



        }
        public void sprice(int count)
        {
            int id = 002;
            int price = 450;

            int amount = count;

            int newprice = amount * price;

            string commandString = "INSERT INTO cart(itemno,amount,price,Total) VALUES('" + id.ToString() + "','" + amount.ToString() + "', '" + price.ToString() + "','" + newprice.ToString() + "');";


            SqlCommand sqlCommand = new SqlCommand(commandString, con);

            con.Open();

            sqlCommand.ExecuteNonQuery();
            con.Close();


            laststep.getlast x = new laststep.getlast();

            laststep.getlast.TextData1 = id;

            laststep.getlast y = new laststep.getlast();

            laststep.getlast.count1 = amount;



        }

        public void eggrice(int count)
        {
            int id = 003;
            int price = 150;

            int amount = count;

            int newprice = amount * price;

            string commandString = "INSERT INTO cart(itemno,amount,price,Total) VALUES('" + id.ToString() + "','" + amount.ToString() + "', '" + price.ToString() + "','" + newprice.ToString() + "');";


            SqlCommand sqlCommand = new SqlCommand(commandString, con);

            con.Open();

            sqlCommand.ExecuteNonQuery();
            con.Close();


            laststep.getlast x = new laststep.getlast();

            laststep.getlast.TextData2 = id;


        }
        public void buger(int count)
        {
            int id = 004;
            int price = 80;

            int amount = count;

            int newprice = amount * price;

            string commandString = "INSERT INTO cart(itemno,amount,price,Total) VALUES('" + id.ToString() + "','" + amount.ToString() + "', '" + price.ToString() + "','" + newprice.ToString() + "');";


            SqlCommand sqlCommand = new SqlCommand(commandString, con);

            con.Open();

            sqlCommand.ExecuteNonQuery();
            con.Close();



            laststep.getlast x = new laststep.getlast();

            laststep.getlast.TextData3 = id;


        }

        public void orange(int count)
        {
            int id = 005;
            int price = 150;

            int amount = count;

            int newprice = amount * price;

            string commandString = "INSERT INTO cart(itemno,amount,price,Total) VALUES('" + id.ToString() + "','" + amount.ToString() + "', '" + price.ToString() + "','" + newprice.ToString() + "');";


            SqlCommand sqlCommand = new SqlCommand(commandString, con);

            con.Open();

            sqlCommand.ExecuteNonQuery();
            con.Close();


            laststep.getlast x = new laststep.getlast();

            laststep.getlast.TextData4 = id;


        }

        public void snack(int count)
        {

            int id = 006;
            int price = 40;

            int amount = count;

            int newprice = amount * price;

            string commandString = "INSERT INTO cart(itemno,amount,price,Total) VALUES('" + id.ToString() + "','" + amount.ToString() + "', '" + price.ToString() + "','" + newprice.ToString() + "');";


            SqlCommand sqlCommand = new SqlCommand(commandString, con);

            con.Open();

            sqlCommand.ExecuteNonQuery();
            con.Close();


            laststep.getlast x = new laststep.getlast();

            laststep.getlast.TextData5 = id;


        }

        public void riceandcarry(int count)
        {


            int id = 007;
            int price = 140;

            int amount = count;

            int newprice = amount * price;

            string commandString = "INSERT INTO cart(itemno,amount,price,Total) VALUES('" + id.ToString() + "','" + amount.ToString() + "', '" + price.ToString() + "','" + newprice.ToString() + "');";


            SqlCommand sqlCommand = new SqlCommand(commandString, con);

            con.Open();

            sqlCommand.ExecuteNonQuery();
            con.Close();


            laststep.getlast x = new laststep.getlast();

            laststep.getlast.TextData6 = id;


        }

        public void iddiappa(int count)
        {
            int id = 008;
            int price = 40;

            int amount = count;

            int newprice = amount * price;

            string commandString = "INSERT INTO cart(itemno,amount,price,Total) VALUES('" + id.ToString() + "','" + amount.ToString() + "', '" + price.ToString() + "','" + newprice.ToString() + "');";


            SqlCommand sqlCommand = new SqlCommand(commandString, con);

            con.Open();

            sqlCommand.ExecuteNonQuery();
            con.Close();

        }

        public void kiribath(int count)
        {
            int id = 009;
            int price = 40;

            int amount = count;

            int newprice = amount * price;

            string commandString = "INSERT INTO cart(itemno,amount,price,Total) VALUES('" + id.ToString() + "','" + amount.ToString() + "', '" + price.ToString() + "','" + newprice.ToString() + "');";


            SqlCommand sqlCommand = new SqlCommand(commandString, con);

            con.Open();

            sqlCommand.ExecuteNonQuery();
            con.Close();

            laststep.getlast x = new laststep.getlast();

            laststep.getlast.TextData7 = id;


        }



    }





}
