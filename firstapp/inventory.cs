using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstapp
{
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            search ss = new search();
            ss.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            store ss = new store();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            result1 ss = new result1();
            ss.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Expense ss = new Expense();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            pl ss = new pl();
            ss.Show();
        }

       

        private void inventory_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main ss = new Main();
            ss.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            pl ss = new pl();
            ss.Show();
        }
    }
}
