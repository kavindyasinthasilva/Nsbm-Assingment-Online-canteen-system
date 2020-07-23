using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();

            
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mamber().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

         
            
           
           new Properties.employer().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();



            new Properties.admin().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();




            new Properties.salary().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();




            new Properties.salaryshow().Show();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();




            new oderdash().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
             new Form1().Show();
        }
    }
}
