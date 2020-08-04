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
    public partial class breackfast : Form
    {
        public breackfast()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();



            new Properties .coutomerlog().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();



            new items.buger().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();



            new items.riceandcarry().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();



            new items.iddiappa().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();



            new items.kiribath().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" This is Not stock");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" This is Not stock");
        }
    }
}
