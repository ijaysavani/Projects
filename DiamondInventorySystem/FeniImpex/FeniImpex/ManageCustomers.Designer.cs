using System;

namespace FeniImpex
{
	partial class ManageCustomers
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Customerid = new ns1.BunifuMaterialTextbox();
			this.CustomernameTb = new ns1.BunifuMaterialTextbox();
			this.CustomerPhoneTb = new ns1.BunifuMaterialTextbox();
			this.CustomersGV = new Guna.UI2.WinForms.Guna2DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.OrderLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.AmountLabel = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.DateLabel = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DimGray;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(956, 100);
			this.panel1.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(925, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "X";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(323, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(273, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Manage Customers";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(349, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(241, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "FENI IMPEX®";
			// 
			// Customerid
			// 
			this.Customerid.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Customerid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Customerid.ForeColor = System.Drawing.Color.Black;
			this.Customerid.HintForeColor = System.Drawing.Color.Empty;
			this.Customerid.HintText = "";
			this.Customerid.isPassword = false;
			this.Customerid.LineFocusedColor = System.Drawing.Color.Blue;
			this.Customerid.LineIdleColor = System.Drawing.Color.Maroon;
			this.Customerid.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.Customerid.LineThickness = 4;
			this.Customerid.Location = new System.Drawing.Point(52, 160);
			this.Customerid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Customerid.Name = "Customerid";
			this.Customerid.Size = new System.Drawing.Size(216, 41);
			this.Customerid.TabIndex = 2;
			this.Customerid.Text = "CustomerId";
			this.Customerid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// CustomernameTb
			// 
			this.CustomernameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.CustomernameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CustomernameTb.ForeColor = System.Drawing.Color.Black;
			this.CustomernameTb.HintForeColor = System.Drawing.Color.Empty;
			this.CustomernameTb.HintText = "";
			this.CustomernameTb.isPassword = false;
			this.CustomernameTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.CustomernameTb.LineIdleColor = System.Drawing.Color.Maroon;
			this.CustomernameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.CustomernameTb.LineThickness = 4;
			this.CustomernameTb.Location = new System.Drawing.Point(52, 211);
			this.CustomernameTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.CustomernameTb.Name = "CustomernameTb";
			this.CustomernameTb.Size = new System.Drawing.Size(216, 41);
			this.CustomernameTb.TabIndex = 3;
			this.CustomernameTb.Text = "CustomerName";
			this.CustomernameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// CustomerPhoneTb
			// 
			this.CustomerPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.CustomerPhoneTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CustomerPhoneTb.ForeColor = System.Drawing.Color.Black;
			this.CustomerPhoneTb.HintForeColor = System.Drawing.Color.Empty;
			this.CustomerPhoneTb.HintText = "";
			this.CustomerPhoneTb.isPassword = false;
			this.CustomerPhoneTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.CustomerPhoneTb.LineIdleColor = System.Drawing.Color.Maroon;
			this.CustomerPhoneTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.CustomerPhoneTb.LineThickness = 4;
			this.CustomerPhoneTb.Location = new System.Drawing.Point(52, 262);
			this.CustomerPhoneTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.CustomerPhoneTb.Name = "CustomerPhoneTb";
			this.CustomerPhoneTb.Size = new System.Drawing.Size(216, 41);
			this.CustomerPhoneTb.TabIndex = 4;
			this.CustomerPhoneTb.Text = "CustomerPhone";
			this.CustomerPhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// CustomersGV
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.CustomersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.CustomersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.CustomersGV.BackgroundColor = System.Drawing.Color.White;
			this.CustomersGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.CustomersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.CustomersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.CustomersGV.ColumnHeadersHeight = 25;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.CustomersGV.DefaultCellStyle = dataGridViewCellStyle3;
			this.CustomersGV.EnableHeadersVisualStyles = false;
			this.CustomersGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.CustomersGV.Location = new System.Drawing.Point(387, 160);
			this.CustomersGV.Name = "CustomersGV";
			this.CustomersGV.RowHeadersVisible = false;
			this.CustomersGV.RowTemplate.Height = 30;
			this.CustomersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.CustomersGV.Size = new System.Drawing.Size(529, 362);
			this.CustomersGV.TabIndex = 14;
			this.CustomersGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.CustomersGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.CustomersGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.CustomersGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.CustomersGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.CustomersGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.CustomersGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.CustomersGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.CustomersGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
			this.CustomersGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.CustomersGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CustomersGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.CustomersGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.CustomersGV.ThemeStyle.HeaderStyle.Height = 25;
			this.CustomersGV.ThemeStyle.ReadOnly = false;
			this.CustomersGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.CustomersGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
			this.CustomersGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.CustomersGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.CustomersGV.ThemeStyle.RowsStyle.Height = 30;
			this.CustomersGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.CustomersGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.CustomersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellContentClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(542, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(220, 35);
			this.label4.TabIndex = 13;
			this.label4.Text = "CUSTOMERS LIST";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.DimGray;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(124, 400);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(84, 32);
			this.button4.TabIndex = 18;
			this.button4.Text = "Home";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.DimGray;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(214, 362);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(84, 32);
			this.button3.TabIndex = 17;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.DimGray;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(124, 362);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 32);
			this.button2.TabIndex = 16;
			this.button2.Text = "Edit";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DimGray;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(34, 362);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 32);
			this.button1.TabIndex = 15;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DimGray;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 688);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(956, 12);
			this.panel2.TabIndex = 19;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Brown;
			this.panel3.Controls.Add(this.OrderLabel);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(81, 555);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(187, 100);
			this.panel3.TabIndex = 20;
			// 
			// OrderLabel
			// 
			this.OrderLabel.AutoSize = true;
			this.OrderLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OrderLabel.ForeColor = System.Drawing.SystemColors.Window;
			this.OrderLabel.Location = new System.Drawing.Point(46, 31);
			this.OrderLabel.Name = "OrderLabel";
			this.OrderLabel.Size = new System.Drawing.Size(101, 33);
			this.OrderLabel.TabIndex = 21;
			this.OrderLabel.Text = "Orders";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.Window;
			this.label5.Location = new System.Drawing.Point(-4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 19);
			this.label5.TabIndex = 2;
			this.label5.Text = "Orders Count";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Green;
			this.panel4.Controls.Add(this.AmountLabel);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Location = new System.Drawing.Point(375, 555);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(187, 100);
			this.panel4.TabIndex = 21;
			// 
			// AmountLabel
			// 
			this.AmountLabel.AutoSize = true;
			this.AmountLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AmountLabel.ForeColor = System.Drawing.SystemColors.Window;
			this.AmountLabel.Location = new System.Drawing.Point(37, 31);
			this.AmountLabel.Name = "AmountLabel";
			this.AmountLabel.Size = new System.Drawing.Size(120, 33);
			this.AmountLabel.TabIndex = 21;
			this.AmountLabel.Text = "Amount";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Window;
			this.label8.Location = new System.Drawing.Point(3, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(125, 19);
			this.label8.TabIndex = 2;
			this.label8.Text = "Orders Amount";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.SteelBlue;
			this.panel5.Controls.Add(this.DateLabel);
			this.panel5.Controls.Add(this.label10);
			this.panel5.Location = new System.Drawing.Point(660, 555);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(187, 100);
			this.panel5.TabIndex = 22;
			// 
			// DateLabel
			// 
			this.DateLabel.AutoSize = true;
			this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateLabel.ForeColor = System.Drawing.SystemColors.Window;
			this.DateLabel.Location = new System.Drawing.Point(46, 31);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(81, 33);
			this.DateLabel.TabIndex = 21;
			this.DateLabel.Text = "Date";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.Window;
			this.label10.Location = new System.Drawing.Point(-4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(125, 19);
			this.label10.TabIndex = 2;
			this.label10.Text = "Last Order Date";
			// 
			// ManageCustomers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(956, 700);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.CustomersGV);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.CustomerPhoneTb);
			this.Controls.Add(this.CustomernameTb);
			this.Controls.Add(this.Customerid);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageCustomers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageCustomers";
			this.Load += new System.EventHandler(this.ManageCustomers_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private ns1.BunifuMaterialTextbox Customerid;
		private ns1.BunifuMaterialTextbox CustomernameTb;
		private ns1.BunifuMaterialTextbox CustomerPhoneTb;
		private Guna.UI2.WinForms.Guna2DataGridView CustomersGV;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label OrderLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label AmountLabel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label DateLabel;
		private System.Windows.Forms.Label label10;
	}
}