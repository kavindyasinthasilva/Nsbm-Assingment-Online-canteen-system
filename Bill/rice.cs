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
    public partial class rice : Form
    {
        public rice()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();



            new cart().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int count = int.Parse(textBox2.Text);

            cartdb sky = new cartdb();
            sky.rice(count);


        }

        private void rice_Load(object sender, EventArgs e)
        {

        }
    }
}
