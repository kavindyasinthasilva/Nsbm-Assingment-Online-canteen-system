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
    public partial class lunch : Form
    {
        public lunch()
        {
            InitializeComponent();
        }

        private void lunch_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();



            new Properties.coutomerlog().Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();



            new cart().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Hide();



            new rice().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();



            new items.sprice().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();



            new items.eggrice().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" This is Not stock");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" This is Not stock");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" This is Not stock");
        }
    }
}
