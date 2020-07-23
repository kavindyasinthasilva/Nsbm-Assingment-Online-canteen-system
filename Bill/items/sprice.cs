using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill.items
{
    public partial class sprice : Form
    {
        public sprice()
        {
            InitializeComponent();
        }

        private void sprice_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int count = int.Parse(textBox2.Text);

            cartdb sky = new cartdb();
            sky.sprice(count);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();



            new Properties.coutomerlog().Show();
        }
    }
}
