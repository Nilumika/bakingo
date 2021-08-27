using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace firstapp
{
    public partial class store : Form
    {
      

        public store()
        {
            InitializeComponent();
        }
        SqlConnection ABC = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nilumika\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand command = new SqlCommand();
        SqlDataReader dataRead;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void store_Load(object sender, EventArgs e)
        {
            command.Connection = ABC;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            result1 ss = new result1();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventory ss = new inventory();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            search ss = new search();
            ss.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ABC.Open();

            command.CommandText= "insert into Inventories(Ingredient,Quantity,UniPrice) values('" + comboBox1.Text+"','"+comboBox2.Text+"','"+textBox2.Text+ "' )";
            command.ExecuteNonQuery();
            ABC.Close();
       
           
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;

                MessageBox.Show("SUCCESSFULLY INSERTED!!!!!!!!!!");
          

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lblNoYes_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && textBox2.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46) 

            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid price");

            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void store_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid igredient name");

            }

        }
    }
}
