﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeniImpex
{
	public partial class HomeForm : Form
	{
		public HomeForm()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			ManageProducts prod = new ManageProducts();
			prod.Show();
			this.Hide(); 
		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{
			ManageUsers users = new ManageUsers();
			users.Show();
			this.Hide();
		}

		private void panel6_Paint(object sender, PaintEventArgs e)
		{
			ManageCategories cat = new ManageCategories();
			cat.Show();
			this.Hide();
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{
			ManageCustomers Cust = new ManageCustomers();
			Cust.Show();
			this.Hide();
		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{
			ManageOrders Orders = new ManageOrders();
			Orders.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 login = new Form1();
			login.Show();
			this.Hide();
		}

		private void HomeForm_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			ManageProducts prod = new ManageProducts();
			prod.Show();
			this.Hide();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			ManageUsers users = new ManageUsers();
			users.Show();
			this.Hide();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			ManageCategories cat = new ManageCategories();
			cat.Show();
			this.Hide();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			ManageOrders Orders = new ManageOrders();
			Orders.Show();
			this.Hide();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			ManageCustomers Cust = new ManageCustomers();
			Cust.Show();
			this.Hide();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
