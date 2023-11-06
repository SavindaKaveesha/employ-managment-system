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
    public partial class EmployeInfo : Form
    {
        public EmployeInfo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1EESEMR;Initial Catalog=employedb;Integrated Security=True ");

        private void EmployeInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cnn = new SqlCommand("SELECT * FROM emptab", con);
            SqlDataAdapter ad = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            ad.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
