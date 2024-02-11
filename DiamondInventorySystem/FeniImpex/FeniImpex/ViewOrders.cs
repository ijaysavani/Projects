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

namespace FeniImpex
{
	public partial class ViewOrders : Form
	{
		public ViewOrders()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jay\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
		void populateorders()
		{
			try
			{
				Con.Open();
				string Myquery = "select * from OrdersTb1";
				SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
				SqlCommandBuilder builder = new SqlCommandBuilder(da);
				var ds = new DataSet();
				da.Fill(ds);
				OrdersGv.DataSource = ds.Tables[0];
				Con.Close();

			}

			catch
			{

			}

		}

		private void OrderGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{ 
			if(printPreviewDialog1.ShowDialog()== DialogResult.OK)
		{

			printDocument1.Print();

		}
		}
		private void ViewOrders_Load(object sender, EventArgs e)
		{
			populateorders();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide(); 
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString("FENI IMPEX", new Font("Century", 35, FontStyle.Bold), Brushes.Black,new Point(230));
			e.Graphics.DrawString("Order Id:" + OrdersGv.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(75,100));
			e.Graphics.DrawString("Customer Id:" + OrdersGv.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(75, 140));
			e.Graphics.DrawString("Customer Name:" + OrdersGv.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(75, 180));
			e.Graphics.DrawString("Order Date:" + OrdersGv.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(75, 220));
			e.Graphics.DrawString("Total Amount:" + OrdersGv.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(75, 260));
			
		}
	}
}
