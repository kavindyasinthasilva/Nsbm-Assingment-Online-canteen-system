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
    public partial class sanakpack : Form
    {
        public sanakpack()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int count = int.Parse(textBox2.Text);

            cartdb sky = new cartdb();
            sky.snack(count);
        }
    }
}
