﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FeniImpex
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jay\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == false)
				PasswordTb.isPassword = true;
			else
				PasswordTb.isPassword = false;
		}

		private void label3_Click(object sender, EventArgs e)
		{
			UnameTb.Text = "";
			PasswordTb.Text = "";

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Con.Open();
			SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserTb1 where Uname ='" + UnameTb.Text + "' and Upassword = '" + PasswordTb.Text + "'", Con);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			if(dt.Rows[0][0].ToString() == "1")
			{
				HomeForm cust = new HomeForm();
				cust.Show();
				this.Hide();

			}

			else
			{
				MessageBox.Show("Wrong UserName Or Password");
			}
			Con.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
