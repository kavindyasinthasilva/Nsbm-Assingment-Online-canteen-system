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
    public partial class coutomerlog : Form
    {
        public coutomerlog()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();



            new breackfast().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();



            new lunch().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();



            new snack().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();



            new juce().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();



            new about().Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

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

        private void button9_Click(object sender, EventArgs e)
        {

            this.Hide();



            new items.sprice().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();



            new items.eggrice().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();



            new items.buger().Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();



            new items.orange().Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();



            new items.sanakpack().Show();
        }
    }
}
