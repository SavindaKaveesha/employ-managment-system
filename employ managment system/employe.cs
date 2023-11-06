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

namespace employ_managment_system
{
    public partial class employe : Form
    {
        public employe()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1EESEMR;Initial Catalog=employedb;Integrated Security=True ");

        private void employe_Load(object sender, EventArgs e)
        {
            bindData();
        }

        private void bindData()
        {
            SqlCommand cnn = new SqlCommand("SELECT * FROM emptab", con);
            SqlDataAdapter ad = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cnn = new SqlCommand("INSERT INTO emptab (id,employeeName, age, email, salary, Dob, benifit) VALUES (@id, @employeeName, @age, @email, @salary, @dob, @benifit)", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@employeeName", textBox7.Text);
            cnn.Parameters.AddWithValue("@age", int.Parse(textBox6.Text));
            cnn.Parameters.AddWithValue("@email", textBox5.Text);
            cnn.Parameters.AddWithValue("@salary", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@dob", DateTime.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@benifit", textBox2.Text);

            cnn.ExecuteNonQuery();
            con.Close();

            bindData();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cnn = new SqlCommand("DELETE FROM emptab WHERE id = @id", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();
            con.Close();

            bindData();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
    }
}
