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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            store ss = new store();
            ss.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nilumika\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            if (conn.State == ConnectionState.Closed)

                conn.Open();
            SqlCommand command = new SqlCommand("Select Ingredient,Quantity from Inventories Where Ingredient like '%" + textBox1.Text+"%'",conn);

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            inventory ss = new inventory();
            ss.Show();
        }
    }
}
