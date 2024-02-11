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
	public partial class ManageProducts : Form
	{
		public ManageProducts()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jay\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

		void fillcategory()
		{
			string query = "select * from CategoryTb1";
			SqlCommand cmd = new SqlCommand(query, Con);
			SqlDataReader rdr;
			try
			{
				Con.Open();
				DataTable dt = new DataTable();
				dt.Columns.Add("CatName", typeof(string));
				rdr = cmd.ExecuteReader();
				dt.Load(rdr);
				CatCombo.ValueMember = "CatName";
				CatCombo.DataSource = dt;
				SearchCombo.ValueMember = "CatName";
				SearchCombo.DataSource = dt;
				Con.Close();
			}
			catch
			{

			}
		}

		private void label3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void ManageProducts_Load(object sender, EventArgs e)
		{
			fillcategory();
			populate();
			
		}
		void populate()
		{
			try
			{
				Con.Open();
				string Myquery = "select * from ProductTb1";
				SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
				SqlCommandBuilder builder = new SqlCommandBuilder(da);
				var ds = new DataSet();
				da.Fill(ds);
				ProductsGV.DataSource = ds.Tables[0];
				Con.Close();
			}

			catch
			{

			}

		}

		void filterbycategory()
		{
			try
			{
				Con.Open();
				string Myquery = "select * from ProductTb1 where ProdCat= '"+SearchCombo.SelectedValue.ToString()+"'";
				SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
				SqlCommandBuilder builder = new SqlCommandBuilder(da);
				var ds = new DataSet();
				da.Fill(ds);
				ProductsGV.DataSource = ds.Tables[0];
				Con.Close();
			}

			catch
			{

			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				Con.Open();
				SqlCommand cmd = new SqlCommand("insert into ProductTb1 values('" + ProdIdTb.Text + "', '" +ProdNameTb.Text + "', '" + QtyTb.Text + "', '" + PriceTb.Text + "', '" + DescriptionTb.Text + "', '" + CatCombo.SelectedValue.ToString() + "')", Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Product Successfully Added");
				Con.Close();
				populate();
			}
			catch
			{

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (ProdIdTb.Text == "")
			{
				MessageBox.Show("Enter The Product Id");
			}
			else
			{
				Con.Open();
				string myquery = "delete from ProductTb1 where ProdId=" + ProdIdTb.Text + ";";
				SqlCommand cmd = new SqlCommand(myquery, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Product Successfully Deleted");
				Con.Close();
				populate();
			}
		}

		private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ProdIdTb.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
			ProdNameTb.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
			QtyTb.Text = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
			PriceTb.Text = ProductsGV.SelectedRows[0].Cells[3].Value.ToString();
			DescriptionTb.Text = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();
			CatCombo.SelectedValue = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				Con.Open();
				SqlCommand cmd = new SqlCommand(" update ProductTb1 set ProdName='" + ProdNameTb.Text + "', ProdQty='" + QtyTb.Text + "', ProdPrice='" + PriceTb.Text + "', ProdDesc='" + DescriptionTb.Text + "', ProdCat='" + CatCombo.SelectedValue.ToString() + "' where ProdId=" + ProdIdTb.Text + "", Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Product Successfully UPDATED");
				Con.Close();
				populate();
			}
			catch
			{

			}
		}

		private void ProdNameTb_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void DescriptionTb_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			filterbycategory();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			populate();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ProdIdTb_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			HomeForm home = new HomeForm();
			home.Show();
			this.Hide();
		}

		private void ProdNameTb_OnValueChanged_1(object sender, EventArgs e)
		{

		}
	}
}
