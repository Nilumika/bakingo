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
    public partial class result1 : Form
    {
        public result1()
        {
            InitializeComponent();
        }

        private void result_Load(object sender, EventArgs e)
        {
          


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection ABC = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nilumika\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            
             ABC.Open();

            SqlCommand command = new SqlCommand("DELETE from Inventories where Ingridient");
            command.ExecuteNonQuery();
            //dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            ABC.Close();
            MessageBox.Show("Successfully Deleted");


        }

     
        private void result_Load_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nilumika\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            SqlCommand cmd1 = new SqlCommand("select * from Inventories", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = cmd1;

            dt.Clear();
            da.Fill(dt);

            dataGridView3.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            pl ss = new pl();
            ss.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Hide();
            Expense ss = new Expense();
            ss.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection ABC = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nilumika\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");

            ABC.Open();
            SqlCommand command = new SqlCommand("Update Inventories set Quantity = '" + textBox5.Text+ "' , UniPrice='" + textBox6.Text + "' where InventoryID = '" + textBox4.Text + "'", ABC);
            command.ExecuteNonQuery();
            ABC.Close();
            MessageBox.Show("Successfully Updated");


        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection ABC = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nilumika\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");

            ABC.Open();
            SqlCommand command = new SqlCommand("Delete FROM Inventories WHERE InventoryID ="+ dataGridView3.SelectedRows[0].Cells[0].Value.ToString()+"", ABC);
            command.ExecuteNonQuery();
            dataGridView3.Rows.RemoveAt(dataGridView3.SelectedRows[0].Index);
            ABC.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            store ss = new store();
            ss.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            inventory ss = new inventory();
            ss.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)

            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid Value");

            }
        }

        private void result1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && textBox6.Text.IndexOf('.') != -1)
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
    }
   

}
