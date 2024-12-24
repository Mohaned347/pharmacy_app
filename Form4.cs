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

namespace main_APP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-DPIBDA8N;Initial Catalog=pharmacy;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from employee where [User Name] = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-DPIBDA8N;Initial Catalog=pharmacy;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from employee where [User Name] = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
        }
    }
}
