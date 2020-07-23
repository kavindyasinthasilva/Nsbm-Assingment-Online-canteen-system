using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        }
    }
}
