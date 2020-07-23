using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill.Properties
{
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NiC = int.Parse(textBox1.Text);


            int Bsalary = int.Parse(textBox2.Text);

            int houres = int.Parse(textBox3.Text);
            int year = int.Parse(textBox3.Text);

            mainsalary s = new mainsalary();

            s.salary(NiC,Bsalary,houres,year);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }
    }
}
