﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy;

namespace From2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Log_in_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=LAPTOP-DPIBDA8N;Initial Catalog=pharmacy;Integrated Security=True;Trust Server Certificate=True");


            SqlConnection con = new SqlConnection("Data Source=LAPTOP-DPIBDA8N;Initial Catalog=pharmacy;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from employee where [User Name] = '" + UserBox.Text + "' and Password = '" + PassBox.Text + "'", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalide User Name or Password");
            }
            con.Close();
        }
    }
}